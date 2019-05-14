using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolingAssociation
{
    class Program
    {
        private static void Main()
        {
            var car = new Car { PetName = "McQueen" };
            Run(car);
        }

        private static void Run(Car car)
        {
            car.Start();
            Console.WriteLine(car.LastLogEntry);
            car.Accelerate();
            Console.WriteLine(car.LastLogEntry);
            car.Go(Direction.GoStraightAHead);
            Console.WriteLine(car.LastLogEntry);
            car.Accelerate();
            Console.WriteLine(car.LastLogEntry);
            car.Go(Direction.TurnLeft);
            Console.WriteLine(car.LastLogEntry);
            car.Go(Direction.GoStraightAHead);
            Console.WriteLine(car.LastLogEntry);
            car.Break();
            Console.WriteLine(car.LastLogEntry);
            car.Stop();
            Console.WriteLine(car.LastLogEntry);
        }
    }
}