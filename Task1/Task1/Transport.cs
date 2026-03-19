using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public abstract class Transport
    {
        protected string model;
        protected int speed;
        protected FuelType fuelType;

        public Transport(string model, int speed, FuelType fuelType)
        {
            this.fuelType = fuelType;
            this.model = model;
            this.speed = speed;
        }
    }
}
