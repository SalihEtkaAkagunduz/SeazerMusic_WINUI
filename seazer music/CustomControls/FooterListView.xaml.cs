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
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace seazer_music.CustomControls
{
    public sealed partial class FooterListView : UserControl
    {
        public FooterListView()
        {
            InitializeComponent();
            CardScrollViewer.ViewChanged += CardScrollViewer_ViewChanged;

            // Baþlangýçta buton görünürlüðünü güncelle
            Loaded += (s, e) =>
            {
                UpdateScrollButtons(); BtnLeft.Visibility = Visibility.Collapsed;
                BtnRight.Visibility = Visibility.Collapsed;
            };

        }

        private void CardScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            UpdateScrollButtons();
        }

        private void UpdateScrollButtons()
        {
            if (CardScrollViewer.ScrollableWidth > 0)
            {
                BtnLeft.Visibility = CardScrollViewer.HorizontalOffset > 0 ? Visibility.Visible : Visibility.Collapsed;
                BtnRight.Visibility = CardScrollViewer.HorizontalOffset < CardScrollViewer.ScrollableWidth ? Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                BtnLeft.Visibility = Visibility.Collapsed;
                BtnRight.Visibility = Visibility.Collapsed;
            }
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(nameof(Title), typeof(string), typeof(FooterListView), new PropertyMetadata(string.Empty));

        public IEnumerable<FooterList> Items
        {
            get => (IEnumerable<FooterList>)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }
        private void Item_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            var grid = sender as Grid;
            grid.Opacity = 1;
        }

        private void Item_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            var grid = sender as Grid;
            grid.Opacity = 0;
        }
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register(nameof(Items), typeof(IEnumerable<FooterList>), typeof(FooterListView), new PropertyMetadata(null));

        private void BtnRight_Click(object sender, RoutedEventArgs e)
        {
            double newOffset = Math.Min(CardScrollViewer.HorizontalOffset + 600, CardScrollViewer.ScrollableWidth);
            // disableAnimation: false -> animasyon açýk (yumuþak geçiþ)
            CardScrollViewer.ChangeView(newOffset, null, null, disableAnimation: false);
        }

        private void BtnLeft_Click(object sender, RoutedEventArgs e)
        {
            double newOffset = Math.Max(CardScrollViewer.HorizontalOffset - 600, 0);
            CardScrollViewer.ChangeView(newOffset, null, null, disableAnimation: false);
        }


        private void Grid_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            // Sadece kaydýrma varsa göster
            if (CardScrollViewer.ScrollableWidth > 0)
            {
                BtnLeft.Visibility = CardScrollViewer.HorizontalOffset > 0 ? Visibility.Visible : Visibility.Collapsed;
                BtnRight.Visibility = CardScrollViewer.HorizontalOffset < CardScrollViewer.ScrollableWidth ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private void Grid_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            BtnLeft.Visibility = Visibility.Collapsed;
            BtnRight.Visibility = Visibility.Collapsed;
        }
    }
}
