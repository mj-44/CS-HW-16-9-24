using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_9_24_pt_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int a = 4;
            int b = 6;
            int c;

            c = a + b;

            Console.WriteLine("A is " + a);
            Console.WriteLine("B is " + b);
            Console.WriteLine("A plus B is " + c);
            Console.ReadLine();
            

            int height = 0;
            int width = 0;
            int length = 0;
            int volume = 0;

            Console.WriteLine("Enter the height:");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            width = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the length:");
            length = int.Parse(Console.ReadLine());

            volume = height * width * length;

            Console.WriteLine("The volume of the cuboid is " +  volume + "centimetres cubed");
            Console.Read();
            

            int num = 0;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("1 times " + num + " is " + num);
            Console.WriteLine("2 times " + num + " is " + num*2);
            Console.WriteLine("3 times " + num + " is " + num*3);
            Console.WriteLine("4 times " + num + " is " + num*4);
            Console.WriteLine("5 times " + num + " is " + num*5);
            Console.Read();
            */

            int children = 0;
            int sweetsEach = 0;
            int ducks = 0;
            int sweetsGiven = 0;

            Console.WriteLine("Enter the children:");
            children = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sweetsEach:");
            sweetsEach = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ducks:");
            ducks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sweetsGiven:");
            sweetsGiven = int.Parse(Console.ReadLine());

            Console.WriteLine("There were " + children + " children each with a bag containing " + sweetsEach + " sweets. They walked past " + ducks + " ducks. Each child gave " + sweetsGiven + " sweets to each of the ducks and ate one themself. They decided to put the rest into a pile. They counted the pile and found it contained " + (children*sweetsEach)-((ducks*sweetsGiven+1)*children) +" sweets.");

        }
    }
}
