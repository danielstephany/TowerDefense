namespace TowerDefense
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 3;

        public StrongInvader(MapPath path) : base(path)
        {
        }

    }
}