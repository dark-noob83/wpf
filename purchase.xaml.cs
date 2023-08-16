using Npgsql;
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
    /// Interaction logic for purchase.xaml
    /// </summary>
    public partial class purchase : Page
    {
        private NpgsqlConnection con = new NpgsqlConnection(
connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=mahdi1383;Database=ap_project;");

        public purchase()
        {

            InitializeComponent();
        }

        private void search(object sender, RoutedEventArgs e)
        {
            if (searchwithid.Text.Length==0)
            {
                MessageBox.Show("pls enter correct email", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                long Id;
                bool successfullyParsed_ID = long.TryParse(searchwithid.Text, out Id);
                if (successfullyParsed_ID)
                {
                    var mainWindow = (MainWindow)Application.Current.MainWindow;
                    con.Open();
                    string sql = $"select (id) from client_register where  id = '{Id}'; ";
                    var cmd = new NpgsqlCommand(sql, con);
                    var a = cmd.ExecuteReader();
                    while (a.Read())
                    {
                        con.Close();
                        purchaseItem pg5 = new purchaseItem();
                        mainWindow.Content= pg5;
                        return;
                    }
                    con.Close();
                    MessageBox.Show("id is not find pls register client ", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                    register_client pg3 = new register_client();
                    mainWindow.Content = pg3;
                }
                else
                {
                    MessageBox.Show("pls enter number for search", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
