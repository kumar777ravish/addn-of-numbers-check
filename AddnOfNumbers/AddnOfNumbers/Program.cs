using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddnOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            Console.WriteLine("user should print addition of numbers between 1 to 50");
            for (i = 1; i <= 50; i++)
            {
                sum = sum + i;
                Console.WriteLine("sum:-{0}", i);
            }
            Console.ReadLine();
        }
    }
}
