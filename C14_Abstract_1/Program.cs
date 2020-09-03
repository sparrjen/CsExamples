using C14_Abstract_1.Models;
using System;
using System.Collections.Generic;

namespace C14_Abstract_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var classlist = new List<Person>()
         {
             new Teacher {FirstName = "Jennie", LastName = "Sparr", Role = "Teacher"},
             new Student {FirstName = "Danne", LastName = "Petri"},
             new Student {FirstName = "Lilith", LastName = "Moon"},


         };

            foreach (var person in classlist)
            {
                if (person is Teacher teacher)
                    Console.WriteLine($"{teacher.FirstName} {teacher.LastName} {teacher.Role}");
                else
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
            }





                /*

             Animal animal = new Animal();
             Dog dog = new Dog();                class Dog : Animal      class Cat : Animal
             Cat cat = new Cat();

             =inget behov av att endast skapa ett animal eller endast en person utan att vara "Teacher" eller "Student". 
             Alltså inte: Person person = new Person();
             Vi vill förhindra att det endast går att skapa en person. 
             Sätter du abstract framför class Person förhindras detta,
             Alltså: abstract class Person ist för class Person. 
             Du ärver Person-egenskaperna men kan ej skapa instans av det, alltså inte en person endast.

             */

            }
    }
}
