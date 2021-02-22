using System;

namespace RoShamBo
{
    public class RPSApp
    {

        public bool ValidateTeamName(string userInput)
        {
            if(userInput.Equals("jets", StringComparison.OrdinalIgnoreCase) || userInput.Equals("the Jets", StringComparison.OrdinalIgnoreCase) || userInput.Equals("sharks", StringComparison.OrdinalIgnoreCase) || userInput.Equals("the sharks", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                Console.WriteLine("This is not a valid selection, please try again");
                return false;
            }
        }
        public void runRoShamBoApp()
        {
            bool invalidInput = true;
            
            Console.Write("Welcome to the Rock Paper Scissors APP.\nEnter your name:");
            var userName = Console.ReadLine();           


            while (invalidInput)
            {
                Console.Write($"Hi {userName} Would you like to play against the\nSharks or the Jets?: ");
                var playingAgainst = Console.ReadLine();
                if (ValidateTeamName(playingAgainst))
                {
                    invalidInput = false;
                    bool invalidPlay = true;
                    while (invalidPlay)
                    {
                        Console.WriteLine("Rock, Paper, or Scissors?");
                        var userSelection = Console.ReadLine();
                        if (validRPSInput(userSelection))
                        {
                            invalidPlay = false;
                            if (playingAgainst.Equals("jets", StringComparison.OrdinalIgnoreCase) || playingAgainst.Equals("the Jets", StringComparison.OrdinalIgnoreCase))
                            {
                                var AISelection = new TheJets();
                                AISelection.playerName = "The Jets";
                                AISelection.roshamboValue = AISelection.GenerateRPS();


                                Console.WriteLine($"{userName}: {userSelection}");
                                Console.WriteLine($"{AISelection.playerName}: {AISelection.roshamboValue}");
                                if (userSelection.Equals("Scissors", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine($"{AISelection.playerName} Win");
                                }
                                else if (userSelection.Equals("paper", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine($"{userName} Wins");
                                }
                                else
                                {
                                    Console.WriteLine("Draw");
                                }

                            }
                            else if (playingAgainst.Equals("sharks", StringComparison.OrdinalIgnoreCase) || playingAgainst.Equals("the sharks", StringComparison.OrdinalIgnoreCase))
                            {
                                var AISelection = new TheSharks();
                                AISelection.playerName = "The Sharks";
                                AISelection.roshamboValue = AISelection.GenerateRPS();




                                Console.WriteLine($"{userName}: {userSelection}");
                                Console.WriteLine($"{AISelection.playerName}: {AISelection.roshamboValue}");

                                if (userSelection.Equals("Scissors", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (AISelection.roshamboValue == RPS.Rock)
                                    {
                                        Console.WriteLine($"{AISelection.playerName} Win");
                                    }
                                    else if (AISelection.roshamboValue == RPS.Paper)
                                    {
                                        Console.WriteLine($"{userName} Wins");
                                    }
                                    else if (AISelection.roshamboValue == RPS.Scissors)
                                    {
                                        Console.WriteLine("Draw");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Broke It");
                                    }

                                }
                                else if (userSelection.Equals("Rock", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (AISelection.roshamboValue == RPS.Paper)
                                    {
                                        Console.WriteLine($"{AISelection.playerName} Win");
                                    }
                                    else if (AISelection.roshamboValue == RPS.Scissors)
                                    {
                                        Console.WriteLine($"{userName} Wins");
                                    }
                                    else if (AISelection.roshamboValue == RPS.Rock)
                                    {
                                        Console.WriteLine("Draw");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Broke It");
                                    }
                                }
                                else if (userSelection.Equals("paper", StringComparison.OrdinalIgnoreCase))
                                {
                                    if (AISelection.roshamboValue == RPS.Scissors)
                                    {
                                        Console.WriteLine($"{AISelection.playerName} Win");
                                    }
                                    else if (AISelection.roshamboValue == RPS.Rock)
                                    {
                                        Console.WriteLine($"{userName} Wins");
                                    }
                                    else if (AISelection.roshamboValue == RPS.Paper)
                                    {
                                        Console.WriteLine("Draw");
                                    }
                                    else
                                    {
                                        
                                        Console.WriteLine("You Broke It");
                                    }
                                }

                            }
                        }                                                
                    }
                    
                    
            
                } 
                
            



            }



        }

        private bool validRPSInput(string userSelection)
        {
            if(userSelection.Equals("rock", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("paper", StringComparison.OrdinalIgnoreCase) || userSelection.Equals("scissors", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                Console.WriteLine("That is not a valid selection, please try again");
                return false;
            }
        }
    }
}
