using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "112233", Name = "Apple Airpods", Description = "Airpods m laddningsetui" });
            output.Add(new Product { Id = "112244", Name = "Glacial Flaska", Description = "Vattenflaska" });

            output.Add(new Licens { Id = "12345", Name = " Microsoft Windows 10", Description = " Licens för Microsoft", NumberOfLicenses = 5 }); 
         
            return output;  
        }

    }
}
