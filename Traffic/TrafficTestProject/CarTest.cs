using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Traffic;
namespace TrafficTestProject
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Run()
        {
            Car c = new Car(10);
            double t = c.Run(10,5);
            Assert.AreEqual(2,t);
        }
        [TestMethod]
        public void Start()
        {
            Car c = new Car(10);
            double t = c.Start();
            Assert.AreEqual(10,t);
        }
        [TestMethod]
        public void Stop()
        {
            Car c = new Car(10);
            double t = c.Stop();
            Assert.AreEqual(0, t);

        }
        [TestMethod]
        public void GetMeterReading()
        {
            Car c = new Car(10);
            c.Run(15, 3);
            double t = c.GetMeterReading();
            Assert.AreEqual(15 , t);
        }
        [TestMethod]
        public void IsStarted()
        {
            Car c = new Car(10);
            double t =  c.Start();
            bool r = c.IsStarted();
            Assert.AreEqual(true, r);
            t = c.Stop();
            r = c.IsStarted();
            Assert.AreEqual(false, r);
            
        }


    }
}
