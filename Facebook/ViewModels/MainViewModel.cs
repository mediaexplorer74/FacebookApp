// MainViewModel

using System;

namespace Messenger.UWP.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private const string MessengerLoginURL = "https://m.facebook.com";
        private const string MessengerPasswordURL = "m.facebook.com";

        private Action<Uri> navigate;

        public MainViewModel(Action<Uri> navigate)
        {
            this.navigate = navigate;
            this.navigate(new Uri(MessengerLoginURL));
        }

        #region Properties

        private NavigationState state = NavigationState.Loading;
        public NavigationState State
        {
            get { return state; }
            set
            {
                if (SetProperty(ref state, value))
                {
                    OnPropertyChanged("IsLoading");
                    OnPropertyChanged("HasFailed");
                    OnPropertyChanged("ShowIcon");
                }
            }
        }

        public bool IsLoading => State == NavigationState.Loading;

        public bool HasFailed => State == NavigationState.Failed;

        public bool ShowIcon => State != NavigationState.Succeeded;

        #endregion

        public void Reload(Uri currentUrl)
        {
            // If navigation fails after submitting the user credentials, we have to retry from the login page.
            if (currentUrl.OriginalString.Contains(MessengerPasswordURL))
                currentUrl = new Uri(MessengerLoginURL);

            navigate(currentUrl);
        }
    }

    public enum NavigationState
    {
        Loading,
        Failed,
        Succeeded
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                     