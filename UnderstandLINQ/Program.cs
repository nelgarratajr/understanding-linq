using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { Make = "BMW", Model = "550i", Year = 2009, Color = CarColor.Black, StickerPrice = 55000 },
                new Car() { Make = "Toyota", Model = "4Runner", Year = 2010, Color = CarColor.Blue, StickerPrice = 35000 },
                new Car() { Make = "BWM", Model = "745li", Year = 2008, Color = CarColor.Red, StickerPrice = 75000 },
                new Car() { Make = "Ford", Model = "Escape", Year = 2008, Color = CarColor.White, StickerPrice = 25000 },
                new Car() { Make = "BMW", Model = "55i", Year = 2010, Color = CarColor.Yellow, StickerPrice = 57000 }
            };

            var bmws = from car in myCars
                       where car.Make == "BMW"
                       select car;

            foreach (var car in bmws)
            {
                Console.WriteLine("Brand: {0} - Model: {1}", car.Make, car.Model);
            }
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor Color { get; set; }        
    }

    enum CarColor
    {
        Black,
        White,
        Red,
        Blue,
        Yellow
    }
}
