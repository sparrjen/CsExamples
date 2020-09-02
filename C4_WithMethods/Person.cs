using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C4_WithMethods
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }


        public void AskForName()
        {
            Console.Write("Welcome! What's your name? ");
            Name = Console.ReadLine();

            Console.Write($"Nice, {Name}. ");
        }
        public void AskForAge()
        {
            Console.Write("How old are you? ");
            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Sorry, your age must be in digits. Try again please!");
                Console.Write("How old are you? ");

                try
                {
                    Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wow, you are not the brightest tool in the shed!");
                }

            }
            finally
            {
                Console.WriteLine($"Ok, awesome! I am the same age. I am also {Age}.");
            }

          

        }
        public void NameContains()
        {
            Console.Write($"Hey, your name contain {Name.Length} charachters. ");
        }
        public void AskForCity()
        {
            Console.Write($"{Name} where do you live? ");
            City = Console.ReadLine();
            Console.WriteLine($"That's cool. My sister lives in {City}.");
        }
    }
}
