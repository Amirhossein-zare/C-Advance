using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Cast_Delegate
{
    internal class Program
    {
        public delegate void Math(int a, int b);


        public delegate void MyDeligate(string str);

        static void Main(string[] args)
        {
            //MyDeligate a1 = Print1;

            // a1("amir");
            // Print1("amir");

            //MyDeligate a2 = Print2;

            // a2("arshia");
            // Print2("arshia");


            // multicast deligate
            // MyDeligate a3 = Print1;
            //a3 += Print2;
            //a3 += Print3;
            //a3("arshia");

            Math math = Sum;
            math += Sub;
            math += Mul;
            math += Div;

            math(50,25);
            Console.WriteLine("*******************************************");
            math(50, 32);
            Console.WriteLine("*******************************************");
            math(50, 15);
            Console.WriteLine("*******************************************");
            math(50, 76);
            Console.WriteLine("*******************************************");
            math(50, 98);
            Console.WriteLine("*******************************************");
        }

        //public static void Print1(string name)
        //{
        //    //Console.WriteLine("Name : {0}",name);
        //    Console.WriteLine("Name : {0}",name.Length);
        //}
        //public static void Print2(string family)
        //{
        //    Console.WriteLine("Name : {0}", family);
        //}
        //public static void Print3(string family)
        //{
        //    Console.WriteLine("hello {0}",family);
        //}
        public static void Sum(int num1,int num2)
        {
            Console.WriteLine("Sum is :{0}",num1 + num2);
        }
        public static void Sub(int num1, int num2)
        {
            Console.WriteLine("Sub is :{0}", num1 - num2);
        }
        public static void Mul(int num1, int num2)
        {
            Console.WriteLine("Mul is :{0}", num1* num2);
        }
        public static void Div(int num1, int num2)
        {
            Console.WriteLine("Div is :{0}", num1 / num2);
        }
    }
}
