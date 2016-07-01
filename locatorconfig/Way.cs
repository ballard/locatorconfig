using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace locatorconfig
{
    public class Way
    {
        public int direction { get; set; }
        public double delayLR { get; set; }
        public double delayRL { get; set; }
        public double maxSpeedLR { get; set; }
        public double maxSpeedRL { get; set; }
        public double timeCounterWrongL { get; set; }
        public double timeCounterWrongR { get; set; }
        public double timeNotificationTrainNotExitRL { get; set; }
        public double timeNotificationTrainNotExitLR { get; set; }
        public double[] wayCircuitConfigPoints { get; set; }
        public CircuitConfig wayCircuitConfig { get; set; }
        public RailCircuity[] sensors { get; set; }
        public Way()
        {
            wayCircuitConfigPoints = new double[AppConstants.NUM_OF_POINTS];
            for (int i = 0; i < AppConstants.NUM_OF_POINTS; i++)
            {
                wayCircuitConfigPoints[i] = i;
            }            
            wayCircuitConfig = CircuitConfig.FirstOverlay;
            sensors = new RailCircuity[AppConstants.NUM_OF_SENSORS];
            for (int i = 0; i < AppConstants.NUM_OF_SENSORS; i++)
            {   
                sensors[i] = new DigitalRailCircuit();                
            }
        }
        public void changeRailCircuitType(int circuidId, RailCircuitType circuitType)
        {
            if (0 <= circuidId && circuidId < AppConstants.NUM_OF_SENSORS)
            {
                switch (circuitType)
                {
                    case RailCircuitType.Digital:
                        var digitalCircuit = new DigitalRailCircuit();
                        sensors[circuidId] = digitalCircuit;
                        break;
                    case RailCircuitType.Radio:
                        var radioCircuit = new RadioRailCircuit();
                        sensors[circuidId] = radioCircuit;
                        break;
                }
            }
        }
        public void print()
        {
            System.Console.WriteLine(this.direction.ToString());
            System.Console.WriteLine(this.delayLR.ToString());
            System.Console.WriteLine(this.delayRL.ToString());
            System.Console.WriteLine(this.maxSpeedLR.ToString());
            System.Console.WriteLine(this.maxSpeedRL.ToString());
            System.Console.WriteLine(this.timeCounterWrongL.ToString());
            System.Console.WriteLine(this.timeCounterWrongR.ToString());
            System.Console.WriteLine(this.timeNotificationTrainNotExitRL.ToString());
            System.Console.WriteLine(this.timeNotificationTrainNotExitLR.ToString());
            System.Console.WriteLine(this.wayCircuitConfig.ToString());
            for (int i = 0; i < this.wayCircuitConfigPoints.Count(); i++)
            {
                System.Console.WriteLine("Point {0}: {1}", i, this.wayCircuitConfigPoints[i]);
            }
            for (int i = 0; i < AppConstants.NUM_OF_SENSORS; i++)
            {
                switch(this.sensors[i].getCirciutType())
                {
                    case RailCircuitType.Digital:
                        var digitalSensor = (DigitalRailCircuit)this.sensors[i];
                        System.Console.WriteLine(digitalSensor.pinNumber.ToString());
                        System.Console.WriteLine(digitalSensor.portNumber.ToString());
                        break;
                    case RailCircuitType.Radio:
                        var radioSensor = (RadioRailCircuit)this.sensors[i];
                        System.Console.WriteLine(radioSensor.frequency.ToString());
                        break;
                }
            }
        }
    }
}
