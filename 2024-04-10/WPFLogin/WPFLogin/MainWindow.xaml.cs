using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
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

namespace WPFLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Threading.Thread.Sleep(10000);
            string[] args = System.Environment.GetCommandLineArgs();
            /*
            if (args != null && args.Length > 0)
            {
                MessageBox.Show("Argumentumok: " + String.Join(", ", args));
            }
            else
            {
                MessageBox.Show("Nincsenek argumentumok");
            }*/
            if(args.Length==3)
            {
                tbUsername.Text = args[1];
                tbPassword.Text = args[2];
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isf = IsolatedStorageFile.GetMachineStoreForApplication();
            IsolatedStorageFileStream fs = new IsolatedStorageFileStream("technikum.txt", System.IO.FileMode.Append, isf);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(tbUsername.Text+"; "+tbPassword.Text+"; "+DateTime.Now);

            sw.Close();
            fs.Close();
            isf.Close();

            MessageBox.Show("Sikeres bejelentkezés!");
        }


        private void tbUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbUsername.Text.Equals("Username")) tbUsername.Text = "";
        }
        private void tbUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbUsername.Text.Equals("")) tbUsername.Text = "Username";
        }
        private void tbPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbUsername.Text.Equals("Password")) tbUsername.Text = "";
        }
        private void tbPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbUsername.Text.Equals("")) tbUsername.Text = "Password";
        }

        
    }
}
