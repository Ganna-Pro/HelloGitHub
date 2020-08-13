using System;
using System.Collections.Generic;
using System.Text;

namespace BikeApplication
{
  public class Bike
    {         
        public int speed;
        public int gear;


       public Bike()
        {
            speed = 5;
            gear = 1;
        }

        public Bike(int bikeSpeed, int bikeGear)
        {
            speed = bikeSpeed;
            gear = bikeGear;
        }
        
        public void Accelerate()
        {
            speed++;
        }

        public void SetGear(int gear)
         {
            if (!(gear > 6))
            this.gear = gear;
        }

        private void Brakes()
        {
            speed--;
        }

        public void display()
        {
            Console.WriteLine("Speed: " + speed + "\n Gear:" + gear);
        }
    }
}


