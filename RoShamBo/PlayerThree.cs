namespace RoShamBo
{
    // Returns any value we choose
    public class PlayerThree : Player
    {
        public RPS RoShamBoValue = RPS.Scissors;

        public override RPS GenerateRPS()
        {
            return RoShamBoValue;
        }
    }
}
