using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3
{
    class Vehicle
    {
        //fields
        private int seats;
        private int carryingCapacity;
        private string color;
        private double movementSpeed;
        private float gearRatio;
        private float engineSize;


        //Properties
        public int Seats { get; }
       
        public int CarryingCapacity { get; }
        
        public string Color { get; set; }


        //Constructors
        public Vehicle (int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }

    }
}
