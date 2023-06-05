namespace TowerDefense
{
    class PowerfullTower : Tower
    {
        protected override int Power { get; } = 2;
        protected override double Accuracy { get; } = .5;

        public PowerfullTower(MapLocation location) : base(location)
        {
        }
    }
}