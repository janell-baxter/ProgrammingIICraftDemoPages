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

namespace ProgrammingIICraftDemoPages
{
    /// <summary>
    /// Interaction logic for Craft.xaml
    /// </summary>
    public partial class Craft : Page
    {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public Craft()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            SetButtonVisibility();
            Output.Text = mainWindow.game.GetRecipeList();
        }

        private void SetButtonVisibility()
        {
            mainWindow.Craft.Visibility = Visibility.Collapsed;
            mainWindow.Trade.Visibility = Visibility.Visible;
            mainWindow.Inventory.Visibility = Visibility.Visible;
        }
    }
}
