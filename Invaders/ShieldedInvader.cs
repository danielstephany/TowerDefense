using System;

namespace TowerDefense
{
    class SheildedInvader : Invader
    {
        private static Random _random = new Random();
        public SheildedInvader(MapPath path) : base(path)
        {
        }

        public override void DecreaseHealth(int factor)
        {
            if(_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            } 
            else
            {
                Console.WriteLine("Shot at sheilded invader but no damage was taken.");
            }
        }
    }
}