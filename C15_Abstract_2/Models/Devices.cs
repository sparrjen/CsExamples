using System;
using System.Collections.Generic;
using System.Text;

namespace C14_Abstract_1.Models
{
    abstract class Devices
    {
        public virtual string CreateFromConnection(string connectionstring)
        {
            return $"initializing connection with \"{connectionstring}\"";

        }

        public abstract string ReceiveMessage();
        public abstract void SendMessage(string payload); 

    

    }
}
