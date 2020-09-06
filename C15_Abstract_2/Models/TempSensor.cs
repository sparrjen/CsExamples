using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace C14_Abstract_1.Models
{
    class TempSensor : Devices
    {

        public override string CreateFromConnection(string connectionstring)
        {
            var response = base.CreateFromConnection(connectionstring);
            response += " - Device Connected";
            return response; 
        }

        public override string ReceiveMessage()
        {
            var message = JsonConvert.DeserializeObject<dynamic>("{ \"command\": \"get\" }");
            return message.command; 
        }

        public override void SendMessage(string payload)
        {
            Console.WriteLine($"Sending message: {payload}");
        }
    }
}
