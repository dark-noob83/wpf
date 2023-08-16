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
    /// Interaction logic for register_client.xaml
    /// </summary>
    public partial class register_client : Page
    {
        private NpgsqlConnection con = new NpgsqlConnection(
connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=mahdi1383;Database=ap_project;");

        public register_client()
        {
            InitializeComponent();
        }

        

        private void ClientRegisterEnter(object sender, RoutedEventArgs e)
        {
            if (RegisterCEmailInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct email", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterCFamilyInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct family name", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterCNameInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct name", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterCIDInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct personal number id", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (RegisterCPhoneNumberInput.Text.Length == 0)
            {
                MessageBox.Show("pls enter correct phone number", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                long Id;
                bool successfullyParsed_ID = long.TryParse(RegisterCIDInput.Text, out Id);
                if (successfullyParsed_ID)
                {
                    long phoneNumber;
                    bool successfullyParsed_PhoneNumber=long.TryParse(RegisterCPhoneNumberInput.Text, out phoneNumber); 
                    if(successfullyParsed_ID){
                        try
                        {
                            con.Open();
                            Random rand = new Random();
                            string str = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789";
                            
                            int a1 = rand.Next(0, 61);
                            string username = $"{str[a1]}";
                            string sqlusername = $"select (username , password) from client_register where  username = '{username}'; ";
                            
                            int a2 = rand.Next(0, 61);
                            string password = $"{str[a2]}";
                            string sqlpassword = $"select (username , password) from client_register where  password = '{password}'; ";
                            
                            var cmdusername = new NpgsqlCommand(sqlusername, con);
                            var ausername = cmdusername.ExecuteReader();
                            while (ausername.Read())
                            {
                                 a1 = rand.Next(0, 61);
                                 username = $"{str[a1]}";
                                 sqlusername = $"select (username , password) from client_register where  username = '{username}' ";
                                 cmdusername = new NpgsqlCommand(sqlusername, con);
                                 ausername = cmdusername.ExecuteReader();
                            }
                            ausername.Close();
                            
                            var cmdpassword= new NpgsqlCommand(sqlpassword, con);
                            var apassword = cmdpassword.ExecuteReader();
                            while (apassword.Read())
                            {
                                 a2 = rand.Next(0, 61);
                                 password = $"{str[a2]}";
                                 sqlpassword = $"select (username , password) from client_register where  password = '{password}' ";
                                 cmdpassword = new NpgsqlCommand(sqlpassword, con);
                                 apassword = cmdpassword.ExecuteReader();
                            }
                            ausername.Close();


                            var cmd = new NpgsqlCommand();
                            cmd.Connection = con;
                            cmd.CommandText = $"INSERT INTO client_register(name,fname,id,email, phonenumver,password,username) VALUES('{RegisterCNameInput.Text}','{RegisterCFamilyInput.Text}' , '{Id}','{RegisterCEmailInput.Text}' , '{phoneNumber}' , '{password}','{username}')";
                            cmd.ExecuteNonQuery();
                            con.Close();
                            usernameLable.Content = $"username : {username}";
                            passwordLable.Content = $"password :{password}";
                        }
                        catch (NpgsqlException ex)
                        {

                                MessageBox.Show(ex.Message, "error", MessageBoxButton.OK, MessageBoxImage.Error);
                            con.Close();
                            if (ex.Message.Contains("id") && ex.Message.Contains("unique")) // <-- but this will
                            {
                                MessageBox.Show("your id is valid pls login", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            else if (ex.Message.Contains("email") && ex.Message.Contains("unique")) // <-- but this will
                            {
                                MessageBox.Show("your email  is valid pls login", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            else if (ex.Message.Contains("phone") && ex.Message.Contains("unique")) // <-- but this will
                            {
                                MessageBox.Show("your phone Number  is valid pls login", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("pls enter number for phone Number", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                else
                {
                    MessageBox.Show("pls enter number for ID", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Loginclicked(object sender, RoutedEventArgs e)
        {
            var pg6 = new login();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.Content = pg6;
        }
    }
}
