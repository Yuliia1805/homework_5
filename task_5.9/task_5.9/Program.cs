using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 50;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
