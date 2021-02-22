using System;

namespace RoShamBo
{
    // Player that randomly generates R, P, or S
    public class TheSharks : Player
    {
        public override RPS GenerateRPS()
        {
            var rnd = new Random();
            int roShamBoNumberValue = rnd.Next(0, 2);

            Enum.TryParse<RPS>(roShamBoNumberValue.ToString(), out RPS RoShamBoSelection);

            return RoShamBoSelection;
        }
       
    }
}
