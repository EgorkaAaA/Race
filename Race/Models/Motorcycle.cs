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
            this.Stroller = stroller;
            this.WheelPunctureProbability = wheelPunctureProbability;
            this.Speed = speed;
        }

        public Motorcycle()
        {
            Random random = new Random();
            this.Stroller = false;
            this.Speed = random.NextDouble() * 150 + 1;
            this.WheelPunctureProbability = random.NextDouble() * 30;
        }

        public override string ToString()
        {
            return "Скорость мотоцикла: " + this.Speed +
                "\nВерояность пробоины в колесе: " + this.WheelPunctureProbability +
                "\nНаличе коляски: " + strollerToSTring();
        }

        private string strollerToSTring() => Stroller ? "есть" : "нет";

        public override string getClassName() => "Мотоцикл";
    }
}
