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
    /// Interaction logic for ViewItemTypes.xaml
    /// </summary>
    public partial class ViewItemTypes : UserControl
    {
        public ViewItemTypes()
        {
            InitializeComponent();
        }

        private void DeleteItemType_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette catégorie d'article ? Tous les " +
                "articles appartenant à cette catégorie seront déplacés vers la catégorie par défaut.", "Supprimer la catégorie d'article", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                (DataContext as ViewItemTypesViewModel)?.DeleteItem(ItemsGrid.SelectedValue as ItemType);
            }
        }
    }
}
