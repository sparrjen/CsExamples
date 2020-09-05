using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Interfaces
{
    public interface IShoppingItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        bool OrderCompleted { get; }
        void ShippingItem();
    }
}
