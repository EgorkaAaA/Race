using Race.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловть в уличные гонки! " +
                "\nДля того чтобы запустить гонку со случайными характеристиками машин нажмите 1" +
                "\nДля того чтобы запустить гонку с настройкой своих характеристик нажмите 2");
            ConsoleKey key = Console.ReadKey().Key;
            Console.Clear();
            if(key == ConsoleKey.D1)
            {
                Truck truck = new Truck();
                LightCar lightCar = new LightCar();
                Motorcycle motorcycle = new Motorcycle();

                Console.WriteLine(truck.ToString());
                Console.WriteLine(lightCar.ToString());
                Console.WriteLine(motorcycle.ToString());

                Console.WriteLine("\n==========================НАЧАЛО ГОНКИ==========================\n");

                Console.WriteLine(RaceLogic.RaceLogic.result(truck));
                Console.WriteLine(RaceLogic.RaceLogic.result(lightCar));
                Console.WriteLine(RaceLogic.RaceLogic.result(motorcycle));

                Console.ReadKey();
            }
        }
    }
}
