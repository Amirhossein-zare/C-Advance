using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Method_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 11, 21, 60, 45, 65, 90, 83, 1, 5, 68, 49, 293, 12, 43, 59, 23 };

            List<string> names = new List<string>()
            {
                "amir","arshia","hanie","faeze","elham","khalil","ali","hamid","atefe","sara","samane"
            };

            var list1 = ages;

            var list1 = ages.Where(t => t > 40);

            var list1 = ages.Where(t => (t %2) == 0).OrderBy(t => t).Skip(2);

            var list1 = ages.Where(t => t % 2 == 0).OrderBy(t => t).Skip(2).Take(3);

            var list1 = ages.Take(2);

            var list1 = ages.Skip(3).Take(2);


            
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
