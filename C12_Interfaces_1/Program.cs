using System;

namespace C12_Interfaces_1
{





    class Program
    {


        
        static void Main(string[] args)
        {
            var cnc = new CNC();
            cnc.Start(); 
        }
    }
}


/*Interface = Ett interface är ett kontrakt, du har bestämt att en viss sak ska innehålla vissa grejer. 
 Det hjälper mig att implementera rätt funktionalitet. 
Ex. Kontraktet säger att en maskin måste ha en start-och en stopp-funktion. 
Interface berättar vilken funktionalitet som måste finnas. 
Ex om du utvecklar m många utvecklare kan ngn lätt glömma en sak som måste vara med*/
