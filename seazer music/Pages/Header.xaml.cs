using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
 
using seazer_music.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using WinRT.seazer_musicVtableClasses;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace seazer_music.Pages
{
    /// <summary>   
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
  
    public sealed partial class Header : Page
    {double sessvalue=0;
        public Header()
        {
            InitializeComponent();
            this.Loaded += Header_Loaded;
        }
        private void Header_Loaded(object sender, RoutedEventArgs e)
        {
            
            double storedValue = Storage.DoubleStorage.getStorage("Volume");
            volumeSlider.Value = storedValue;
            sessvalue = storedValue;
            setsesvlm();
           
        }

        private bool isDragging = false;
        private void Slider_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ShowText();
        }

        private void Slider_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (!isDragging)
            {
                HideText();
            }
        }

        private void ShowText()
        {
            TextStart.Visibility = Visibility.Visible;
            TextEnd.Visibility = Visibility.Visible;
        }

        private void HideText()
        {
            TextStart.Visibility = Visibility.Collapsed;
            TextEnd.Visibility = Visibility.Collapsed;
        }
        private DependencyObject GetElementFromParent(DependencyObject parent, string childname)
        {
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is FrameworkElement childframeworkelement && childframeworkelement.Name == childname)
                    return child;

                var FindRes = GetElementFromParent(child, childname);
                if (FindRes != null)
                    return FindRes;
            }
            return null;
        }
        private void Slider_Loaded(object sender, RoutedEventArgs e)
        {
            var SliderThumb = GetElementFromParent(sender as DependencyObject, "HorizontalThumb"); //Make sure to put the right name for your slider layout options are: ("VerticalThumb", "HorizontalThumb")
            if (SliderThumb != null)
            {
                if (SliderThumb is Thumb thumb)
                {
                    //Here you can change everything you like:
                    thumb.Background = new SolidColorBrush(Colors.Blue);
                    thumb.CornerRadius = new CornerRadius(5);
                    thumb.Width = 10;

                    thumb.Opacity = 0.8;
                    thumb.Height = 10;
                }
                else
                {
                    //SliderThumb is not an object of type Thumb
                }
            }
            else
            {
                //SliderThumb is null
            }
        }


        private void MySlider_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            isDragging = true;
            ShowText();
        }
        private double GetEndSeconds()
        {
            if (TextEnd?.Text == null)
                return 0; // Hata vermesin, boþsa 0 saniye varsay

            string[] parts = TextEnd.Text.Split(':');
            if (parts.Length == 2 &&
                int.TryParse(parts[0], out int minutes) &&
                int.TryParse(parts[1], out int seconds))
            {
                return minutes * 60 + seconds;
            }
            return 0;
        }

        private void MySlider_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            isDragging = false;
            HideText();
        }

        private void MySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            double maxSeconds = GetEndSeconds();
            double currentSeconds = (MySlider.Value / MySlider.Maximum) * maxSeconds;

            TimeSpan time = TimeSpan.FromSeconds(currentSeconds);
            TextStart.Text = $"{(int)time.Minutes}:{time.Seconds:00}";
        }
        public void setsesvlm()
        {
            if (sesbtnfnt != null)
            {
                if (Static.HeadphonesConnected)
                {
                    if (sessvalue == 0)
                    {
                        // Ses tamamen kapalý ? Özel ikon (icomoon)
                        sesbtnfnt.Glyph = "\uED30";
                        sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                    }
                    else if (sessvalue > 0 && sessvalue <= 33)
                    {
                        // Düþük ses ? MDL2
                        sesbtnfnt.Glyph = "\uED31";
                        sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                    }
                    else if (sessvalue > 33 && sessvalue <= 66)
                    {
                        // Orta ses
                        sesbtnfnt.Glyph = "\uED32";
                        sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                    }
                    else if (sessvalue > 66)
                    {
                        // Yüksek ses
                        sesbtnfnt.Glyph = "\uED33";
                        sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                    }
                }
                else
                {
                    if (sessvalue == 0)
                    {
                        // Ses tamamen kapalý ? Özel ikon (icomoon)
                        sesbtnfnt.Glyph = "\uE992";
                        sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                    }
                    else if (sessvalue > 0 && sessvalue <= 33)
                    {
                        // Düþük ses ? MDL2
                        sesbtnfnt.Glyph = "\uE993";
                        sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                    }
                    else if (sessvalue > 33 && sessvalue <= 66)
                    {
                        // Orta ses
                        sesbtnfnt.Glyph = "\uE994";
                        sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                    }
                    else if (sessvalue > 66)
                    {
                        // Yüksek ses
                        sesbtnfnt.Glyph = "\uE995";
                        sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                    }
                }



            }
        }
        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            volumeSlider.IsEnabled = true;
            setsesvlm();

        }


        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            volumeSlider.IsEnabled = false;

            if (sesbtnfnt != null)
            {
                 
                    sesbtnfnt.Glyph = "\uE74F";
                    sesbtnfnt.FontFamily = new FontFamily("Segoe MDL2 Assets");
                
            }
        }
        int check = 0;
            
        private void volumeSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (check == 0)
            {
                check++;
            }
            else
            {
 sessvalue = e.NewValue;

            setsesvlm();
            Storage.DoubleStorage.setStorage(e.NewValue, "Volume");
            }
               
        }
      }
}
