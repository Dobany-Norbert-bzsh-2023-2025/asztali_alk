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

namespace SnakeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image[,] palya = new Image[20, 20];
        int[,] palyaTomb = new int[20,20];
        public List<Position> Snake = new List<Position>();
        public MainWindow()
        {
            InitializeComponent();
            Init();
            
        }

        private void SnakeInit()
        {
            for (int i = 0; i < 10;i++)
            {
                Snake.Add(new Position(9, i));
                
            }
            DrawSnake();
        }

        private void DrawSnake()
        {
            foreach (var item in Snake)
            {
                palyaTomb[item.X, item.Y] = 1;
            }
        }

        private void stepDown()
        {

        }

        private void Init()
        {
            for(int i = 0; i<20;i++)
            {
                for (int j = 0; j < 20;j++) 
                {
                    Image img = new Image();
                    img.Width = 30;
                    img.Height = 30;
                    Canvas.SetLeft(img, i * 30);
                    Canvas.SetTop(img, j * 30);
                    img.Source = new BitmapImage(new Uri("Images/TileGreen.png", UriKind.Relative));
                    palya[i, j] = img;
                    canvas.Children.Add(palya[i, j]);

                }
                
                
            }
            Position fruit = new Position();
            palyaTomb[fruit.X, fruit.Y] = 2;
            
        }
        private void Draw()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (palyaTomb[i,j]==0)
                    {
                        palya[i,j].Source= new BitmapImage(new Uri("Images/TileGreen.png", UriKind.Relative));
                    }
                    if (palyaTomb[i, j] == 1)
                    {
                        palya[i, j].Source = new BitmapImage(new Uri("Images/TileBlue.png", UriKind.Relative));
                    }
                    if (palyaTomb[i, j] == 2    )
                    {
                        palya[i, j].Source = new BitmapImage(new Uri("Images/TilePurple.png", UriKind.Relative));
                    }
                }
            }
        }
        private void canvas_Loaded(object sender, RoutedEventArgs e)
        {
            Draw();
            SnakeInit();
        }
    }
}
