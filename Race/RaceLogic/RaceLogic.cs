using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.RaceLogic
{
    static class RaceLogic
    {
        private static double raceDistance = 100;

        public static double TimeForRace(double speeed)
        {
            return speeed / raceDistance;
        }

        public static bool theWheelIsPierced(double wheelPunctureProbability)
        {
            Random random = new Random(); 
            return random.Next(0,100) <= wheelPunctureProbability ? true : false;
        }
    }
}
