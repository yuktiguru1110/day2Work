using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Write Again");
                a = Convert.ToInt32(Console.ReadLine());
            }
            if (b == 0)
            {
                Console.WriteLine("Write Again");
                b = Convert.ToInt32(Console.ReadLine());
            }
            int sum = a + b;
            int product = a * b;
            Console.WriteLine("sum : {0}, product : {1}", sum, product);
        }
    }
}
