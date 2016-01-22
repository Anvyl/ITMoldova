using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ITMUtils.NewsParsing;
using Windows.Storage;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ITMoldova
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Frame rootFrame = Window.Current.Content as Frame;
        
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
            SystemNavigationManager.GetForCurrentView().BackRequested += MainPage_BackRequested;
        }

        private void News_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rootFrame.Navigate(typeof(DetailsPage), (sender as ListView).SelectedItem as Structure);
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (News.Items.Count==0)
            {
                News.ItemsSource = await Parser.GetTitles();
                Loader.IsActive = false;
            }
        }

        private void MainPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame==null)
            {
                return;
            }

            if (rootFrame.CanGoBack && e.Handled==false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }

        private void HamButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = MySplitView.IsPaneOpen ? false : true;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Loader.IsActive = true;
            News.ItemsSource = await Parser.GetTitles();
            Loader.IsActive = false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (News.Items.Count>0)
            {
                News.SelectedItem = null;
            }
            if (rootFrame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string x = "hello";
            rootFrame.Navigate(typeof(SettingsPage),x);
        }
    }
}
