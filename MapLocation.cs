namespace TowerDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if(!map.OnMap(this))
            {
                throw new OutOfBounsException(this + " is outside of the map.");
            }
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Point)){
                return false;
            }

            Point that = obj as Point;

            return this.X == that.X && this.Y == that.Y;          
        }

        public bool InRangeOf(MapLocation mapLocation, int range)
        {
            return DistanceTo(mapLocation) <= range;
        }
    }
}