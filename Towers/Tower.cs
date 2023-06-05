using System;

namespace TowerDefense
{
    class Tower {
        protected virtual int Range {get;} = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;
        private readonly MapLocation _location;

        private static readonly Random _random = new System.Random();

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Shot at and hit invader");
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader is neutralized");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Shot at and missed invader");
                    }
                    break;
                }
            }
        }
    }
}