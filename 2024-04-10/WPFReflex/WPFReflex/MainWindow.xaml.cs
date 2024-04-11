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

namespace WPFReflex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public double width = 800;
        public double height = 450;

        public int Kattszam = 0;
        public double OsszesIdo = 0;
        public DateTime Most;

        public MainWindow()
        {
            InitializeComponent();
            Canvas.SetLeft(bird, 350);
            Canvas.SetTop(bird, 175);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (Kattszam == 0)
            {
                Most = DateTime.Now;
            }
            else
            {
                OsszesIdo += (DateTime.Now - Most).TotalMilliseconds;
                Most=DateTime.Now;
            }

            Random rnd = new Random();
            Canvas.SetLeft(bird,rnd.Next(0,(int)width-100));
            Canvas.SetTop(bird, rnd.Next(0,(int)height-100));

            Kattszam++;
            if (Kattszam == 11)
            {
                MessageBox.Show(OsszesIdo/10+"msec az átlagod");
                Kattszam = 0;
                OsszesIdo = 0;
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //MessageBox.Show("méret");
            width = e.NewSize.Width;
            height = e.NewSize.Height;
            lblMessage.Width = width;

            double mostLeft = Canvas.GetLeft(bird);
            if (mostLeft>width-130)
            {
                Canvas.SetLeft(bird, width - 130);
            }

            double mostTop = Canvas.GetTop(bird);
            if(mostTop>height-130)
            {
                Canvas.SetTop(bird, height - 130);
            }
        }

        
    }
}
