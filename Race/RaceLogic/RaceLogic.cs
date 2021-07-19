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

        public static double TimeForRace(double speed) => Math.Round(raceDistance / speed, 2) ;
        

        public static bool theWheelIsPierced(double wheelPunctureProbability)
        {
            Random random = new Random(); 
            return random.NextDouble() * 100 >= wheelPunctureProbability ? true : false;
        }

        public static string result(Car car)
        {
            return  theWheelIsPierced(car.WheelPunctureProbability) ?
                $"{car.getClassName()}\nвремя: {TimeForRace(car.Speed)}ч.\nсо скоростью: {car.Speed}"
                : $"у {car.getClassName()} спустилось колесо(((";
        }
    }
}
