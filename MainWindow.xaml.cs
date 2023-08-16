using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        private NpgsqlConnection con = new NpgsqlConnection(
 connectionString: "Server=localhost;Port=5432;User Id=postgres;Password=mahdi1383;Database=ap_project;");
        public MainWindow()
        {
            InitializeComponent();
            this.Content = new login() ;
        }
        

      
        
    }
}
