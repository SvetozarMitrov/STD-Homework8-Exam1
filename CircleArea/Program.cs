using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int radius = rnd.Next(33, 187);

            Console.WriteLine("The circle random radius is = {0}", radius);
            double PI = Math.PI;
            double s = PI * Math.Pow(radius, 2);
            Console.WriteLine("The circle area is = {0}", Math.Round(s, 2));
        }
    }
}