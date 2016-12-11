using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FodyExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass exampleClass = new ExampleClass();
            try
            {
                exampleClass.DoSomething(null);
                exampleClass.DoSomethingElse("xxx");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Exception was caught");
            }
        }
    }

    public class ExampleClass
    {
        public void DoSomething(string parameter)
        {
            
        }

        public void DoSomethingElse(string parameter)
        {
            
        }
    }
}
