using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfCrud.Migrations;

namespace WpfCrud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person _person;
        PersonContext db;
        ObservableCollection<Person> persons;
        public MainWindow()
        {
            InitializeComponent();
            db =new PersonContext();
            persons = new ObservableCollection<Person>(db.Persons);

            _person = new Person("", 0);
            spInput.DataContext = persons;
            listboxPerson.ItemsSource = persons;

            db = new PersonContext();
        }

        private void RefreshPerson()
        {
            persons.Clear();
            foreach(var item in db.Persons)
            {
                persons.Add(item);
            }
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
            RefreshPerson();
        }

        private async void DeleteClick(object sender, RoutedEventArgs e)
        {
            Person p  = (Person)listboxPerson.SelectedItem;
            db.Remove(p);
            await db.SaveChangesAsync();
            RefreshPerson();
        }
    }
}
