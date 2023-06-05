namespace TowerDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers {get; set;}

        public Level(Invader[] invaders, Tower[] towers)
        {
            if(invaders == null || towers == null)
            {
                throw new TowerDefenseException("invaders and towers are required");
            } 
            else 
            {
            _invaders = invaders;
            Towers = towers;
            }
        }

        //returns true if player wins else false
        public bool Play()
        {
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders > 0)
            {
                foreach(Tower tower in Towers){
                    tower.FireOnInvaders(_invaders);
                }

                remainingInvaders = 0;

                foreach(Invader invader in _invaders){
                    if(invader.IsActive)
                    {
                        invader.Move();

                        if(invader.hasScored){
                            return false;
                        }
                        remainingInvaders ++;
                    }
                }
            }

            return true;
        }
    }
}