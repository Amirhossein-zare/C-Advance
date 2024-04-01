using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Founction_Delegates
{
    internal class Program
    {
        public static Func<int, double, string> fun1 = Sum;
        static void Main(string[] args)
        {
            //for upper method
            Console.WriteLine(fun1.Invoke(11,1.2));
            //anonymous method for func
            Func<int, int, int> mous1 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(mous1.Invoke(22, 1));
        }
        public static string Sum(int a,double b)
        {
            return (a + b).ToString();
        }
    }
}
