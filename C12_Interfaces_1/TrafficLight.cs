using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class TrafficLight : ITrafficLight

    {
        public Guid ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChangeLight()
        {
            throw new NotImplementedException();
        }

        public void WarningLight()
        {
            throw new NotImplementedException();
        }
    }
}
