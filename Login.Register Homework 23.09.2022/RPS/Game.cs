using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Register_Homework_23._09._2022.RPS
{
    public class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RockPaperScissors");
            while (true)
            {
                int botWins = 0;
                int humanWins = 0;
                string choice = Console.ReadLine();
                Random random = new Random();
                int botChoice = random.Next(1, 4);
                bool GameEnding = true;
                while (true)
                {
                    switch (botChoice)
                    {
                        case 1:
                            Console.WriteLine($"Bot selected Rock.Your choice is {choice}");
                            if (choice.ToLower() == "rock")
                            {
                                Console.WriteLine("Round was tie");
                            }
                            else if (choice.ToLower() == "paper")
                            {
                                Console.WriteLine("You won");
                                humanWins++;
                                if (humanWins == 3)
                                {
                                    Console.WriteLine($"You are great.You won {humanWins} times.Game Ended.Bot {botWins} times");
                                    Console.ReadKey();
                                    //GameEnding = false;
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bot won");
                                botWins++;
                                if (botWins == 3)
                                {
                                    Console.WriteLine($"Bot's score {botWins}.Game Over");
                                    Console.ReadKey();
                                    //GameEnding=false;
                                    break;
                                }
                            }

                            break;
                        case 2:
                            Console.WriteLine($"Bot selected Paper.Your choice is {choice}");
                            if (choice.ToLower() == "paper")
                            {
                                Console.WriteLine("Round was tie");
                            }
                            else if (choice.ToLower() == "scissors")
                            {
                                humanWins++;
                                Console.WriteLine($"You are great.You won {humanWins} times.Game Ended.Bot {botWins} times");
                                break;


                            }
                            else
                            {
                                Console.WriteLine($"Bot's score {botWins}.Game Over");
                                Console.ReadKey();
                                //GameEnding = false;
                                break;

                            }
                            break;
                        case 3:
                            Console.WriteLine($"Bot selected Scissors.Your choice is {choice}");
                            if (choice.ToLower() == "scissors")
                            {
                                Console.WriteLine("Round was tie");
                            }
                            else if (choice.ToLower() == "paper")
                            {
                                Console.WriteLine($"Bot's score {botWins}.Game Over");
                                Console.ReadKey();
                                break;

                            }
                            else
                            {

                                humanWins++;
                                Console.WriteLine($"You are great.You won {humanWins} times.Game Ended.Bot {botWins} times");
                                Console.ReadKey();
                                //GameEnding = false;
                                break;
                            }
                            break;


                    }
                }


            }
        }
    }
}
