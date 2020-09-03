using System;
namespace C10_Struct
{
    // MINNESHANTERING (RAM-HHD)
    // HEAP     = Långsammare   MALOC() FREE()          CLASS
    // STACK    = Snabbare                              STRUCT          stack overflow


    class ClassExample
    {
        public int Nr1 { get; set; }
        public int Nr2 { get; set; }

        public ClassExample(int nr1, int nr2)
        {
            Nr1 = nr1;
            Nr2 = nr2;
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Display Values: {Nr1},{Nr2}");
        }
    }

    struct StructExample
    {
        public int Nr1 { get; set; }
        public int Nr2 { get; set; }

        public StructExample(int nr1, int nr2)
        {
            Nr1 = nr1;
            Nr2 = nr2;
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Display Values: {Nr1},{Nr2}");
        }
    }


    class Program
    {
        private static void ModifyValues(dynamic d)
        {
            d.Nr1 += 1;
            d.Nr2 += 1;

            Console.WriteLine($"Modifying Values: {d.Nr1},{d.Nr2}");
        }





        static void Main(string[] args)
        {
            Console.WriteLine("ClassExample - HEAP (GLOBAL)");
            var classexample = new ClassExample(1, 1);

            classexample.DisplayValues();
            ModifyValues(classexample);
            classexample.DisplayValues();


            Console.WriteLine("\n-----------------------------------------\n");


            Console.WriteLine("StructExample - STACK (LOCAL)");
            var structexample = new StructExample(1, 1);

            structexample.DisplayValues();
            ModifyValues(structexample);
            structexample.DisplayValues();




            Console.ReadKey();
        }
    }
}

/*MINNESHANTERING: (Både HEAP och STACK Kan ligga både i RAM och i HHD, operativsystemet sköter det, 
     microkod bestämmer du själv var)*/
//HEAP   = Långsammare  MALOC()/FREE() = MALOC: Memory alocation, FREE: Free memory, större utrymme på HEAPEN än STACKEN. CLASS
//STACK = Snabbare  
//För att utveckla i c# behöver du inte kunna exakt hur detta funkar, mer känna till. C# fixar detta själv. STRUCT
//Går att göra overflow på stacken och heapen, överbelastar: nyttjat för mkt av minnet.
//stackowerflow.com = söka info om c# felhantering, frågor ex.
//STRUCT används inte för ofta, mer CLASS.
