using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_9_24_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int age = 16;
            // bool glasses = false;
            // string name = "Matthew-Jeremy";
            // Console.WriteLine("Hello my name is " + name + " and I am " + age + "years old and it is " + glasses + " that I wear glasses ");
            // Console.ReadLine();

            // string name;
            // Console.WriteLine("Please enter your name");
            // name = Console.ReadLine();
            // Console.WriteLine("Hello " + name + ". Nice to meet you!");
            // Console.ReadLine();

            // string favfilm = "";
            //  int timesSeen = 0;
            //Console.WriteLine("What is your favourite film: ");
            //favfilm = Console.ReadLine();
            //Console.WriteLine("How many times have you seen it: ");
            //timesSeen = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your favourite film is {0} and you have seen it {1} times", favfilm, timesSeen);
            //Console.Read();

            //string name = "";
            //Console.WriteLine("Whats is your name?");
            //name = Console.ReadLine();
            //Console.WriteLine(name + name + name + name + name);
            //Console.Read();

            string name1 = "";
            string name2 = "";
            string name3 = "";
            string name4 = "";
            string name5 = "";

            Console.WriteLine("Please enter your 1st word:");
            name1 = Console.ReadLine();
            Console.WriteLine("Please enter your 2nd word:");
            name2 = Console.ReadLine();
            Console.WriteLine("Please enter your 3rd word:");
            name3 = Console.ReadLine();
            Console.WriteLine("Please enter your 4th word:");
            name4 = Console.ReadLine();
            Console.WriteLine("Please enter your 5th word:");
            name5 = Console.ReadLine();

            Console.WriteLine(name5 + " " + name4 + " " + name3 + " " + name2 + " " + name1);
            Console.Read();

        }
    }
}
