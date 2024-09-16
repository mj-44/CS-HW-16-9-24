using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_9_24_pt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            double PI = 3.14159;
            int radius = 0;
            int height = 0;
            double volume = 0.0;
            double area = 0.0;

            Console.WriteLine("Enter the radius");
            radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height");
            height = int.Parse(Console.ReadLine());

            volume = PI * radius * radius * height;
            area = 2 * PI * radius * radius + 2 * PI * radius * height;

            Console.WriteLine("The volume of your cylinder " + volume + " and the surface area is " + area);
            Console.Read();
            

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int total = 0;
           

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            num5 = Convert.ToInt32(Console.ReadLine());

            total = num1 + num2 + num3 + num4 + num5;
            double mean = total / 5.0;
            Console.WriteLine("The average of your set of numbers is " + mean);
            Console.Read();
            */


            int a = 0;
            int b = 0;
            double c = 0;
            int cSquared = 0;

            Console.WriteLine("Enter the length of the a side");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the b side");
            b = int.Parse(Console.ReadLine());

            cSquared = a * a + b * b;
            c = Math.Sqrt(cSquared);

            Console.WriteLine("The length of your hypoteneus is " + Math.Round(c, 2));
            Console.Read();


        }
    }
}
