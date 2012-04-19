using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public interface ICar
    {
        double Start();
        double Stop();
        double Run(double distance, double speed);
        double GetMeterReading();
        void Reset();
        bool IsStarted();
    }
}
