using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public App()
        {
            _instance = this;
            InitializeComponent();

            MainPage =new NavigationPage(new StartPage());
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
