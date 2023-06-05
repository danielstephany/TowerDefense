namespace TowerDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public int Area => Width * Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int GetArea()
        {
            return Area;
        }

        public bool OnMap(Point point)
        {
            bool xIsNotOnMap = point.X < 0 || point.X > Width;
            bool yIsNotOnMap = point.Y < 0 || point.Y > Height;

            return !(xIsNotOnMap || yIsNotOnMap);
        }
    }
}