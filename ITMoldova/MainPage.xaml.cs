using System;
using System.Collections.Generic;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using ITMUtils.NewsParsing;
using Windows.UI.Popups;
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
            SearchBox.LostFocus += SearchBox_LostFocus;
            SystemNavigationManager.GetForCurrentView().BackRequested += MainPage_BackRequested;
        }

        private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Length==0)
            {
                SearchBox.Visibility = Visibility.Collapsed;
                SearchBtn.Visibility = Visibility.Collapsed;
                LogoText.Visibility = Visibility.Visible;
            }
        }

        private void News_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rootFrame.Navigate(typeof(DetailsPage), (sender as ListView).SelectedItem as NewsStruct);
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<NewsStruct> items = await Parser.GetFeedData();
            if (News.Items.Count == 0)
            {
                News.ItemsSource = items;
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
            News.ItemsSource = await Parser.GetFeedData();
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
            rootFrame.Navigate(typeof(SettingsPage));
        }

        private void SearchClicked(object sender, RoutedEventArgs e)
        {
            SearchBox.Visibility = Visibility.Visible;
            SearchBtn.Visibility = Visibility.Visible;
            LogoText.Visibility = Visibility.Collapsed;
            SearchBox.Focus(FocusState.Programmatic);
        }

        private async void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dlg = new MessageDialog("blea");
            await dlg.ShowAsync();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
