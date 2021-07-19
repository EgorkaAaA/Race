using Race.Models;
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

        public static double TimeForRace(double speed)
        {
            return Math.Round(raceDistance / speed, 2) ;
        }

        public static bool theWheelIsPierced(double wheelPunctureProbability)
        {
            Random random = new Random(); 
            return random.Next(0,100) <= wheelPunctureProbability ? true : false;
        }

        public static string result(Car car)
        {
            return  car.getClassName() + "\nвремя: " + TimeForRace(car.Speed) + "ч.\nсо скоростью: " + car.Speed;
        }
    }
}
