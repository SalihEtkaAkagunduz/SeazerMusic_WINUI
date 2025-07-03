using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
 
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT;
 
 

namespace seazer_music
{
   
    public sealed partial class MainWindow : Window
    {
        IntPtr hWnd = IntPtr.Zero;
        private SUBCLASSPROC SubClassDelegate;
        public MainWindow()
        {
            InitializeComponent();
            contentFrameheader.Navigate(typeof(seazer_music.Pages.Header));
            contentFrame8.Navigate(typeof(seazer_music.Pages.MainPage));
            contentFrame8.Navigated += ContentFrame8_Navigated;
            hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            SubClassDelegate = new SUBCLASSPROC(WindowSubClass);
            this.SizeChanged += MainWindow_SizeChanged; ;

            bool bReturn = SetWindowSubclass(hWnd, SubClassDelegate, 0, 0);
            nvSample8.SelectionChanged += NvSample8_SelectionChanged;
            nvSample8.BackRequested += NvSample8_BackRequested;
        }
        double windowWidth;
        private void MainWindow_SizeChanged(object sender, WindowSizeChangedEventArgs args)
        {
              windowWidth = args.Size.Width;

            if (windowWidth < 1320)
            {
                   close();
            }
            else
            {
                   open();
            
            }
        }
        void open()
        {
            if(windowWidth < 1320)
            {
                grid2.Margin = new Thickness(4, 0, 12, 0);
                nvSample8.IsPaneToggleButtonVisible = true;
            }
            else
            {
                grid2.Margin = new Thickness(40, 0, 12, 0);
                nvSample8.IsPaneToggleButtonVisible = false;
            }
            
            nvSample8.IsPaneOpen = true; grid.Margin = new Thickness(290, 0, 0, 0);
        }
        void close()
        {
            grid2.Margin = new Thickness(44, 0, 12, 0);
            nvSample8.IsPaneToggleButtonVisible = true;
            nvSample8.IsPaneOpen = false;
            grid.Margin = new Thickness(50, 0, 0, 0);
        }
        private void SearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Eer aktif sayfa "Gzat" deilse, "Gzat" sayfasna gei yap
            if (contentFrame8.Content?.GetType() != typeof(seazer_music.Pages.Gözat))
            {
                contentFrame8.Navigate(typeof(seazer_music.Pages.Gözat));
            }
        }
        private int WindowSubClass(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam, IntPtr uIdSubclass, uint dwRefData)
        {
            switch (uMsg)
            {
                case WM_GETMINMAXINFO:
                    {
                        MINMAXINFO mmi = (MINMAXINFO)Marshal.PtrToStructure(lParam, typeof(MINMAXINFO));
                        mmi.ptMinTrackSize.X = 1084;
                        mmi.ptMinTrackSize.Y = 423;
                        Marshal.StructureToPtr(mmi, lParam, false);
                        return 0;
                    }
                    break;
            }
            return DefSubclassProc(hWnd, uMsg, wParam, lParam);
        }


        public delegate int SUBCLASSPROC(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam, IntPtr uIdSubclass, uint dwRefData);

        [DllImport("Comctl32.dll", SetLastError = true)]
        public static extern bool SetWindowSubclass(IntPtr hWnd, SUBCLASSPROC pfnSubclass, uint uIdSubclass, uint dwRefData);

        [DllImport("Comctl32.dll", SetLastError = true)]
        public static extern int DefSubclassProc(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);

        public const int WM_GETMINMAXINFO = 0x0024;

        public struct MINMAXINFO
        {
            public System.Drawing.Point ptReserved;
            public System.Drawing.Point ptMaxSize;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Point ptMinTrackSize;
            public System.Drawing.Point ptMaxTrackSize;
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (contentFrame8.CanGoBack)
            {
                contentFrame8.GoBack();
            }
        }

        private void nvSample8_PaneOpening(NavigationView sender, object args)
        {
            open();
        }

        private void nvSample8_PaneClosing(NavigationView sender, NavigationViewPaneClosingEventArgs args)
        {
            close();
        }
        
        private void NvSample8_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem selectedItem)
            {
                string pageKey = null;
                // Öncelikle Tag varsa onu kullan, yoksa Content'i kullan
                if (selectedItem.Tag is string tag && !string.IsNullOrWhiteSpace(tag))
                    pageKey = tag;
                else if (selectedItem.Content is string content && !string.IsNullOrWhiteSpace(content))
                    pageKey = content;
                else if (selectedItem.Content is StackPanel sp && sp.Children.Count > 1 && sp.Children[1] is TextBlock tb)
                    pageKey = tb.Text;

                if (!string.IsNullOrWhiteSpace(pageKey))
                {
                    // Türkçe karakterleri ve boşlukları temizle, sayfa adını bul
                    string pageName = GetPageNameFromKey(pageKey);
                    Type pageType = Type.GetType($"seazer_music.Pages.{pageName}");
                    if (pageType != null)
                    {
                        contentFrame8.Navigate(pageType);
                    }
                }
            }
        }

        private void NvSample8_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (contentFrame8.CanGoBack)
            {
                contentFrame8.GoBack();
            }
        }

        private string GetPageNameFromKey(string key)
        {
            // NavigationViewItem'daki metni Pages klasöründeki sayfa adına çevirir
            // Örneğin: "Gözat" -> "Gözat", "Sanatçılar" -> "Artists", "Albümler" -> "Albums"
            // Burada eşleştirme yapılacak
            switch (key.Trim().ToLowerInvariant())
            {
                case "ana sayfa": return "MainPage";
                case "gözat": return "Explore";
                case "arşiv": return "Library";
                case "son eklenenler": return "Recent";
                case "sanatçılar": return "Artists";
                case "albümler": return "Albums";
                case "parçalar": return "Songs";
                case "listeler": return "ListsMain";
                case "favori listeler": return "ListFavorite";
                case "tüm listeler": return "ListsAll";
                case "ders 4.0": return "ClipMain";
                case "ders 3.0": return "ClipAll";
                case "ders 2.0": return "ClipFavorite";
                case "podcastler": return "PodcastMain";
                case "favori podcastler": return "PodcastFavorite";
                case "tüm podcastler": return "PodcastAll";
                case "teknoseyir": return "PodcastMain";
                case "hwp": return "PodcastAll";
                case "garip galaktik": return "PodcastFavorite";
                case "videolar ve klipler": return "ClipMain";
                case "favori videolar ve klipler": return "ClipFavorite";
                case "tüm videolar ve klipler": return "ClipAll";
                default:
                    // Türkçe karakterleri kaldırıp, ilk harfi büyük yap
                    string cleaned = key.Replace(" ", "").Replace("ç", "c").Replace("ğ", "g").Replace("ı", "i").Replace("ö", "o").Replace("ş", "s").Replace("ü", "u");
                    return char.ToUpper(cleaned[0]) + cleaned.Substring(1);
            }
        }

        private void ContentFrame8_Navigated(object sender, NavigationEventArgs e)
        {
            nvSample8.IsBackEnabled = contentFrame8.CanGoBack;
        }
    }
    }
