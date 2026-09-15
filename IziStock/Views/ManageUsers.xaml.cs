using IziStock.Models;
using IziStock.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IziStock.Views
{
    /// <summary>
    /// Interaction logic for ManageUsers.xaml
    /// </summary>
    public partial class ManageUsers : UserControl
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Supprimer l'utilisateur", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                (DataContext as ManageUsersViewModel)?.DeleteUser(UsersGrid.SelectedValue as User);
            }
        }
    }
}
