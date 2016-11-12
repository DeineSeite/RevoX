using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevoProjectX.Pages;
using RevoProjectX.ViewModels;
using Xamarin.Forms;

namespace RevoProjectX
{
    public partial class StartPage : ContentPage
    {
        private Animation _anim;


        public StartPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            AnimateView();


        }



        private void SetZeroOpacity(params View[] views)
        {
            for (int i = 0; i < views.Length; i++)
            {
                views[i].Opacity = 0;
            }

        }

        private async void AnimateView()
        {

            await FadeEffect(loginT, 1500);
            await FadeEffect(PasswordT, 2000);
            await FadeEffect(orSignTxt, 2500);
            await FadeEffect(fbBtn, 3000);
            await FadeEffect(nextBtn, 3500);
        }

        private async Task FadeEffect(View view, uint duration, double opacity = 1)
        {
            await Task.Delay(300);
            await view.ScaleTo(1, (uint) App.AnimationSpeed, Easing.SinIn);
        }


        private async void SignUpBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }

    }
}
   
