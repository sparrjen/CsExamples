using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = String.Empty; 
            int age = 0;


            Console.Write("Welcome! What's your name? ");
            name = Console.ReadLine();

            Console.Write($"Nice {name}. How old are you? ");
            //age = Convert.ToInt32(Console.ReadLine());
            // alternativt:   age = int.Parse(Concole.ReadLine());   Detta går att använda för alla datatyper, ex double, då double.Parse(Concole.ReadLine());

            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Sorry, your age must be in digits. Try again please!");
                Console.Write("How old are you? ");

                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wow, you are not the brightest tool in the shed!");
                }
                
            }
            finally
            { 
            Console.WriteLine($"Ok, awesome! I am the same age. I am also {age}.");
            }

            Console.Write($"Hey, your name contain {name.Length} charachters. ");
            Console.Write($"{name} where do you live? ");
            var city = Console.ReadLine();
            Console.WriteLine($"That's cool. My sister lives in {city}."); 


        }
    }
}
