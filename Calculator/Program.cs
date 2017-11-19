using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            do
            {
                Console.WriteLine("Do you want to calculate some numbers ? (yes or no)");
                input = Console.ReadLine();
                if (input == "yes")
                {
                    Console.WriteLine("Enter first number");
                    double firstNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    double secondNum = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter operation");
                    char operation = char.Parse(Console.ReadLine());
                    double newNum = 0;
                    switch (operation)
                    {
                        case '+':
                            newNum = firstNum + secondNum;
                            newNum += newNum * 0.1;
                            break;
                        case '-':
                            double maxNum = firstNum;
                            double minNum = secondNum;
                            if (maxNum < minNum)
                            {
                                maxNum = secondNum;
                                minNum = firstNum;
                            }
                            maxNum *= maxNum;
                            newNum = maxNum - minNum;
                            break;
                        case '*':
                            newNum = firstNum * Math.Sqrt(secondNum);
                            break;
                        case '/':
                            if (secondNum == 0)
                            {
                                Console.WriteLine("Second number is 0!");
                                continue;
                            }
                            newNum = firstNum / secondNum;
                            break;
                    }
                    Console.WriteLine($"Result is {newNum:f2}");
                }
            } while (!(input == "no"));
        }
    }
}
