using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class RoadStretch:IRoadStretch
    {
        double _roadSpeed;
        double _roadStretchLength;

        public RoadStretch(double roadSpeed, double roadStretchLength)
        {
            _roadSpeed = roadSpeed;
            _roadStretchLength = roadStretchLength;
        }
        
        public double GetRoadSpeed()
        {
            return _roadSpeed;
        }

        public double GetRoadStretchLength()
        {
            return _roadStretchLength;
        }
    }
}
