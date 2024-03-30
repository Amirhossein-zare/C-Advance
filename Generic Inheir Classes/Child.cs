using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Inheir_Classes
{
    internal class Child<T1,T2> : Parent<T1>
    {
        T2 b;
        public Child(T1 a, T2 b) : base(a)
        {
            this.b = b;
        }

        public void Print()
        {
            Console.WriteLine("{0}\tB is : {1}", base.ToString(), b);
        }
    }
}
