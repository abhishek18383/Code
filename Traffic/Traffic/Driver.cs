using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class Driver:IDriver
    {
        private IDrivingStrategy _roadDrivingStrategy;
        private IDrivingStrategy _traficLightDrivingStrategy;

        public double Drive(ICar car, IRoute route)
        {
            double journeyDuration = 0;

            foreach (IPlace place in route.GetOrderedPlaces())
            {
                IDrivingStrategy drivingStrategy = SelectDrivingStrategy(place);
                journeyDuration += drivingStrategy.Execute(car, place, journeyDuration);
            }
            return journeyDuration;
        }

        private IDrivingStrategy SelectDrivingStrategy(IPlace place)
        {
            IDrivingStrategy drivingStrategy = null;

            if (place is IRoadStretch)
            {
                if (_roadDrivingStrategy == null)
                {
                    _roadDrivingStrategy = new RoadDrivingStrategy();
                }
                drivingStrategy = _roadDrivingStrategy;
            }
            else if (place is ITrafficLight)
            {
                if (_traficLightDrivingStrategy == null)
                {
                    _traficLightDrivingStrategy = new TrafficLightDrivingStrategy();
                }
                drivingStrategy = _traficLightDrivingStrategy;
            }

            return drivingStrategy;
        }
    }
}
