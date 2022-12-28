using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedditAvaloniaLoginSample.ViewModels
{
    public class LoginWindow2ViewModel : ViewModelBase
    {
        public string Username {
            get => _username;
            set { this.RaiseAndSetIfChanged(ref _username, value); }
        }
        private string _username;

        public string Password {
            get => _password;
            set { this.RaiseAndSetIfChanged(ref _password, value); }
        }
        private string _password;

        public string LoginText {
            get => _loginText;
            set { this.RaiseAndSetIfChanged(ref _loginText, value); }
        }
        private string _loginText = "Log In";


        public void LogIn()
        {
            LoginText = Username;
        }
    }
}
