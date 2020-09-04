using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Models
{
    class Licens
    {
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public int NumberOfLicenses { get; set; } = 1;

        public void ShippingItem()
        {
            Console.WriteLine($"Licensen för { Name } har skickats till e-postadressen.");

        }


    }
}
