using System;
using System.Collections.Generic;
using System.Text;

namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, int speed) : base(name, speed)
        {
        }

        public Car(string name, IEngine engine) : base(name, engine.GetSpeed())
        {
        }
    }
}
