using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locatorconfig
{
    public class DigitalRailCircuit : RailCircuit
    {
        public int portNumber { get; set; }
        public int pinNumber { get; set; }

        public DigitalRailCircuit()
        {
            portNumber = 0;
            pinNumber = 0;
            circuitType = RailCircuitType.Digital;
        }
    }
}
