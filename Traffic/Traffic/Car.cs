using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class Car:ICar
    {
        double _meterReading;
        bool _isStarted;
        double _warmUpTime;

        public Car(double warmUptime)
        {
            Reset();
            _warmUpTime = warmUptime;
        }

        public double Start()
        {
            _isStarted = true;
            return _warmUpTime;
        }

        public double Stop()
        {
            _isStarted = false;
            return 0;
        }

        public double Run(double distance, double speed)
        {
            _meterReading += distance;
            return distance / speed; ;
        }

        public double GetMeterReading()
        {
            return _meterReading;
        }

        public void Reset()
        {
            _meterReading = 0;
        }

        public bool IsStarted()
        {
            return _isStarted;
        }
    }
}
