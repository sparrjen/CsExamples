using System;

namespace C3_WithAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.Write("Welcome! What's your name? ");
            person.Name = Console.ReadLine();

            Console.Write($"Nice {person.Name}. How old are you? ");
            //age = Convert.ToInt32(Console.ReadLine());
            // alternativt:   age = int.Parse(Concole.ReadLine());   Detta går att använda för alla datatyper, ex double, då double.Parse(Concole.ReadLine());

            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Sorry, your age must be in digits. Try again please!");
                Console.Write("How old are you? ");

                try
                {
                    person.Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wow, you are not the brightest tool in the shed!");
                }

            }
            finally
            {
                Console.WriteLine($"Ok, awesome! I am the same age. I am also {person.Age}.");
            }

            Console.Write($"Hey, your name contain {person.Name.Length} charachters. ");
            Console.Write($"{person.Name} where do you live? ");
            person.City = Console.ReadLine();
            Console.WriteLine($"That's cool. My sister lives in {person.City}.");

        }
    }
}
