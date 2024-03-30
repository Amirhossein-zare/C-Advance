using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Inheir_Classes
{
    internal class Parent<T1>
    {
        T1 a;

        public Parent(T1 a)
        {
            this.a = a;
        }
        public override string ToString()
        {
            return string.Format("A is : {0}", a);
        }
    }
}
