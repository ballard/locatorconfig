using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locatorconfig
{
    public class RadioRailCircuit: RailCircuit
    {
        public double frequency { get; set; } = 1000;

        public RadioRailCircuit()
        {
            circuitType = RailCircuitType.Radio;
        }
    }
}
