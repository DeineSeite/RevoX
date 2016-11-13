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
        private Color _tintColor=Color.White;
        public MainPage()
        {
            var s = "logo-revo.png";
            NavigationPage.SetTitleIcon(this, s);

            var clubsNavPage = new NavigationPage(new ListPartyPage())
            {
                Icon = "disco-ball-tab.png",
                Title = "Clubs",
                BackgroundColor = _tintColor
            };
    
            var profileNavPage = new NavigationPage(new RewardNotification())
            {
                Icon = "user-tab.png",
                Title = "Profile",
                BackgroundColor = _tintColor
            };

            var voteNavPage = new NavigationPage(new RewardNotification())
            {
                Icon = "vote-tab.png",
                Title = "Vote",
                BackgroundColor = _tintColor
            };
            var favNavPage = new NavigationPage(new RewardNotification())
            {
                Icon = "fav-tab.png",
                Title = "Favorites",
                BackgroundColor = _tintColor
            };
            var settingsNavPage = new NavigationPage(new RewardNotification())
            {
                Icon = "settings-tab.png",
                Title = "Settings",
                BackgroundColor = _tintColor
            };

            Children.Add(clubsNavPage);
            Children.Add(profileNavPage);
            Children.Add(voteNavPage);
            Children.Add(favNavPage);
            Children.Add(settingsNavPage);
            this.SetValue(TitleProperty, "TestTitle");
         
            // StartPage();

        }

        private async void StartPage()
        {
            await Navigation.PushModalAsync(new StartPage(), true);


        }
    }
}
