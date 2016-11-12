using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevoProjectX.Helpers;
using RevoProjectX.ViewModels;
using Xamarin.Forms;
using RevoProjectX.Renderers;

namespace RevoProjectX.Pages
{
    public class BaseContentPage<T> : MainBaseContentPage where T : BaseViewModel, new()
    {
        protected T _viewModel;

        public T ViewModel
        {
            get
            {
                return _viewModel ?? (_viewModel = new T());
            }
        }

        ~BaseContentPage()
        {
            _viewModel = null;
        }

        public BaseContentPage()
        {
            BindingContext = ViewModel;
        }
    }

    public class MainBaseContentPage : ContentPage
    {
        bool _hasSubscribed;

        public Color BarTextColor
        {
            get;
            set;
        }

        public Color BarBackgroundColor
        {
            get;
            set;
        }

        public MainBaseContentPage()
        {
            //Debug.WriteLine("Constructor called for {0} {1}".Fmt(GetType().Name, GetHashCode()));

            BarBackgroundColor = (Color)Application.Current.Resources["grayPrimary"];
            BarTextColor = Color.White;
            BackgroundColor = Color.White;

        //    SubscribeToAuthentication();
         //   SubscribeToIncomingPayload();
            _hasSubscribed = true;

           // SubscribeToMessages();
        }

        ~MainBaseContentPage()
        {
            //Debug.WriteLine("Destructor called for {0} {1}".Fmt(GetType().Name, GetHashCode()));
        }

    

        //void SubscribeToAuthentication()
        //{
        //    var weakSelf = new WeakReference(this);
        //    Action<AuthenticationViewModel> action = (vm) =>
        //    {
        //        var self = (MainBaseContentPage)weakSelf.Target;
        //        self.OnAuthenticated();
        //    };
        //    MessagingCenter.Subscribe(this, Messages.UserAuthenticated, action);
        //}

        public bool HasInitialized
        {
            get;
            private set;
        }

        protected virtual void OnLoaded()
        {
            TrackPage(new Dictionary<string, string>());
        }

        //internal virtual void OnUserAuthenticated()
        //{
        //    App.Instance.ProcessPendingPayload();
        //}

        protected virtual void Initialize()
        {
        }

        //protected virtual void SubscribeToMessages()
        //{
        //    SubscribeToIncomingPayload();
        //}

        //protected virtual void UnsubscribeFromMessages()
        //{
        //    MessagingCenter.Unsubscribe<AuthenticationViewModel>(this, Messages.IncomingPayloadReceived);
        //}

        protected override void OnAppearing()
        {
            //if (!_hasSubscribed)
            //{
            //    SubscribeToAuthentication();
            //    SubscribeToIncomingPayload();
            //    _hasSubscribed = true;
            //}

            //var nav = Parent as NavigationPage;
            //if (nav != null)
            //{
            //    nav.BarBackgroundColor = BarBackgroundColor;
            //    nav.BarTextColor = BarTextColor;
            //}

            //if (!HasInitialized)
            //{
            //    HasInitialized = true;
            //    OnLoaded();
            //}

            //App.Instance.ProcessPendingPayload();
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            //MessagingCenter.Unsubscribe<AuthenticationViewModel>(this, Messages.UserAuthenticated);
            //_hasSubscribed = false;

            base.OnDisappearing();
          //  EvaluateNavigationStack();
        }

        //async Task EvaluateNavigationStack()
        //{
        //    await Task.Delay(100);
        //    if (Navigation.NavigationStack.Count == 0)
        //    {
        //        UnsubscribeFromMessages();
        //    }
        //}

        //void OnAuthenticated()
        //{
        //    if (App.Instance.CurrentAthlete != null)
        //    {
        //        OnUserAuthenticated();
        //    }
        //}

        /// <summary>
        /// Wraps the ContentPage within a NavigationPage
        /// </summary>
        /// <returns>The navigation page.</returns>
        public NavigationPage WithinNavigationPage()
        {
            var nav = new ThemedNavigationPage(this);
            ApplyTheme(nav);
            return nav;
        }

        //protected void SetTheme(League l)
        //{
        //    if (l == null || l.Theme == null)
        //        return;

        //    BarBackgroundColor = l.Theme.Light;
        //    BarTextColor = l.Theme.Dark;
        //}

        public void ApplyTheme(NavigationPage nav)
        {
            nav.BarBackgroundColor = BarBackgroundColor;
            nav.BarTextColor = BarTextColor;
        }

        public void AddDoneButton(string text = "Done", ContentPage page = null)
        {
            var btnDone = new ToolbarItem
            {
                Text = text,
            };

            btnDone.Clicked += async (sender, e) =>
            await Navigation.PopModalAsync();

            page = page ?? this;
            page.ToolbarItems.Add(btnDone);
        }

        protected virtual void TrackPage(Dictionary<string, string> metadata)
        {
            var identifier = GetType().Name;
            //InsightsManager.Track(identifier, metadata);
        }

        //async protected virtual void OnIncomingPayload(NotificationPayload payload)
        //{
        //    //string challengeId;

        //    //if(payload.Payload.TryGetValue("challengeId", out challengeId))
        //    //{
        //    //	try
        //    //	{
        //    //		var vm = new BaseViewModel();
        //    //		var task = AzureService.Instance.GetChallengeById(challengeId);
        //    //		await vm.RunSafe(task);

        //    //		if(task.IsCompleted && !task.IsFaulted && task.Result != null)
        //    //		{
        //    //			var details = new ChallengeDetailsPage(task.Result);
        //    //			details.AddDoneButton();

        //    //			await App.Instance.MainPage.Navigation.PushModalAsync(details.WithinNavigationPage());
        //    //		}
        //    //	}
        //    //	catch(Exception e)
        //    //	{
        //    //		//InsightsManager.Report(e);
        //    //		Console.WriteLine(e);
        //    //	}
        //    //}
        }
    }
