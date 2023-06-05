namespace TowerDefense
{
    class Invader
    {
        private int _pathStep = 0;
        protected virtual int StepSize {get;} = 1;
        private readonly MapPath _path;
        public virtual int Health {get; protected set;} = 2;
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public bool hasScored => _pathStep >= _path.Length;
        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || hasScored);

        public Invader(MapPath path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
        }


    }
}