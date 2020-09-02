using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Jennie";    //deklarerad string, standardvärdet är Jennie, text skrivs med citattecken
            int age = 39;             //int representerar ett heltal, ej decimaltal
            var city = "Örebro";      //Var är n dynamisk datatyp, systemet väljer rätt datatyp, kan vara mindre säkert vid tal ex. som råkats skrivas med citattecken som en string, då blir det en string och ger ingen felkod

                                      

            var text1 = "Welcome Jennie. You are 39 years old right? Jennie do you live in Örebro?";
           
            var text2 = "Welcome " + name + ". You are " + age + " years old right? " + name + " do you live in " + city + "?";
            
            var text3 = String.Format("Welcome {0}. You are {1} years old right? {0} do you live in {2}?" , name, age, city);

            var text4 = $"Welcome {name}. You are {age} years old right? {name} do you live in {city}?";       
            //Mest nytt sätt att skriva placeholders med dollartecken och hänvisa till rätt namn


            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);


            //var path = @"C:\Users\jenni\Documents";     //med @ hänvisar du till en sökväg, tar hand om en backslash och gör den "giltig"
            //var path2 = "C:\\Users\\jenni\\Documents";     //Utan @ måste du ha dubbla backslash

        }
    }
}

