namespace TowerDefense {
    class MapPath {
        private readonly MapLocation[] _path;
        public int Length => _path.Length;
        public MapPath(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (_path.Length > pathStep && pathStep >= 0) ? _path[pathStep] : null;
        }

        public bool IsOnPath(MapLocation location)
        {
            foreach(var pathLocation in _path)
            {
                if(location.Equals(pathLocation))
                {
                    return true;
                }
            }

            return false;
        }
    }
}