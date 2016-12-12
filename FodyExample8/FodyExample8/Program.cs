using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace FodyExample8
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer.Seed = new Random(DateTime.Now.Millisecond);
            var testPersons = new Faker<UserData>(locale: "pl").RuleFor(u => u.Firstname, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Address, f => f.Address.StreetAddress())
                .RuleFor(u => u.Login, f => f.Person.UserName)
                .RuleFor(u => u.PhoneNumber, u => u.Phone.PhoneNumber())
                .RuleFor(u => u.BirthDate, f => f.Person.DateOfBirth)
                .RuleFor(u => u.Password, f => f.Random.Replace("#######"));

            var persons = testPersons.Generate(20);
            foreach (var current in persons)
            {
                Console.WriteLine(current);
            }
        }
    }
}
