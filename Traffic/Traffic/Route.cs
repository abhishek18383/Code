using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class Route:IRoute
    {
        List<IPlace> _orderedPlaces;

        public Route(List<IPlace> orderedPlaces)
        {
            _orderedPlaces = orderedPlaces;
        }

        public IEnumerable<IPlace> GetOrderedPlaces()
        {
            return _orderedPlaces;
        }
    }
}
