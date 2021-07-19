using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models
{
    class LightCar : Car
    {
        private int peopleCount;

        public int PeopleCount { get => peopleCount; set => peopleCount = value; }

        public LightCar()
        {
            Random random = new Random();
            this.Speed = random.NextDouble() * 120 + 1;
            this.WheelPunctureProbability = random.NextDouble() * 15;
            this.peopleCount = random.Next(0, 4);
        }

        public LightCar(double speed, double wheelPunctureProbability, int peopleCount)
        {
            Speed = speed;
            WheelPunctureProbability = wheelPunctureProbability;
            PeopleCount = peopleCount;
        }
    }
}
