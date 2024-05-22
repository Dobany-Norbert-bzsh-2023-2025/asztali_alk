using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using WpfUsers.Context;
using WpfUsers.Models;

namespace WpfUsers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users;
        public UserContext context;

        public MainWindow()
        {
            Users = new ObservableCollection<User>();
            context = new UserContext();
            Init();
            RefreshUsers();
            InitializeComponent();   
            lbUsers.ItemsSource = Users;
            spInput.DataContext = Users;
        }

        private void RefreshUsers()
        {
            Users.Clear();
            if(context.Users.Any())
            {
                foreach(User user in context.Users) { Users.Add((User)user); }
            }
            else
            {
                Users.Add(new User());
            }
        }

        private void Init()
        {
            Users.Add(new User("Name", "email"));
            Users.Add(new User("Name2", "email2"));
            context.SaveChanges();
        }
        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            User user=lbUsers.SelectedItem as User;
            if (user == null) { user = new User(); }
            user.Id = 0;
            context.Users.Add(user);
            context.SaveChanges();
            RefreshUsers();
            lbUsers.SelectedItem = user;
            lbUsers.UpdateLayout();

        }

        private void CloseButton_Click (object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            User user = lbUsers.SelectedItem as User;
            if(user != null) 
            {
                int index = lbUsers.SelectedIndex;

                context.Users.Remove(user);
                context.SaveChanges();
                RefreshUsers();

                lbUsers.SelectedIndex = index < lbUsers.Items.Count - 1? index: lbUsers.Items.Count - 1;
                lbUsers.UpdateLayout();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            User user = lbUsers.SelectedItem as User;
            if (user != null)
            {
                context.Users.Update(user);
                context.SaveChanges();
                RefreshUsers();
                lbUsers.SelectedItem = user;
                lbUsers.UpdateLayout();
            }
        }
    }
}
