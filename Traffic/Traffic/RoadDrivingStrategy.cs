using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class RoadDrivingStrategy:IDrivingStrategy
    {
        public double Execute(ICar car, IPlace place, double journeyDuration)
        {
            IRoadStretch roadStretch = (IRoadStretch)place;
            return car.Run(roadStretch.GetRoadStretchLength(), roadStretch.GetRoadSpeed());
        }
    }
}
