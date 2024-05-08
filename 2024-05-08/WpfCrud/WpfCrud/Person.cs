using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WpfCrud
{
    public class Person:INotifyPropertyChanged
    {
        public int Id { get; set; }
        private string name;
        public string Name { get { return name; } set { name = value; OnPropertyChanged(); } }
        
        private int age;
        public int Age { get { return age; } set { age = value; OnPropertyChanged(); } }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public Person() 
        { 
            Id = 0;
        }

        public Person(string name, int age)
        {
            Id = 0;
            this.name = name;
            this.age = age;
        }

        public override string? ToString()
        {
            return $"{Name} - {Age} ({Id})";
        }

        private void OnPropertyChanged([CallerMemberName]string Name=null) 
        {
            if (name != null&&PropertyChanged!=null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
        
    }
}
