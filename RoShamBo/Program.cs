using System;
using System.Dynamic;
using System.Reflection.Emit;

namespace RoShamBo
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepRunning = true;
            while (keepRunning)               
                {
                    var test = new RPSApp();

                    test.runRoShamBoApp();

                    keepRunning = ContinuePlaying();
                }

        }


        public static bool ContinuePlaying()
        {
            var invalidInput = true;
            do
            {
                Console.WriteLine("Do You Want to Play Again? (y/n)\n");
                var userCommand = Console.ReadLine();
                if (userCommand.Equals("y", StringComparison.OrdinalIgnoreCase) || userCommand.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (userCommand.Equals("n", StringComparison.OrdinalIgnoreCase) || userCommand.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Gracias por jugar amigo ");
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not a valid selection");
                    continue;

                }
            } while (invalidInput);
            return true;
        }
    }
}
