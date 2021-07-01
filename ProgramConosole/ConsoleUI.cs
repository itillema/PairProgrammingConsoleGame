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
                string inputMode = Console.ReadLine();

                // Evaluate user's input and act accordingly
                switch (inputMode)
                {
                    case "1":
                        // Single Game
                        Console.Clear();
                        CreateSingleGame();
                        break;
                    case "2":
                        // Best of 3
                        Console.Clear();
                        CreateBestOfThreeGame();
                        break;
                    case "3":
                        // Best of 5
                        Console.Clear();
                        CreateBestOfFiveGame();
                        break;
                    case "4":
                        //Exit
                        Console.Clear();
                        Console.WriteLine("Later!");
                        keepRunning = false;
                        break;
                    //default:
                        //Console.WriteLine("Please enter a valid mode (1 - 3) or exit the game (4).");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Console.Clear();
            }

        }

        // Single Game Mode
        private void CreateSingleGame()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                ConsoleGameServices newGame = new ConsoleGameServices();

                // Ask player for their name
                Console.WriteLine("Nice! We'll play a single game.\n" +
                    "Before we start, type in your name:");
                newGame.PlayerName = Console.ReadLine();

                Console.WriteLine("Press any key to continue the game...");
                Console.ReadKey();
                Console.Clear();
                SingleGameMenu();

                void SingleGameMenu()
                {


                    // Display PlayerName, CompName, PlayerScore, CompScore
                    Console.WriteLine($"{newGame.PlayerName} - Score: {newGame.PlayerScore}");
                    Console.WriteLine($"Computer - Score: {newGame.CompScore}");


                    // Ask player to input Rock, Paper, or Scissors (writeline)
                    System.Console.WriteLine("What's your move?\n" +
                            "1. Rock\n" +
                            "2. Paper\n" +
                            "3. Scissors");

                    // Take user input (readline) and act accordingly
                    newGame.PlayerChoice = Console.ReadLine();
                    switch (newGame.PlayerChoice)
                    {
                        case "1":
                            // Rock 
                            // Hard time coming up with what to do here.

                            break;
                        case "2":
                            // Paper

                            break;
                        case "3":
                            // Scissors

                            break;
                        //default:
                            //Console.WriteLine("Please enter a valid move (1 - 3).");
                    }

                    // Have computer return random input
                     
                    Random rnd = new Random();
                    var randomNum = rnd.Next(1, 3);
                    //string compOptions = {}; //Maybe make enum and assign number values to each string?
                    newGame.CompChoice = newGame.(randomNum); 
                    

                    // Return both player and computer input, then press any button to continue
                    System.Console.WriteLine($"You chose: {newGame.PlayerChoice}");
                    System.Console.WriteLine($"The computer chose: {newGame.CompChoice}\n");
                    Console.WriteLine("Please press any key to continue..");
                    Console.ReadKey();
                    Console.Clear();

                    // Run logic
                    if (newGame.PlayerChoice == newGame.CompChoice)
                    {
                        System.Console.WriteLine("You both chose the same thing. Your game ends in a draw.");
                    }
                    else if ((newGame.PlayerChoice == "rock" && newGame.CompChoice == "scissors") || (newGame.PlayerChoice == "scissors" && newGame.CompChoice == "paper") || (newGame.PlayerChoice == "paper" && newGame.CompChoice == "rock"))
                    {
                        System.Console.WriteLine("You won the game!");

                    }
                    else if ((newGame.PlayerChoice == "scissors" && newGame.CompChoice == "rock") || (newGame.PlayerChoice == "paper" && newGame.CompChoice == "scissors") || (newGame.PlayerChoice == "rock" && newGame.CompChoice == "paper"))
                    {
                        System.Console.WriteLine("Sorry, you lost the game...");
                    }
                    else
                    {
                        System.Console.WriteLine("That's not a valid game. Try again");
                        // Return player to SingleGameMenu
                    }

                    System.Console.ReadLine();

                    // Return updated PlayerName, CompName, PlayerScore, and CompScore

                    // Return (writeline) if player wins or loses game and a closing statement: Thanks for playing! Press any key to return to menu, etc.
                }
                // Return to Menu
            }
        }

        private void CreateBestOfThreeGame()
        {
            bool keepRunning = true;
            while (keepRunning)
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
        }

        private void CreateBestOfFiveGame()
        {
            bool keepRunning = true;
            while (keepRunning)
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
}
