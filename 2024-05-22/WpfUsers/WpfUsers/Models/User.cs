using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfUsers.Models
{
    public class User : INotifyPropertyChanged
    {
        private int id { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
        
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public User()
        {
            Id = 0;
        }

        public User(string name, string email)
        {
            Id = 0;
            Name = name;
            Email = email;
        }

        public override string? ToString()
        {
            return $"{Name} - {Email}";
        }
    }
}
