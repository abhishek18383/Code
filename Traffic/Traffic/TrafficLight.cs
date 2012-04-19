using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class TrafficLight:ITrafficLight
    {
        bool _isGreenInitially;
        double _greenLightDuration;
        double _redLightDuration;

        public TrafficLight(bool isGreenIntially, double greenLightDuration, double redLightDuration)
        {
            _isGreenInitially = isGreenIntially;
            _greenLightDuration = greenLightDuration;
            _redLightDuration = redLightDuration;
        }

        public double GetWaitingTime(double elapsedTime)
        {
            double remainingTime = elapsedTime % (_greenLightDuration + _redLightDuration);
            
            if (_isGreenInitially)
            {
                if (remainingTime < _greenLightDuration)
                {
                    return 0;
                }
                else
                {
                    return _redLightDuration - (remainingTime - _greenLightDuration);
                }
            }
            else
            {
                if (remainingTime < _redLightDuration)
                {
                    return _redLightDuration - remainingTime;
                }
                else
                {
                    return 0;
                }
            }

        }
    }
}
