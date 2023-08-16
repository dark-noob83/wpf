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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        private NpgsqlConnection con = new NpgsqlConnection(
 connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=mahdi1383;Database=ap_project;");
        public login()
        {
            InitializeComponent();
        }

        public void clicked_enter(object sender, RoutedEventArgs e)
        {
            if (LoginUsernameInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct username", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (LoginPasswordInput.Password.Length == 0)
            {
                MessageBox.Show("pls enter correct password", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                con.Open();
                string sql1 = "select (username , password) from officer_register";
                var cmd = new NpgsqlCommand(sql1, con);
                bool avail1 = false;
                bool avail2 = false;
                var a = cmd.ExecuteReader();

                while (a.Read())
                {
                    avail1 = true;
                    var values = a.GetFieldValue<object[]>(0);

                    if (values[0].ToString() == LoginUsernameInput.Text && values[1].ToString() == LoginPasswordInput.Password)
                    {
                        officcer_panel pg2 = new officcer_panel();
                        con.Close();
                        var mainWindow = (MainWindow)Application.Current.MainWindow;
                        mainWindow.Content = pg2;
                        return;
                    }
                }
                a.Close();

                string sql2 = "select (username , password) from client_register";
                var cmd2 = new NpgsqlCommand(sql2, con);
                var a2 = cmd2.ExecuteReader();

                while (a2.Read())
                {
                    avail2 = true;
                    var values = a2.GetFieldValue<object[]>(0);

                    if (values[0].ToString() == LoginUsernameInput.Text && values[1].ToString() == LoginPasswordInput.Password)
                    {
                        con.Close();
                        return;
                    }
                }
                a2.Close();


                if (avail1 && avail2)
                {
                    con.Close();
                    MessageBox.Show("your username or password is not correct", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            }
        }
        public void register_clicked_enter(object sender, RoutedEventArgs e)
        {
            oficcer_register_page pg1 = new oficcer_register_page();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.Content = pg1;

        }
    }
}
