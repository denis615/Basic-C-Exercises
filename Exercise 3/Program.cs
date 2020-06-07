using System;
using System.Threading.Tasks.Dataflow;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerSCore=0;
            int cpuScore=0;
            int GamesPlayed=0;
            
       
            Random rnd = new Random();
            int cpu = rnd.Next(2);
            while (true)
            {
            FirstMenu:
                Console.Clear();
                Console.WriteLine("Welcome to the Rock-Paper-Scissors App");
                Console.WriteLine("Press 1 to start Playing or Press 2 to view the Statistics");
                string firstChoosing = Console.ReadLine();
                while (true)
                { 
                if (firstChoosing == "2")
                {
                    Console.WriteLine($"The Cpu has won {cpuScore} times");
                    Console.WriteLine($"The Player has won {playerSCore} times");
                        Console.WriteLine($"The Winning Percentage of the Player is {PercentageCalculator.CalculPercentage(playerSCore,GamesPlayed)}%");
                        Console.WriteLine($"The Winning Percentage of the Cpu is {PercentageCalculator.CalculPercentage(cpuScore, GamesPlayed)}%");
                        Console.WriteLine("Press enter To Continue");
                        Console.ReadLine();
                    goto FirstMenu;
                }
                if (firstChoosing == "1")
                {
                    goto StartGame;
                }
                else
                {
                    Console.WriteLine("Please Choose either 1 or 2");
                        Console.ReadLine();
                    goto FirstMenu;
                }
                
                }

            StartGame:
                Console.Clear();
            Console.WriteLine("Please choose");
            Console.WriteLine("1.Rock");
            Console.WriteLine("2.Paper");
            Console.WriteLine("3.Scissors");
            string userChoosing = Console.ReadLine();
            PlayerType.Players player = new PlayerType.Players();
            



                string[] displayEnums = Enum.GetNames(typeof(PlayerType.Players));
                
            if (userChoosing == "1")
            {
                player = PlayerType.Players.Rock;
                    Console.WriteLine($"You Have Chosen {player}");
                    Console.WriteLine($"The Cpu has choosen {displayEnums[cpu]}");
            }   
            if (userChoosing == "2")
            {
                player = PlayerType.Players.Paper;
                    Console.WriteLine($"You Have Chosen {player}");
                    Console.WriteLine($"The Cpu has choosen {displayEnums[cpu]}");
                }
            if (userChoosing == "3")
            {
                player = PlayerType.Players.Scissors;
                    Console.WriteLine($"You Have Chosen {player}");
                    Console.WriteLine($"The Cpu has choosen {displayEnums[cpu]}");
                }

           

            

            if ((int)player < cpu)
            {
                Console.WriteLine("You Lost");
                    cpuScore++;
                    GamesPlayed++;
            }
            if ((int)player > cpu)
            {
                Console.WriteLine("Won");
                    playerSCore++;
                    GamesPlayed++;
                }
                if ((int)player == cpu)
                {
                    Console.WriteLine("It's a Draw");
                    GamesPlayed++;
                  
                }

                while (true) { 
                Console.WriteLine("Press 1 to Try Again, or Press 2 to Exit the App");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    break;
                }
                    if (choose == "2")
                    {
                        Console.WriteLine("Bye Bye");
                        Environment.Exit(0);
                    }
                        }

                continue;
            }
        }
    }
}
