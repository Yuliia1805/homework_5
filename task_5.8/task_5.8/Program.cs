using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter summ of money, and amount of years and we'll tell you summ of your deposit");

            double money;
            int years;
            double deposit = 0;

            Console.WriteLine("Enter your summ of money: ");
            money = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount of years: ");
            years = int.Parse(Console.ReadLine());

            for (int i = 0; i <= years; i++)
            {
                deposit = money + (20 * money) / 100;
                money += (20 * money) / 100;
            }
            Console.WriteLine("Your deposit is: " + deposit);

            Console.ReadLine();
        }
    }
}
