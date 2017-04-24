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
            Console.WriteLine(car.CrankTunes());
            Run(car);
            Console.WriteLine(car.CrankTunes(false));
            ViewLog(car);

            var other = car.Copy();
            other.PetName = "Mack";
            other.Start();
            other.Accelerate();
            other.Go(Direction.MakeUturn);
            ViewLog(other);

            ViewLog(car);
        }

        private static void Run(Car car)
        {
            car.Start();
            car.Accelerate();
            car.Go(Direction.GoStraightAHead);
            car.Accelerate();
            car.Go(Direction.TurnLeft);
            car.Go(Direction.GoStraightAHead);
            car.Break();
            car.Stop();
        }

        private static void ViewLog(Car car)
        {
            Console.WriteLine($"\n{car.PetName}");
            Console.WriteLine($"=============================================");
            foreach (var logEntry in car.LogEntries)
            {
                Console.WriteLine(logEntry);
            }
        }

    }
}
