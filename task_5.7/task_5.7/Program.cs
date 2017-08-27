using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number and we`ll calculate the factorial of your number");

            int n;
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            int multiple = 1;

            for (int i = 1; i < n; i++)
            {
                multiple = multiple * i;
            }
            Console.WriteLine("The result is: " + multiple);

            Console.ReadLine();
        }
    }
}
