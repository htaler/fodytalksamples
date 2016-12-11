using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArxOne.MrAdvice.Advice;

namespace FodyExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass exampleClass = new ExampleClass();
            exampleClass.QuicklyDoSomething();
            exampleClass.SlowlyDoSomething(5);
            Console.ReadKey();
        }
    }

    public class ExampleAdvice : Attribute, IMethodAdvice
    {
        public void Advise(MethodAdviceContext context)
        {
            Console.WriteLine("Before method call " + context.TargetMethod);
            
            if (context.Parameters.Count > 0)
            {
                Console.WriteLine(" parameter " + context.Parameters[0] + " will be modified");
                context.Parameters[0] = 7;
            }
            context.Proceed();
            Console.WriteLine("after method call " + context.TargetMethod);
        }
    }

    public class ExampleClass
    {
        [ExampleAdvice]
        public void SlowlyDoSomething(int a)
        {
            Console.WriteLine("received argument " + a);
            Task.WaitAll(Task.Delay(3000));
        }

        [ExampleAdvice]
        public void QuicklyDoSomething()
        {
            Task.WaitAll((Task.Delay(500)));
        }
    }
}
