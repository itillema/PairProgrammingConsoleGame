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


                ConsoleGameServices newSingleGame = new ConsoleGameServices();

                // Ask player for their name
                Console.WriteLine("Nice! We'll play a single game.\n" +
                    "Before we start, type in your name:");
                newSingleGame.PlayerName = Console.ReadLine();

                Console.WriteLine("Press any key to continue the game...");
                Console.ReadKey();
                Console.Clear();
                SingleGameMenu();

                void SingleGameMenu()
                {


                    // Display PlayerName, CompName, PlayerScore, CompScore
                    Console.WriteLine($"{newSingleGame.PlayerName} - Score: {newSingleGame.PlayerScore}");
                    Console.WriteLine($"Computer - Score: {newSingleGame.CompScore}");


                    // Ask player to input Rock, Paper, or Scissors (writeline)
                    System.Console.WriteLine("What's your move?\n" +
                            "1. Rock\n" +
                            "2. Paper\n" +
                            "3. Scissors");

                    // Take user input (readline) and act accordingly
                    newSingleGame.PlayerChoice = Console.ReadLine();
                    switch (newSingleGame.PlayerChoice)
                    {
                        case "1":
                            // Rock 
                            newSingleGame.PlayerChoice = "Rock"; 
                            break;
                        case "2":
                            // Paper
                            newSingleGame.PlayerChoice = "Paper";
                            break;
                        case "3":
                            // Scissors
                            newSingleGame.PlayerChoice = "Scissors";
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
                            newSingleGame.CompChoice = "Rock";
                            break;
                        case 2:
                            // Paper
                            newSingleGame.CompChoice = "Paper";
                            break;
                        case 3:
                            // Scissors
                            newSingleGame.CompChoice = "Scissors";
                            break;
                        default:
                            Console.WriteLine("Please enter a valid move (1 - 3).");
                            break;
                    }

                    // Return both player and computer input, then press any button to continue
                    System.Console.WriteLine($"You chose: {newSingleGame.PlayerChoice}");
                    System.Console.WriteLine($"The computer chose: {newSingleGame.CompChoice}\n");
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    // Run logic
                    if (newSingleGame.PlayerChoice == newSingleGame.CompChoice)
                    {
                        System.Console.WriteLine("You both chose the same thing. Your game ends in a draw.");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if ((newSingleGame.PlayerChoice == "Rock" && newSingleGame.CompChoice == "Scissors") || (newSingleGame.PlayerChoice == "Scissors" && newSingleGame.CompChoice == "Paper") || (newSingleGame.PlayerChoice == "Paper" && newSingleGame.CompChoice == "Rock"))
                    {
                        System.Console.WriteLine("You won the game!");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else if ((newSingleGame.PlayerChoice == "Scissors" && newSingleGame.CompChoice == "Rock") || (newSingleGame.PlayerChoice == "Paper" && newSingleGame.CompChoice == "Scissors") || (newSingleGame.PlayerChoice == "Rock" && newSingleGame.CompChoice == "Paper"))
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
            /* What I started:          A FOR loop that should count the loops and stop after three.
             *                          A newBestOfThree.PlayerResult and CompResult.  These should keep add 
             *                                  one to the PlayerScore and CompScore after every round.
             * What needs to be done:   Finish the FOR loop and test.  Finish the scoring to reflect 
             *                                  updates after rounds and test. Finish changing up
             *                                  the logic to keep the PlayerName after each game.
             */
            
            ConsoleGameServices newBestOfThreeGame = new ConsoleGameServices();
            
            
            bool keepBestOfThreeRunning = true;
            for (int currentGameNumber = 1; currentGameNumber <= 3; currentGameNumber++ ) //Don't worry about score, focus on playing a total of 3 games no matter what
            {


                
                while (keepBestOfThreeRunning)
                {


                    // Ask player for their name
                    Console.WriteLine("Nice! We'll play Best of Three.\n" +
                        "Before we start, type in your name:");
                    newBestOfThreeGame.PlayerName = Console.ReadLine();

                    Console.WriteLine("Press any key to continue the game...");
                    Console.ReadKey();
                    Console.Clear();
                    BestOfThreeMenu();

                    void BestOfThreeMenu()
                    {


                        // Display PlayerName, CompName, PlayerScore, CompScore
                        Console.WriteLine($"{newBestOfThreeGame.PlayerName} - Score: {newBestOfThreeGame.PlayerScore + newBestOfThreeGame.PlayerResult}");
                        Console.WriteLine($"Computer - Score: {newBestOfThreeGame.CompScore + newBestOfThreeGame.CompResult}");


                        // Ask player to input Rock, Paper, or Scissors (writeline)
                        System.Console.WriteLine("What's your move?\n" +
                                "1. Rock\n" +
                                "2. Paper\n" +
                                "3. Scissors");

                        // Take user input (readline) and act accordingly
                        newBestOfThreeGame.PlayerChoice = Console.ReadLine();
                        switch (newBestOfThreeGame.PlayerChoice)
                        {
                            case "1":
                                // Rock 
                                newBestOfThreeGame.PlayerChoice = "Rock";
                                break;
                            case "2":
                                // Paper
                                newBestOfThreeGame.PlayerChoice = "Paper";
                                break;
                            case "3":
                                // Scissors
                                newBestOfThreeGame.PlayerChoice = "Scissors";
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
                                newBestOfThreeGame.CompChoice = "Rock";
                                break;
                            case 2:
                                // Paper
                                newBestOfThreeGame.CompChoice = "Paper";
                                break;
                            case 3:
                                // Scissors
                                newBestOfThreeGame.CompChoice = "Scissors";
                                break;
                            default:
                                Console.WriteLine("Please enter a valid move (1 - 3).");
                                break;
                        }

                        // Return both player and computer input, then press any button to continue
                        System.Console.WriteLine($"You chose: {newBestOfThreeGame.PlayerChoice}");
                        System.Console.WriteLine($"The computer chose: {newBestOfThreeGame.CompChoice}\n");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();

                        // Run logic
                        if (newBestOfThreeGame.PlayerChoice == newBestOfThreeGame.CompChoice)
                        {
                            System.Console.WriteLine("You both chose the same thing. Your game ends in a draw.");
                            Console.WriteLine("Please press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if ((newBestOfThreeGame.PlayerChoice == "Rock" && newBestOfThreeGame.CompChoice == "Scissors") || (newBestOfThreeGame.PlayerChoice == "Scissors" && newBestOfThreeGame.CompChoice == "Paper") || (newBestOfThreeGame.PlayerChoice == "Paper" && newBestOfThreeGame.CompChoice == "Rock"))
                        {
                            System.Console.WriteLine("You won the game!");
                            Console.WriteLine("Please press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else if ((newBestOfThreeGame.PlayerChoice == "Scissors" && newBestOfThreeGame.CompChoice == "Rock") || (newBestOfThreeGame.PlayerChoice == "Paper" && newBestOfThreeGame.CompChoice == "Scissors") || (newBestOfThreeGame.PlayerChoice == "Rock" && newBestOfThreeGame.CompChoice == "Paper"))
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
                        "2. Play Best of Three again");
                    string inputResult = Console.ReadLine();
                    switch (inputResult)
                    {
                        case "1":
                            Console.Clear();
                            Menu();
                            break;
                        default:
                            Console.Clear();
                            CreateBestOfThreeGame();
                            break;
                    }
                }
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
