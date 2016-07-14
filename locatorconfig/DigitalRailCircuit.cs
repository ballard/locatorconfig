using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locatorconfig
{
    public class DigitalRailCircuit : RailCircuit
    {
        public int portNumber { get; set; } = 8;
        public int pinNumber { get; set; } = 7;

        public DigitalRailCircuit()
        {
            circuitType = RailCircuitType.Digital;
        }
    }
}
