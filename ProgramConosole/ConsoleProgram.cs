using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConosole
{
    
    class ConsoleProgram
    {
        static void Main(string[] args)
        {
            ConsoleUI program = new ConsoleUI();
            program.Run();
        }
        
        {
            //Run the app, keep it running
            program 

            //Ask what kind of game mode.
            //Pretty sure all this shit needs to be in the ConsoleUI

            //Need computer to choose a random number everytime
            /* Random rnd = new Random();
            var randomNum = rnd.Next(1, 3);
            string compOptions = {"rock", "paper", "scissors" }; //Maybe make enum and assign number values to each string?
            var compChoice = compOptions(randomNum);
            */

            //Assigning values to enum GameComponents
            var moveRock

            //Store what the players choice is
            var playerChoice = "";

            System.Console.WriteLine("Welcome to Rock, Paper, Scissors. What game would you like to play?\n" +
                "1. Single Game\n" +
                "2. Best of Three Games\n" +
                "3. Best of Five Games");
            //make inputs lowercase
            playerChoice = System.Console.ReadLine(GameModes)

            System.Console.Clear();

            //Pre-Result
            System.Console.WriteLine($"You chose: {playerChoice}");
            System.Console.WriteLine($"The computer chose: {compChoice}\n");

            if (playerChoice == compChoice)
            {
                System.Console.WriteLine("You both chose the same thing. Your game ends in a draw.");
            }
            if (playerChoice == "rock" && compChoice == "scissors") || (playerChoice == "scissors" && compChoice == "paper") || (playerChoice == "paper" && compChoice == "rock");
            {
                System.Console.WriteLine("You won the game!");
            }
            if (playerChoice == "scissors" && compChoice == "rock") || (playerChoice == "paper" && compChoice == "scissors") || (playerChoice == "rock" && compChoice == "paper");
            {
                System.Console.WriteLine("Sorry, you lost the game...");
            }
            else
            {
                System.Console.WriteLine("That's not a valid move.");
            }

            System.Console.ReadLine();
        }
    }

}

