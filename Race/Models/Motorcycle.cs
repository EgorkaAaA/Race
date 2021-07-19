using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models
{
    class Motorcycle : Car
    {
        private bool stroller;

        public bool Stroller { get => stroller; set => stroller = value; }

        public Motorcycle(bool stroller, double speed, double wheelPunctureProbability)
        {
            Stroller = stroller;
            WheelPunctureProbability = wheelPunctureProbability;
            Speed = speed;
        }

        public Motorcycle()
        {
            Random random = new Random();
            Stroller = false;
            Speed = random.NextDouble() * 120 + 1;
            WheelPunctureProbability = random.NextDouble() * 15;
        }
    }
}
