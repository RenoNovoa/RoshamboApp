namespace RoShamBo
{
    public abstract class Player
    {
        public RPS roshamboValue { get; set; }
        public string playerName { get; set; }


         public abstract RPS GenerateRPS();    
                
    }
}
