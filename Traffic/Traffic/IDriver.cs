using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public interface IDriver
    {
        double Drive(ICar car, IRoute route);
    }
}
