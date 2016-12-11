using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FodyExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person {FirstName = "Hubert", LastName = "Taler"};
            person.PropertyChanged += Person_PropertyChanged;

            person.FirstName = "Zenon";
            person.LastName = "Nowak";
            
        }

        private static void Person_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName + " has been changed");
        }
    }

    public class Person : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
