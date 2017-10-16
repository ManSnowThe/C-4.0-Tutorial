// Добавить метод в класс Building.

using System;
namespace ca2
{
    class Building {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов

        //Вывести площадь одного человека
        public void AreaPerPerson()
        {
            Console.WriteLine(" " + Area / Occupants + " приходится на одного человека");
        }
    }
    // Использовать метод AreaPerPerson()
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();


            // присвоить значения полям в объекте house
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Присвоить значения полям в объекте office.
            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;


            Console.WriteLine("Дом имеет\n " +
                house.Floors + " этажа\n " +
                house.Occupants + " жильца\n " +
                house.Area +
                " кв. футов общей площади, из них ");
            house.AreaPerPerson();

            Console.WriteLine();

            Console.WriteLine("Учреждение имеет:\n " +
            office.Floors + " этажа\n " +
            office.Occupants + " работников\n " +
            office.Area +
            " кв. футов общей площади, из них ");
            office.AreaPerPerson();

        }
    }

}