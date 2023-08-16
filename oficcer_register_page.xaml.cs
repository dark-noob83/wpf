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
    /// Interaction logic for oficcer_register_page.xaml
    /// </summary>
    public partial class oficcer_register_page : Page
    {
        private NpgsqlConnection con = new NpgsqlConnection(
 connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=mahdi1383;Database=ap_project;"); 
            
        public oficcer_register_page()
        {
            InitializeComponent();
        }
        public void clicked_enter(object sender, RoutedEventArgs e)
        {

            if (RegisterEmailInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct email", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterFamilyInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct family name", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterNameInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct name", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterPersonalNumberInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct personal number id", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterUsernameInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct username", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterRepeatPasswordInput.Password.Length == 0)
            {
                MessageBox.Show("pls enter correct reapet password", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterPasswordInput.Password.Length == 0)
            {
                MessageBox.Show("pls enter correct  password", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if(RegisterPasswordInput.Password != RegisterRepeatPasswordInput.Password)
            {
                MessageBox.Show("password and reapet are not same", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                long personalId;
                bool successfullyParsed_PersonalID = long.TryParse(RegisterPersonalNumberInput.Text, out personalId);
                if (successfullyParsed_PersonalID)
                {
                    try
                    {
                        con.Open();
                        var cmd = new NpgsqlCommand();
                        cmd.Connection = con;
                       cmd.CommandText = $"INSERT INTO officer_register(name,fname,personalid,username, password,email) VALUES('{RegisterNameInput.Text}','{RegisterFamilyInput.Text}' , '{personalId}','{RegisterUsernameInput.Text}' , '{RegisterPasswordInput.Password}','{RegisterEmailInput.Text}')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        officcer_panel pg2 = new officcer_panel();
                        var mainWindow = (MainWindow)Application.Current.MainWindow;
                        mainWindow.Content= pg2;
                    }
                    catch (NpgsqlException ex)
                    {
                        con.Close();
                        if (ex.Message.Contains("username") && ex.Message.Contains("unique")) // <-- but this will
                        {
                            MessageBox.Show("your username is valid pls login", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else if (ex.Message.Contains("email") && ex.Message.Contains("unique")) // <-- but this will
                        {
                            MessageBox.Show("your email  is valid pls login", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else if (ex.Message.Contains("personalid") && ex.Message.Contains("unique")) // <-- but this will
                        {
                            MessageBox.Show("your personalD  is valid pls login", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                   }
                else
                {
                    
                    MessageBox.Show("pls enter number for personalID", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Login_clicked(object sender, RoutedEventArgs e)
        {
            var pg6 = new login();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
           mainWindow.Content = pg6;
        }
    }
}
