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
using System.Windows.Shapes;

namespace WpfCrud
{
    /// <summary>
    /// Interaction logic for WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        Person _person;
        PersonContext db;
        public WindowAdd()
        {
            InitializeComponent();
            _person = new Person("", 0);
            spInput.DataContext = _person;

            db = new PersonContext();
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private async void viewClick(object sender, RoutedEventArgs e)
        {
            db.Persons.Add(_person);
            _person.Id = 0;
            await db.SaveChangesAsync();
            MessageBox.Show("Check");
            _person.Name = "";
            _person.Age = 0;
        }
    }
}
