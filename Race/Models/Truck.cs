using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models
{
    class Truck : Car
    {
        private int weight;

        public int Weight { get => weight; set => weight = value; }

        public Truck()
        {
            Random random = new Random();
            this.Speed = random.NextDouble() * 80 + 1;
            this.WheelPunctureProbability = random.NextDouble() * 14;
            this.Weight = random.Next(0,1500);

        }
        public Truck(double speed, double wheelPunctureProbability,int weight)
        {
            this.Speed = speed;
            this.WheelPunctureProbability = wheelPunctureProbability;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return "Скорость грузовик: " + Speed +
                "\nВерояность пробоины в колесе: " + WheelPunctureProbability +
                "\nВес перевозимый грузовиком: " + Weight;
        }

        public override string getClassName()
        {
            return "Грузовик";
        }
    }
}
