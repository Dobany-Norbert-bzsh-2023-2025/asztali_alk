using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Rajzolo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int elozoX=0;
        int elozoY=0;
        bool kellRajzolni=false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void VeletlenNegyszog(object sender, RoutedEventArgs e)
        {
            Random vszg= new Random();
            /*Line oldal = new Line();
            //első oldal
            oldal.X1 = vszg.Next(0, (int)Rajzlap.Width);
            oldal.X2 = vszg.Next(0, (int)Rajzlap.Width);
            int kezdoX = (int)oldal.X1;
            oldal.Y1 = vszg.Next(0, (int)Rajzlap.Height);
            int kezdoY = (int)oldal.X1;
            oldal.Y2 = vszg.Next(0, (int)Rajzlap.Height);           
            oldal.Stroke = System.Windows.Media.Brushes.Black;
            oldal.StrokeThickness = 1;
            Rajzlap.Children.Add(oldal);
            //második oldal az első végétől véletlenig
            Line oldal2 = new Line();
            oldal2.X1 = oldal.X2;
            oldal2.Y1 = oldal.Y2;
            oldal2.X2 = vszg.Next(0, (int)Rajzlap.Width);
            oldal2.Y2 = vszg.Next(0, (int)Rajzlap.Height);
            oldal2.Stroke = System.Windows.Media.Brushes.Black;
            oldal2.StrokeThickness = 1;
            Rajzlap.Children.Add(oldal2);
            //harmadik oldal az előző véletlen végétől véletlenig
            Line oldal3 = new Line();
            oldal3.X1 = oldal2.X2;
            oldal3.Y1 = oldal2.Y2;
            oldal3.X2 = vszg.Next(0, (int)Rajzlap.Width);
            oldal3.Y2 = vszg.Next(0, (int)Rajzlap.Height);
            oldal3.Stroke = System.Windows.Media.Brushes.Black;
            oldal3.StrokeThickness = 1;
            Rajzlap.Children.Add(oldal3);
            //negyedik oldal az előző véletlen végétől az első kezdőig
            Line oldal4 = new Line();
            oldal4.X1 = oldal3.X2;
            oldal4.Y1 = oldal3.Y2;
            oldal4.X2 = kezdoX;
            oldal4.Y2 = kezdoY;
            oldal4.Stroke = System.Windows.Media.Brushes.Black;
            oldal4.StrokeThickness = 1;
            Rajzlap.Children.Add(oldal4);*/
            //Alkalmas adatszerkezettel és ciklussal egyszerűbbé volna tehető
            int[] xek = new int[4];
            int[] yok=new int[4];
            SolidColorBrush[] szinek = new SolidColorBrush[]
            {
                System.Windows.Media.Brushes.AliceBlue,
                System.Windows.Media.Brushes.Aquamarine,
                System.Windows.Media.Brushes.Azure,
                System.Windows.Media.Brushes.Beige,
                System.Windows.Media.Brushes.Black,
                System.Windows.Media.Brushes.Blue,
                System.Windows.Media.Brushes.Brown,
                System.Windows.Media.Brushes.Cyan,
                System.Windows.Media.Brushes.ForestGreen,
                System.Windows.Media.Brushes.Red
            };
            for(int i=0;i<4; i++)
            {
                xek[i]= vszg.Next(10, (int)Rajzlap.Width-10);
                yok[i]= vszg.Next(10, (int)Rajzlap.Height-10);
            }
            Line oldal = new Line();
            SolidColorBrush szin = szinek[vszg.Next(0, szinek.Length - 1)];
            for (int i = 0; i < 3; i++)
            {                  
                oldal.X1 = xek[i];
                oldal.Y1 = yok[i];
                oldal.X2 = xek[i+1];
                oldal.Y2 = yok[i+1];
                //oldal.Stroke = System.Windows.Media.Brushes.Black;
                oldal.Stroke = szin;
                oldal.StrokeThickness = 3;
                Rajzlap.Children.Add(oldal);
                oldal = new Line();
            }
            oldal.X1 = xek[3];
            oldal.Y1 = yok[3];
            oldal.X2 = xek[0];
            oldal.Y2 = yok[0];
            oldal.Stroke = szin;
            oldal.StrokeThickness = 3;
            Rajzlap.Children.Add(oldal);
            //Mivel a véletlen csúcsok összekötése a keletkezésük sorrendjében nem mindig megfelelő, ezért valamilyen más módszer gondoskodhatna a konkáv vagy konvex négyszögek létrejöttéről
        }
        void Proba(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("" + sender + ": " + e.ButtonState);
        }

        private void Indit(object sender, MouseButtonEventArgs e)
        {
            kellRajzolni = true;
            elozoX = (int) e.GetPosition(this).X;
            elozoY = (int)e.GetPosition(this).Y;
        }

        private void Leallit(object sender, MouseButtonEventArgs e)
        {
            kellRajzolni = false;
        }

        private void Rajzolas(object sender, MouseEventArgs e)
        {
            if (kellRajzolni)
            {
                Line vonal = new Line();
                vonal.X1 = elozoX;
                vonal.Y1 = elozoY;
                vonal.X2 = (int)e.GetPosition(Rajzlap).X; 
                vonal.Y2 = (int)e.GetPosition(Rajzlap).Y;
                vonal.Stroke = Brushes.Yellow;
                vonal.StrokeThickness = 3;
                Rajzlap.Children.Add(vonal);
                elozoX = (int)e.GetPosition(Rajzlap).X;
                elozoY = (int)e.GetPosition(Rajzlap).Y;
            }
        }

        private void Torles(object sender, RoutedEventArgs e)
        {
            Rajzlap.Children.Clear();
        }

        private void VeletlenCsucsok(object sender, RoutedEventArgs e)
        {
            /*
            RectangleGeometry pont = new RectangleGeometry();
            pont.Rect = new Rect(30, 40, 5, 5); //A vízszintes 30, függőleges 40 koordinátától 5x5-ös négyzet létrehozása
            Path vonalak=new Path();
            vonalak.Fill = Brushes.White;
            vonalak.Stroke = Brushes.White;
            vonalak.StrokeThickness = 1;
            vonalak.Data = pont;
            Rajzlap.Children.Add(vonalak);*/
            Random vszg = new Random();
            for(int db = 1; db <= 4; db++)
            {
                RectangleGeometry pont = new RectangleGeometry();
                int x = vszg.Next(5, (int)(Rajzlap.Width - 5));
                int y = vszg.Next(5, (int)(Rajzlap.Height - 5));
                pont.Rect = new Rect(x, y, 5, 5);
                Path vonalak = new Path();
                vonalak.Fill = Brushes.White;
                vonalak.Stroke = Brushes.White;
                vonalak.StrokeThickness = 1;
                vonalak.Data = pont;
                Rajzlap.Children.Add(vonalak);
            }
        }

        private void Grafikon(object sender,RoutedEventArgs e)
        {
            int kozepX = (int)(Rajzlap.Width / 2);
            int kozepY = (int)(Rajzlap.Height / 2);
            Line tengely=new Line();
            tengely.X1 = kozepX;
            tengely.Y1 = 5;
            tengely.X2 = kozepX;
            tengely.Y2 = (int)(Rajzlap.Height - 5);
            tengely.Stroke = Brushes.Green;
            tengely.StrokeThickness = 3;
            Rajzlap.Children.Add(tengely);
            tengely = new Line();
            tengely.X1 = kozepX;
            tengely.Y1 = 5;
            tengely.X2 = kozepX-5 ;
            tengely.Y2 = 20;
            tengely.Stroke = Brushes.Green;
            tengely.StrokeThickness = 3;
            Rajzlap.Children.Add(tengely);
        }
        //Szabadkézi rajzoláshoz:
        //1. Rajzlap-hoz rendelt MouseDown, ami indítja a lenyomás pozíciójától a rajzolást
        //2. Rajzlap-hoz rendelt MouseUp, ami leállítja a felengedés pozíciójától a rajzolást
        //3. Rajzlap-hoz kell egy MouseMove, ami az előző pozíciót hivatott összekötni az aktuálissal, amennyiben az egérgom le van nyomva
    }
}
