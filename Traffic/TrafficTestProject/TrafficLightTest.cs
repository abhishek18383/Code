using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Traffic;

namespace TrafficTestProject
{
    [TestClass]
    public class TrafficLightTest
    {
        [TestMethod]
        public void GetWaitingTime()
        {
           TrafficLight t = new TrafficLight(true, 1, 2);
          
            double waitingTime=t.GetWaitingTime(.5);
           Assert.AreEqual(0, waitingTime);
           
            waitingTime = t.GetWaitingTime(2);
           Assert.AreEqual(1, waitingTime);
           
            waitingTime = t.GetWaitingTime(3.5);
           Assert.AreEqual(0, waitingTime);

           waitingTime = t.GetWaitingTime(1);
           Assert.AreEqual(2, waitingTime);

           waitingTime = t.GetWaitingTime(3);
           Assert.AreEqual(0, waitingTime);

    }
    }
}
