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

        public double Speed { get => speed; set => speed = value; }
        public double WheelPunctureProbability { get => wheelPunctureProbability; set => wheelPunctureProbability = value; }
    }
}
