using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FodyExample7
{
    public interface ICommonTools
    {
        void OutputCurrentDate();
    }
    public class CommonTools : ICommonTools
    {
        public void OutputCurrentDate()
        {
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
    }
}
