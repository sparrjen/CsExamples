using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Abstract_2.Models
{
    abstract class Device
    {
        public string CreateFromConnectionString(string connectionstring)
        {
            return $"initializing connection with\\))"; 
        }
    }
}
