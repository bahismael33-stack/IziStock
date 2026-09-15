using IziStock.Interfaces;
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
    /// Interaction logic for ViewItemSoldInfo.xaml
    /// </summary>
    public partial class ViewItemSoldInfo : UserControl, IConfirmDelete<ItemSoldInfo>
    {
        public ViewItemSoldInfo()
        {
            InitializeComponent();
            DataContextChanged += ViewItemSoldInfo_DataContextChanged;
        }

        private void ViewItemSoldInfo_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is ViewItemSoldInfoViewModel)
            {
                (DataContext as ViewItemSoldInfoViewModel).DeleteItemSoldInfoConfirmer = this;
            }
        }

        public void ConfirmDelete(ItemSoldInfo item)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette information de vente ? Cette action est IRRÉVERSIBLE, et VOUS êtes responsable de " +
                "vous assurer que cette action est correcte !", "Supprimer l'information", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes && DataContext is ViewItemSoldInfoViewModel)
            {
                (DataContext as ViewItemSoldInfoViewModel)?.DeleteItemSoldInfo(item);
            }
        }
    }
}
