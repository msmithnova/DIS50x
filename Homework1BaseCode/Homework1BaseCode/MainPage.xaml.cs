using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Globalization; // Provides access to Globalization settings APIs
using Windows.System.UserProfile; // Provides access to user preference setting APIs

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Homework1BaseCode
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();

            //Globalization Preferences

            //<user's top chosen language>
            var chosenLang = loader.GetString("chosen lang");
            var languages = GlobalizationPreferences.Languages;
            chosen_lang.Text += chosenLang + ": " + languages[0] + " \n";
            //<user's set home geopgraphic region>
            var homeRegion = loader.GetString("home region");
            var region = GlobalizationPreferences.HomeGeographicRegion;
            home_region.Text += homeRegion + ": " + region + " \n";
            //<user's calendar setting>
            var calendarSystem = loader.GetString("calendar system");
            var calendars = GlobalizationPreferences.Calendars;
            calendar_setting.Text += calendarSystem + ": " + calendars[0] + " \n";
            //<user's time setting>
            var clockSetting = loader.GetString("clock setting");
            var clocks = GlobalizationPreferences.Clocks;
            clock_setting.Text += clockSetting + ": " + clocks[0] + " \n";
            //<user's setting for first day of the week>
            var weekStart = loader.GetString("week start");
            var firstDay = GlobalizationPreferences.WeekStartsOn;
            week_start.Text += weekStart + ": " + firstDay + " \n";

            //Language Specifics
            var langDetails = loader.GetString("lang details");
            var language = new Language(languages[0]);
            //<user top language display name> <user top language details>
            lang_details.Text = langDetails + ": " + language.DisplayName + ": " + language.Script + " \n";

            //Geo Region Specifics
            var geoDetails = loader.GetString("geo details");
            var reg = new GeographicRegion(region);
            //<geographic region display name> <geographic region details>
            geo_details.Text = geoDetails + ": " + reg.DisplayName + ": " + reg.Code + " \n";
        }
    }
}