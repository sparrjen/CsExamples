using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeCalculation
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set;  }


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
        public void AskForDateOfBirth()
        {
            Console.Write("When were you born? ");

            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }  
            catch
            {
                Console.Write("Sorry, I mean when, like 1981-07-18. So when were you born? ");
                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No. You really don't get it....");
                }
            }

            Console.WriteLine($"Oh cool! We are the same age I am also {CalculateAge()}!");

        }
        public int CalculateAge()
        {
            Age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                Age = Age - 1;

            return Age;
        }
    }
}
