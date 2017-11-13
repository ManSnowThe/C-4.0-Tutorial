// Применение предиката
using System;
using System.Collections.Generic;

namespace ca2
{
    public class Car
    {
        public int WheelSize { get; set; }
        public string ColorName { get; set; }
        public int DoorsCount { get; set; }
        public bool IsBroken { get; set; }

        public override string ToString()
        {
            return string.Format("Машина: {0}, {1}, {2}", ColorName, WheelSize.ToString(), IsBroken.ToString());
        }
    }
    class MyClass
    {
        private static List<Car> CreateGarage()
        {
            List<Car> cars = new List<Car>()
            {
                new ca2.Car()
                {
                    ColorName = "Синий", DoorsCount=4, IsBroken=false, WheelSize=15
                },
                new Car()
                {
                    ColorName = "Мокрый асфальт", DoorsCount = 4, IsBroken=true, WheelSize=18
                },
                new Car()
                {
                    ColorName = "Бежевый", DoorsCount = 3, IsBroken=false, WheelSize=22
                },
                new Car()
                {
                    ColorName = "Красный", DoorsCount = 4, IsBroken=true, WheelSize=22
                },
                new Car()
                {
                    ColorName = "Бежевый", DoorsCount = 3, IsBroken=false, WheelSize=17
                },
                new Car()
                {
                    ColorName = "Красный", DoorsCount = 4, IsBroken=false, WheelSize=19
                }
            };
            return cars;
        }
        private static List<Car> GetCars(List<Car> garage)
        {
            List<Car> founded = new List<Car>();
            foreach(Car item in garage)
            {
                    founded.Add(item);
            }
            return founded;
        }
        
        // Предикат
        private static bool FoundCar(Car car)
        {
            if (car.IsBroken)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            List<Car> Garage = CreateGarage();

            Console.WriteLine("Получить список машин:");
            foreach(Car item in GetCars(Garage))
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();

            Console.WriteLine("Получить список сломанных машин:");
            foreach(Car item in Garage.FindAll(FoundCar))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }
    }
}
