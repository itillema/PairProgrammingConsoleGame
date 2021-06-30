using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConosole
{
    class ConsoleUI
    {
        //Method that runs/starts the application UI
        public void Run()
        {
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {



                // Display options to player
                System.Console.WriteLine("Welcome to Rock, Paper, Scissors. What game would you like to play?\n" +
                    "1. Single Game\n" +
                    "2. Best of Three Games\n" +
                    "3. Best of Five Games\n" +
                    "4. Exit Game");

                // Get users input
                string input = Console.ReadLine();

                // Evaluate user's input and act accordingly
                switch (input)
                {
                    case "1":
                        // Single Game
                        CreateSingleGame();
                        break;
                    case "2":
                        // Best of 3
                        CreateBestOfThreeGame();
                        break;
                    case "3":
                        // Best of 5
                        CreateBestOfFiveGame();
                        break;
                    case "4":
                        //Exit
                        Console.WriteLine("Later!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine("Please press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            }

        }

        // Single Game Mode
        private void CreateSingleGame()
        {
            ConsoleGame newGame = new ConsoleGame();

            // Ask player for their name
            Console.WriteLine("Nice! We'll play a single game.\n" +
                "Before we start, type in your name:");
            newGame.PlayerName = Console.ReadLine();

            Console.WriteLine("Please press any key to continue..");
            Console.ReadKey();
            Console.Clear();

            // Display PlayerName, CompName, PlayerScore, CompScore
            Console.WriteLine($"{newGame.PlayerName} - Score: {newGame.PlayerScore}");
            Console.WriteLine($"Computer 1 - Score: {newGame.CompScore}");
            

            // Ask player to input Rock, Paper, or Scissors (writeline)

            // Take user input (readline)

            // Have computer return random input

            // Run logic

            // Return both player and computer input, then press any button to continue

            // Return updated PlayerName, CompName, PlayerScore, and CompScore

            // Return (writeline) if player wins or loses game and a closing statement: Thanks for playing! Press any key to return to menu, etc.

            // Return to Menu

        }

        private void CreateBestOfThreeGame()
        {

            // Ask player for their name

            // Display PlayerName, CompName, PlayerScore, CompScore

            //RUN THE FOLLOWING INDENTED COMMENTS THREE TIMES
            // ---Ask player to input Rock, Paper, or Scissors (writeline)

            // ---Take user input (readline)

            // ---Have computer return random input

            // ---Run logic

            // ---Return both player and computer input, then press any button to continue

            // ---Return updated PlayerName, CompName, PlayerScore, and CompScore

            // Return (writeline) if player wins or loses game and a closing statement: Thanks for playing! Press any key to return to menu, etc.

            // Return to Menu

        }

        private void CreateBestOfFiveGame()
        {

            // Ask player for their name

            // Display PlayerName, CompName, PlayerScore, CompScore

            //RUN THE FOLLOWING INDENTED COMMENTS FIVE TIMES
            // ---Ask player to input Rock, Paper, or Scissors (writeline)

            // ---Take user input (readline)

            // ---Have computer return random input

            // ---Run logic

            // ---Return both player and computer input, then press any button to continue

            // ---Return updated PlayerName, CompName, PlayerScore, and CompScore

            // Return (writeline) if player wins or loses game and a closing statement: Thanks for playing! Press any key to return to menu, etc.

            // Return to Menu

        }

    }
}
