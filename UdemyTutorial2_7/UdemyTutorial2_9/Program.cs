using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTutorial2_9
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int number;
             var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Failed");
            Console.ReadKey();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));

            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.ReadKey();
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
                point.Move(new Point(100, 200));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Unhandled exception occured.");

            }
        }
    }
}
