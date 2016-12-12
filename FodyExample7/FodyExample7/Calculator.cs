using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mixins;

namespace FodyExample7
{
    [Mixin(typeof(CommonTools))]
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
