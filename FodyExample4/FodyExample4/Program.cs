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
            exampleClass.DoSomething(null);
            exampleClass.DoSomethingElse("xxx");
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
