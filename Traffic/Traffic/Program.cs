using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    class Program
    {
        static void Main(string[] args)
        {

            /*******************************************************************************************
             * There could have been several approaches to this problem
             * 1)Taking this as directed graph.
             * 
             * 2)Making a global time controller which could raise ticks and synchronise all objects
             *  like traffic lights, driver's action based on every tick.But this approach is more suitable 
             *  in case of simulations when there are several objecs etc.
             *  
             * 
             * 3)So, I have taken the third approach as per problem scope and to maintain simplicity.
             * 
             * The following assumptions have been made :
             * All units are same..like time in minutes, secs or hrs
             * Traffic light will assume the next light if the previous light duration is just over.
             * i.e during the transition of lights old to new ...new light will be assumed to operate.
             *
             * Car is in  "Start" state and at the start of journey and lights are green
             * 
             * Basic design is :
             * 
             * Route is composed of places which could be stretch or traffic light
             * Driver will select driving strategy based on place
             * Traffic light will give the waiting time based on elapsed time ..time passed since start of journey.
             * 
             * 
             * 
             * Test cases have assumed same time unit..for all entities
             * * *******************************************************************************************/
            //Please take all values in same unit preferably minute
            //sample input
            ICar car = new Car(10/60.0);//10 secs
            car.Start();
            List<IPlace> orderedPlaces = new List<IPlace>();
            orderedPlaces.Add(new RoadStretch(60/60.0, 150));//  km/hr to km/minutes
            orderedPlaces.Add(new TrafficLight(true, 1, 2));
            orderedPlaces.Add(new RoadStretch(30/60.0, 120));
            orderedPlaces.Add(new TrafficLight(true, 2, 2));
            orderedPlaces.Add(new RoadStretch(50/60.0, 80));
            Route route = new Route(orderedPlaces);
            IDriver driver = new Driver();
            Console.WriteLine(driver.Drive(car,route));//in minutes
            car.Stop();
            Console.ReadLine();

        }
    }
}
