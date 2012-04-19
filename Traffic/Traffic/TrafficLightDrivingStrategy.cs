using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class TrafficLightDrivingStrategy : IDrivingStrategy
    {
        public double Execute(ICar car, IPlace place, double journeyDuration)
        {
            ITrafficLight trafficLight = (ITrafficLight)place;
            double timetaken = 0;
            double waitingTime  = trafficLight.GetWaitingTime(journeyDuration);
            if (waitingTime > 0)
            {
                timetaken += car.Stop();
                timetaken += waitingTime;
                timetaken += car.Start();
            }
            return timetaken;
        }
    }
}
