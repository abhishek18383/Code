﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public interface ITrafficLight:IPlace
    {
        double GetWaitingTime(double elapsedTime);
    }
}
