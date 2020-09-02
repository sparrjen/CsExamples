using System;
using System.Collections.Generic;
using System.Text;

namespace C7_GettersAndSettersV2
{
    class Person
    {

        public string Name { get; private set; }
        public int Age
        {
            get   //detta sätt att sätta get sker hos de som kommer ifrån java
            {
                int _age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                    _age = Age - 1;

                return _age;
            }
        }


        public string City { get; private set; }
        public DateTime DateOfBirth { get; private set; }

       
        public void AskForName()
        {
            Console.Write("Welcome! What's your name? ");
            Name = Console.ReadLine();

            Console.Write($"Nice, {Name}. ");
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

            Console.WriteLine($"Oh cool! We are the same age I am also {Age}");

        }
      
    }
}
