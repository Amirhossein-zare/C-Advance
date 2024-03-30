using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Inheir_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent<string> p1 = new Parent<string>("amir");
            Console.WriteLine(p1);

            Child<string, int> ch1 = new Child<string, int>("amir", 22);
            ch1.Print();
            
        }
    }
}
