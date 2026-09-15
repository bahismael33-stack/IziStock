using IziStock.Helpers;
using IziStock.Interfaces;
using IziStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IziStock.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        private string _username;
        private SecureString _password;
        private string _error;

        public LoginViewModel(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; NotifyPropertyChanged(); }
        }

        public SecureString Password
        {
            private get { return _password; }
            set { _password = value; NotifyPropertyChanged(); }
        }

        public string Error
        {
            get { return _error; }
            set { _error = value; NotifyPropertyChanged(); }
        }

        public ICommand AttemptLogin
        {
            get { return new RelayCommand(TryLogin); }
        }

        private void TryLogin()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                Error = "Le nom d'utilisateur est requis";
            }
            else if (Password == null)
            {
                Error = "Le mot de passe est requis";
            }
            else
            {
                var user = User.LoadUser(Username, Utilities.SecureStringToString(Password));
                if (user != null)
                {
                    Username = "";
                    Password.Clear();
                    Error = "";
                    PushViewModel(new HomeScreenViewModel(ViewModelChanger) { CurrentUser = user });
                }
                else
                {
                    Error = "Nom d'utilisateur ou mot de passe invalide";
                }
            }
        }
    }
}
