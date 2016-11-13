using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RevoProjectX.Pages;
using Xamarin.Forms;

namespace RevoProjectX
{
    public partial class App : Application
    {
        public static int AnimationSpeed = 250;
        static App _instance;

        public static App Instance
        {
            get
            {
                return _instance;
            }
        }

        public void SetMainPage(Page page)
        {
            MainPage = page;
        }

        public App()
        {
            _instance = this;
            InitializeComponent();
            //Current.Resources = new ResourceDictionary();
            //Current.Resources.Add("UlycesColor", Color.FromRgb(121, 248, 81));
            //var navigationStyle = new Style(typeof(NavigationPage));
            //var barTextColorSetter = new Setter { Property = NavigationPage.BarTextColorProperty, Value = Color.Green };
            //var barBackgroundColorSetter = new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value = Color.Red };

            //navigationStyle.Setters.Add(barTextColorSetter);
            //navigationStyle.Setters.Add(barBackgroundColorSetter);

            //Current.Resources.Add(navigationStyle);
            MainPage =new StartPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
