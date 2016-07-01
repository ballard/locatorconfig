using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locatorconfig
{
    public abstract class RailCircuit: RailCircuity
    {
        protected RailCircuitType circuitType { get;  set; }
        public RailCircuitType getCirciutType()
        {
            return circuitType;
        } 
    }
}
