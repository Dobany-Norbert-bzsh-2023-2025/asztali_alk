using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes; 

namespace LotteryWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HashSet<int> Bet;
        Context db;
        public MainWindow()
        {
            InitializeComponent();
            Bet = new HashSet<int>();
            DrawCheckBox();

        }

        private void ChBoxTilt()
        {
            foreach(CheckBox item in NumPanel.Children)
            {
                if (item.IsChecked == false)
                { 
                    item.IsEnabled = false; 
                }
            }
        }

        private void DrawCheckBox()
        {
            for (int i = 1; i < 91; i++)
            {
                CheckBox box = new CheckBox();
                box.Content = i.ToString();
                box.Tag = box.Content;
                box.Checked += new RoutedEventHandler(CheckBox_Checked);
                box.Style = (Style)Application.Current.Resources["BetBoxStyle"];
                NumPanel.Children.Add(box);
            }
        }

        private void ChBoxEnabled()
        {
            foreach (CheckBox item in NumPanel.Children)
            {
                item.IsEnabled = true;
            }
        }

       
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox box = sender as CheckBox;
            //MessageBox.Show(box.Content.ToString());
            //MessageBox.Show(((CheckBox)sender).ToString());
            if(box.IsChecked==true)
            {
                Bet.Add((int)box.Tag);
                if(Bet.Count()==5)
                {
                    ChBoxTilt();
                }
            }
            else 
            {
                Bet.Remove((int)box.Tag);
                if (Bet.Count() == 4)
                {
                    ChBoxEnabled();
                }
            }
            tippek.Text = "Tippek:\n" + String.Join(", ", Bet);
        }

        private void sorsBtn_Click(object sender, RoutedEventArgs e)
        {
            HashSet<int> sorsolt = new HashSet<int>();
            Random rnd = new Random();
            do
            {
                sorsolt.Add(rnd.Next(1, 91));
            } while (sorsolt.Count < 5);
            sorsolas.Text = "Kisorsolt számok:\n" + String.Join(", ", sorsolt);

            eredmeny.Text = "Eltalált számok:\n" + string.Join(", ", Bet.Intersect(sorsolt)); 
        }
    }
}
