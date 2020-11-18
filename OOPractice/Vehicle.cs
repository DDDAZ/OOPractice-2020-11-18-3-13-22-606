using System;
using System.Collections.Generic;
using System.Text;

namespace OOPractice
{
    public class Vehicle
    {
        protected string name;
        protected int speed;

        public Vehicle(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return $"{name}: speed up {speed} km/h";
        }
    }
}
