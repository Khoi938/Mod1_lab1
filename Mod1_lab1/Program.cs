using System;

namespace Mod1_lab1
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[3];
            stringArray[0] = "hello";
            stringArray[1] = "how";
            stringArray[2] = "you?";
            foreach (string i in stringArray)
            {
                Console.WriteLine(i);
            };
            // print out total of odd
            int total = 0;
            for (int x = 0; x<10; x++)
            {
                if (x % 2 == 0)
                {
                    total += x;
                    Console.WriteLine(total);
                }
            };
            Console.WriteLine(total);
   

            //bool result = true;
            //if (result)
            //    Console.WriteLine("Result is true");
            //    Console.WriteLine("Will this print as part of the if statement?");
            //Console.WriteLine("Does this print at all?");
            //string first;
            //string last;
            //string bDay;
            //string address;
            //string city;
            //string state;

            //Console.WriteLine("Hello! What is your name?");
            //first = Console.ReadLine();
            //Console.WriteLine($"Hello {first}");
        }
        static void ain(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string street = "";
            int age = 0;
            string city = "";
            string country = "";
            DateTime birthDate;

            firstName = "Khoi";
            lastName = "le";
            age = 33;
            city = "Tampa";
            country = "USA";
            street = "4721 Town N Country Blvd";
            birthDate = new DateTime(1986, 4, 6);
            var x = birthDate.ToShortDateString();
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.WriteLine("I'm {0} year old.",age);
            Console.WriteLine("I live on, " + street + ", " + city + ", " + country);

            Console.WriteLine($"I was born on {x}");
            Console.WriteLine("Hello World!");
           
        }
    }
}
