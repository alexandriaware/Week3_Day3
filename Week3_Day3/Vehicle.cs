﻿using System;
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
        private double distanceTraveled;


        //Properties
        public int Seats { get; }
       
        public int CarryingCapacity { get; }
        
        public string Color { get; set; }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }


        //Constructors
        public Vehicle()
        {

        }

        public Vehicle (int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0d;
        }


        //Methods
        public void Move()
        {
            distanceTraveled += movementSpeed;
        }

    }
}
