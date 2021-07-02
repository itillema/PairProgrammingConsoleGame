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
            bool keepMenuRunning = true;
            while (keepMenuRunning)
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
                        keepMenuRunning = false;
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
            bool keepSingleGameRunning = true;
            while (keepSingleGameRunning)
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
                            newGame.PlayerChoice = "Rock"; 
                            break;
                        case "2":
                            // Paper
                            newGame.PlayerChoice = "Paper";
                            break;
                        case "3":
                            // Scissors
                            newGame.PlayerChoice = "Scissors";
                            break;
                        default:
                            Console.WriteLine("Please enter a valid move (1 - 3).");
                            break;
                    }

                    // Have computer return random input

                    Random rnd = new Random();
                    int randomNum = rnd.Next(1, 3);
                    
                    switch (randomNum)
                    {
                        case 1:
                            // Rock 
                            newGame.CompChoice = "Rock";
                            break;
                        case 2:
                            // Paper
                            newGame.CompChoice = "Paper";
                            break;
                        case 3:
                            // Scissors
                            newGame.CompChoice = "Scissors";
                            break;
                        default:
                            Console.WriteLine("Please enter a valid move (1 - 3).");
                            break;
                    }

                    // Return both player and computer input, then press any button to continue
                    System.Console.WriteLine($"You chose: {newGame.PlayerChoice}");
                    System.Console.WriteLine($"The computer chose: {newGame.CompChoice}\n");
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    // Run logic
                    if (newGame.PlayerChoice == newGame.CompChoice)
                    {
                        System.Console.WriteLine("You both chose the same thing. Your game ends in a draw.");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if ((newGame.PlayerChoice == "Rock" && newGame.CompChoice == "Scissors") || (newGame.PlayerChoice == "Scissors" && newGame.CompChoice == "Paper") || (newGame.PlayerChoice == "Paper" && newGame.CompChoice == "Rock"))
                    {
                        System.Console.WriteLine("You won the game!");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else if ((newGame.PlayerChoice == "Scissors" && newGame.CompChoice == "Rock") || (newGame.PlayerChoice == "Paper" && newGame.CompChoice == "Scissors") || (newGame.PlayerChoice == "Rock" && newGame.CompChoice == "Paper"))
                    {
                        System.Console.WriteLine("Sorry, you lost the game...");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        System.Console.WriteLine("That's not a valid game. Try again");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    

                    // Return updated PlayerName, CompName, PlayerScore, and CompScore

                    // Return (writeline) if player wins or loses game and a closing statement: Thanks for playing! Press any key to return to menu, etc.
                }
                // Return to Menu
                Console.WriteLine("Thanks for playing!\n" +
                    "1. Return to Main Menu\n" +
                    "2. Play Single Game again");
                string inputResult = Console.ReadLine();
                switch (inputResult)
                {
                    case "1":
                        Console.Clear();
                        Menu();
                        break;
                    default:
                        Console.Clear();
                        CreateSingleGame();
                        break;
                }
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
