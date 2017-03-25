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

            //LINQ query to display BMW cars with Sticker Price with value above 50k only
            /*var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.StickerPrice > 50000
                       //select car;
                       select new { car.Make, car.Model, car.StickerPrice };*/

            //LINQ query to sort the year
            /*var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;*/

            //alternative syntax instead of LINQ Query, this is called "Method syntax"
            var _bmws = myCars.Where(p => p.StickerPrice > 50000).OrderByDescending(p => p.Year);

            foreach (var car2 in _bmws)
            {
                Console.WriteLine("Brand: {0} - Model: {1} - Sticker Price: {2} - Year: {3}", car2.Make, car2.Model, car2.StickerPrice, car2.Year);
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
