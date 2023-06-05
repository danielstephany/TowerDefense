namespace TowerDefense
{
    class FastInvader : Invader
    {
        protected override int StepSize {get;} = 2;
        public FastInvader(MapPath path) : base(path)
        {
        }

    }
}