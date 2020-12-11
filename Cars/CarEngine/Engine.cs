using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Cars.CarEngine
{
    class Engine
    {
        public string Type { private set; get; }
        public float Capacity { private set; get; }
        public float Power { private set; get; }

        public Engine(string type, float capacity, float power)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.Power = power;
        }
    }
}
