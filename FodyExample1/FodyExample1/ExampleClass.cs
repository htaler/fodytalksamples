using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FodyExample1
{
    public class ExampleClass
    {
        public void SlowlyDoSomething()
        {
            Task.WaitAll(Task.Delay(3000));
        }

        public void QuicklyDoSomething()
        {
            Task.WaitAll((Task.Delay(500)));
        }
    }

    //public static class MethodTimeLogger
    //{
    //    public static void Log(MethodBase methodBase, long miliseconds)
    //    {
    //        Console.WriteLine("Metoda " + methodBase + " wykonywala sie " + miliseconds);
    //        Console.ReadKey();
    //    }
    //}
}
