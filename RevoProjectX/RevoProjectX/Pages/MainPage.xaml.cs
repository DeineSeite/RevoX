using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RevoProjectX
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {

            var navigationPage = new NavigationPage(new MainPage());
            navigationPage.Icon = "icon.png";
            navigationPage.Title = "Schedule";

            Children.Add(new StartPage());
            Children.Add(navigationPage);
           // StartPage();
                
        }

        private async void StartPage()
        {
            await Navigation.PushModalAsync(new StartPage(), true);


        }
    }
}
