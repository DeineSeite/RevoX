using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevoProjectX.Pages;
using Xamarin.Forms;

namespace RevoProjectX
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {

            var navigationPage = new NavigationPage(new ListPartyPage())
            {
                Icon = "lock.png",
                Title = "Schedule"
            };
            var navigationPage2 = new NavigationPage(new RewardNotification());
            navigationPage2.Icon = "icon.png";
            navigationPage2.Title = "List";

            Children.Add(navigationPage);
            Children.Add(navigationPage2);
           // StartPage();
                
        }

        private async void StartPage()
        {
            await Navigation.PushModalAsync(new StartPage(), true);


        }
    }
}
