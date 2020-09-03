using System;

namespace C11_Enum
{
    public enum Level
    {
        Low,
        Normal,
        High

    }


    class Program
    {

        enum Status
        {
           Pending,
           Production,
           Transporting,
           Delivered
        }


        static void Main(string[] args)
        {
            var temperature = 32;
            var _tempLevel = Level.Normal;

            switch(temperature)
            {
                case int t when t < 10:
                    _tempLevel = Level.Low;
                    Console.WriteLine("Temperature is to Low");
                    break;

                case int t when t > 30:
                    _tempLevel = Level.High;
                    Console.WriteLine("Temperature is to High");
                    break;

                default:
                    _tempLevel = Level.Normal;
                    Console.WriteLine("Temperature is Normal");
                    break;

            }

            switch(_tempLevel)
            {
               




            }
            
                
         
        }
    }
}


//Enum kan skrivas i namespace eller i class.