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
            await Task.Delay(300);
            await logoImg.ScaleTo(0.9, (uint)App.AnimationSpeed, Easing.SinIn);
            await loginT.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);
            await PasswordT.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);
            await signUpBtn.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);
            await orSignTxt.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);
            await fbBtn.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);
            await nextBtn.ScaleTo(1, (uint)App.AnimationSpeed, Easing.SinIn);
         
        }



        private async void SignUpBtn_OnClicked(object sender, EventArgs e)
        {
           App.Instance.SetMainPage(new MainPage());
        }

    }
}
   
