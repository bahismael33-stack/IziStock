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
    /// Interaction logic for ManageItems.xaml
    /// </summary>
    public partial class ManageItems : UserControl
    {
        public ManageItems()
        {
            InitializeComponent();
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet article ?", "Supprimer un article de l'inventaire", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                (DataContext as ManageItemsViewModel)?.DeleteItem(ItemsGrid.SelectedValue as InventoryItem);
            }
        }
    }
}
