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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for officcer_panel.xaml
    /// </summary>
    public partial class officcer_panel : Page
    {
        public officcer_panel()
        {
            InitializeComponent();
        }

        private void Register_Client(object sender, RoutedEventArgs e)
        {
           register_client pg3 = new register_client();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.Content = pg3;
           // a.Content= pg1;
        }

        private void purchase_enterd(object sender, RoutedEventArgs e)
        {
            purchase pg4 = new purchase();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.Content = pg4;
        }
    }
}
