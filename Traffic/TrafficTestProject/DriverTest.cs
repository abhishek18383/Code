using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Traffic;


namespace TrafficTestProject
{
    [TestClass]
    public class DriverTest
    {
        [TestMethod]
        public void Drive()
        {
            Driver d = new Driver();
            Car c = new Car(10);


            //All green lights
            List<IPlace> gPlaces = new List<IPlace>();
            gPlaces.Add(new  RoadStretch(50, 150));
            gPlaces.Add(new TrafficLight(false, 2, 3));
            gPlaces.Add(new RoadStretch(30, 120));
            gPlaces.Add(new RoadStretch(30, 90));
            gPlaces.Add(new TrafficLight(true, 2, 1));
            gPlaces.Add(new RoadStretch(50, 150));

            IRoute route = new Route(gPlaces);
            double t = d.Drive(c, route);
            Assert.AreEqual(13, t);

            //All red lights
           
            List<IPlace> rPlaces = new List<IPlace>();
            rPlaces.Add(new RoadStretch(50, 150));
            rPlaces.Add(new TrafficLight(false, 1, 2));
            rPlaces.Add(new RoadStretch(30, 120));
            rPlaces.Add(new RoadStretch(30, 90));
            rPlaces.Add(new TrafficLight(true, 2, 2));
            rPlaces.Add(new RoadStretch(50, 150));

            route = new Route(rPlaces);
            c.Reset();
            t = d.Drive(c, route);
            Assert.AreEqual(37, t);

            //general case
           
            List<IPlace> orderedPlaces = new List<IPlace>();
            orderedPlaces.Add(new RoadStretch(50, 150));
            route = new Route(orderedPlaces);
            c.Reset();
            t = d.Drive(c, route);
            Assert.AreEqual(3, t);

            
            orderedPlaces.Add(new RoadStretch(30, 120));
            orderedPlaces.Add(new TrafficLight(true, 2, 2));
            c.Reset();
            t = d.Drive(c, route);

            Assert.AreEqual(18, t, "result doesn't  match");

            orderedPlaces.Add(new RoadStretch(50, 150));
            orderedPlaces.Add(new TrafficLight(true, 1, 2));
            c.Reset();
            t = d.Drive(c, route);
            Assert.AreEqual(21, t);


            //Thumb rule
            
            //Total distance covered by car should be equal to the length of all stretches in the route
            double totalDistance = c.GetMeterReading();
            Assert.AreEqual(totalDistance,420);

                       
            c.Stop();
        }
    }
}
