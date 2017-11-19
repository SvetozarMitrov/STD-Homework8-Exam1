using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int numbersCount = 0;
            while (number != 0)
            {
                if (number >= 1 && number <= 255)
                {
                    if (number % 2 == 0)
                    {
                        sum = sum + number;
                        numbersCount++;
                    }
                    Console.WriteLine("Enter number:");
                    number = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Enter number:");
                    number = int.Parse(Console.ReadLine());
                }
            }
            if (numbersCount == 0)
            {
                Console.WriteLine("There aren't even numbers in this diapason [1,255] !!!");
            }
            else
            {
                Console.WriteLine("Finished !");
                Console.WriteLine("**********");
                Console.WriteLine();
                Console.WriteLine("Average " + sum / numbersCount);
            }
            Console.WriteLine();
        }
    }
}