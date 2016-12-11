using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodyExample6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() {FirstName = "Hubert", LastName = "Taler", BirthYear = 1975};
            person.BirthYear = 1980;

            person.Freeze();

            try
            {
                person.BirthYear = 1981;
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not modify person ");
                
            }
            
        }
    }

    public interface IFreezable
    {
        void Freeze();
    }

    public class Person : IFreezable
    {
        bool isFrozen;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        public void Freeze()
        {
            isFrozen = true;
        }
    }
}
