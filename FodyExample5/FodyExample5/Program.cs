using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodyExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() {FirstName = "Hubert", LastName = "Taler", BirthYear = 1975};
            person.Items.Add("Book");
            person.Items.Add("Car");
            person.Items.Add("Phone");
            //Console.ReadKey();
        }
    }

    public class Person
    {
        public Person()
        {
            Items = new List<string>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public List<string> Items { get; set; } 
    }
}
