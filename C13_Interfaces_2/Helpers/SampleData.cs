using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2
{
    class SampleData
    {
        public static List<Product> CartSampleItems()
        {
            var output = new List<Product>();

            output.Add(new Product { Id = "112233", Name = "Apple Airpods", Description = "Airpods m laddningsetui" });
            output.Add(new Product { Id = "112244", Name = "Glacial Flaska", Description = "Vattenflaska" });

            output.Add(new Licens { ArticleNumber = "112211" }); 
         
            return output;  
        }

    }
}
