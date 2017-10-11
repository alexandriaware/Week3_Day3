﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3
{
    class Automobile : Vehicle
    {
        //fields
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        //Properties
        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }

        //Constructor
        public Automobile (int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }

    }
}
