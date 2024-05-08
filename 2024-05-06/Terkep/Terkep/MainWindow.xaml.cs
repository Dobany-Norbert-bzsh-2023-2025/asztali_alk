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
using System.IO;

namespace Terkep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StreamReader file = new StreamReader("terkephely.csv");
            List<string> list = new List<string>();

            int db = 0;
            file.ReadLine();
            while(!file.EndOfStream)
            {
                double[] x_ek = new double[3137];
                // List<double> x_ek2 = new List<double>();

                double[] y_ok = new double[3137];
                //List<double> y_ok2 = new List<double>();

                string sor = file.ReadLine();
                string[] reszek = sor.Split(';');
                string[] fpszp = reszek[1].Split(new char[] { ':', '.' });
                double x = int.Parse(fpszp[0]);
                x += double.Parse(fpszp[1]) / 60;
                x += double.Parse(fpszp[2]) / 6000;
                x_ek[db] = x;
                //x_ek2.Add(x);

                fpszp = reszek[2 ].Split(new char[] { ':', '.' });
                double y = int.Parse(fpszp[0]);
                y += double.Parse(fpszp[1]) / 60;
                y += double.Parse(fpszp[2]) / 6000;
                y_ok[db]=y;
                //y_ok2.Add(y);

                db++;
            }
            file.Close();

            list.Add(File.ReadAllText("terkephely.csv"));
        }
    }
}
