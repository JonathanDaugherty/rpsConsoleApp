using System;

namespace rpsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            
            bool playAgain = true;

            while (playAgain == true)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose ROCK, PAPER, or SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("ONE POINT TO PLAYER");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("ONE POINT TO CPU");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("ONE POINT TO PLAYER");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("ONE POINT TO CPU");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("ONE POINT TO PLAYER");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("ONE POINT TO CPU");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                }

                Console.WriteLine($"Final Score: \n Player: {scorePlayer} \n CPU: {scoreCPU}");

                if(scorePlayer == 3)
                {
                    Console.WriteLine("Player WINS!");
                } else if(scoreCPU == 3)
                {
                    Console.WriteLine("CPU WINS!");
                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if(loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                } 
                else if(loop == "n")
                {
                    playAgain = false;
                } else
                {
                    Console.WriteLine("Invalid Entry");
                }     
            }
        }
    }
}
