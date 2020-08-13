using System;
using System.Collections.Generic;
using System.Text;

namespace BikeApplication


{
    class Program
    {
        static void Main(string[] args)
        {
            Bike myBike = new Bike();
            myBike.speed = 30;
            myBike.gear = 2;
            myBike.Accelerate();
            myBike.SetGear(3);
            myBike.display();

            Bike yourBike = new Bike (40,4);
            yourBike.speed = 20;
            yourBike.gear = 1;
            yourBike.Accelerate();
            yourBike.SetGear(2);
            yourBike.display();

            Bike theirBike = new Bike(50, 4);
            yourBike.speed = 25;
            yourBike.gear = 1;
            yourBike.Accelerate();
            yourBike.SetGear(2);
            yourBike.display();



        }
    }
}
    