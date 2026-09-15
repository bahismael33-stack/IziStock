using IziStock.Helpers;
using IziStock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IziStock.ViewModels
{
    class ChangePasswordViewModel : BaseViewModel
    {
        private SecureString _password;
        private SecureString _confirmPassword;

        private string _errorMessage;

        public ChangePasswordViewModel(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {

        }

        public SecureString Password
        {
            private get { return _password; }
            set { _password = value; NotifyPropertyChanged(); }
        }

        public SecureString ConfirmPassword
        {
            private get { return _confirmPassword; }
            set { _confirmPassword = value; NotifyPropertyChanged(); }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; NotifyPropertyChanged(); }
        }

        public ICommand ReturnToMainMenu
        {
            get { return new RelayCommand(GoBackToManageUsers); }
        }

        private void GoBackToManageUsers()
        {
            PopViewModel();
        }

        public ICommand SavePassword
        {
            get { return new RelayCommand(SaveUserPassword); }
        }

        private void SaveUserPassword()
        {
            var password = Utilities.SecureStringToString(Password);
            if (password != Utilities.SecureStringToString(ConfirmPassword))
            {
                ErrorMessage = "Le mot de passe et sa confirmation doivent être identiques";
            }
            else if ((Password == null || password == ""))
            {
                ErrorMessage = "Le mot de passe ne peut pas être vide";
            }
            else
            {
                ErrorMessage = "";
                CurrentUser.UpdatePassword(password);
                PopViewModel();
            }
        }
    }
}
