namespace TowerDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;

        public SniperTower(MapLocation location) : base(location)
        {
        }
    }
}