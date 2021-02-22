namespace RoShamBo
{
    //player that always selects rock
    public class TheJets : Player
    {
        public  RPS RoShamBoValue = RPS.Rock;

        public override RPS GenerateRPS()
        {
            return RoShamBoValue;
        }
    }
}
