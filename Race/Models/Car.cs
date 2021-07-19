using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models
{
    abstract class Car
    {
        private double speed;
        private double wheelPunctureProbability;

        public double Speed { get => Math.Round(speed,2); set => speed = value; }
        public double WheelPunctureProbability { get => Math.Round(wheelPunctureProbability, 2); set => wheelPunctureProbability = value; }

        public abstract string getClassName();
    }
}
