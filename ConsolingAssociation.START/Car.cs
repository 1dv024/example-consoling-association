using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsolingAssociation
{
    public class Car
    {
        private List<string> _driversLog = new List<string>();

        public string LastLogEntry => _driversLog.LastOrDefault();

        public string PetName { get; set; }

        public uint Speed { get; private set; }

        public void Go(Direction direction)
        {
            switch (direction)
            {
                case Direction.GoStraightAHead:
                    _driversLog.Add($"{PetName} goes straight a head.");
                    break;

                case Direction.TurnLeft:
                    _driversLog.Add($"{PetName} turns left.");
                    break;

                case Direction.TurnRight:
                    _driversLog.Add($"{PetName} turns right.");
                    break;

                case Direction.MakeUturn:
                    _driversLog.Add($"{PetName} makes a U-turn.");
                    break;

                default:
                    throw new ArgumentException("Unsupported direction", nameof(direction));
            }
        }

        public void Accelerate() => _driversLog.Add($"{PetName} accelerates to {Speed += 5} km/h.");

        public void Break() => _driversLog.Add(Speed >= 5
            ? $"{PetName} slows down to {Speed -= 5} km/h."
            : $"{PetName} can't slow down more.");

        public Car Copy()
        {
            var other = (Car) MemberwiseClone();
            other._driversLog = new List<string>(_driversLog);

            return other;
        }

        public void Start()
        {
            Debug.Assert(Speed == 0, "The car can't be going before started.");
            _driversLog.Add($"{PetName} starts.");
        }

        public void Stop()
        {
            Speed = 0;
            _driversLog.Add($"{PetName} stops.");
        }

        public override string ToString() => $"{PetName} is going at a rate of {Speed} km/h.";
    }
}