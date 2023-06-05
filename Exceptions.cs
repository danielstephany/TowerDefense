namespace TowerDefense {
    class TowerDefenseException : System.Exception
    {
        public TowerDefenseException()
        {
        }        
        public TowerDefenseException(string str) : base(str)
        {
        }        
    }
    class OutOfBounsException : System.Exception
    {
        public OutOfBounsException()
        {         
        }
        public OutOfBounsException(string str) : base(str)
        {         
        }
    }
}