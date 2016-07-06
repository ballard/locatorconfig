using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locatorconfig
{
    public class RadioRailCircuit: RailCircuit
    {
        public double frequency { get; set; }

        public RadioRailCircuit()
        {
            frequency = 0;
            circuitType = RailCircuitType.Radio;
        }
    }
}
