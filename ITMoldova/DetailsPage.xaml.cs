using ITMUtils.NewsParsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text.RegularExpressions;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ITMoldova
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailsPage : Page
    {
        Frame rootFrame = Window.Current.Content as Frame;
        public int indx = 0;
        public DetailsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Structure str = e.Parameter as Structure;
            this.DataContext = str;
            string html = @"<html><head><link rel=""stylesheet"" href=""http://itmoldova.com/wp-content/themes/CarsRace2/lib/css/reset.css"" type=""text/css"" media=""screen, projection"">
<link rel=""stylesheet"" href=""http://itmoldova.com/wp-content/themes/CarsRace2/lib/css/defaults.css"" type=""text/css"" media=""screen, projection"">
<link rel=""stylesheet"" href=""http://itmoldova.com/wp-content/themes/CarsRace2/style.css"" type=""text/css"" media=""screen, projection""></head><body style=""padding:10px"">";
            html += str.EncodedString;
            html += "</body></html";
            YTVideo.NavigateToString(html);
            //Description.Text = Regex.Replace(str.Content, "<.*?>", string.Empty);
            if (rootFrame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }
    }
}
