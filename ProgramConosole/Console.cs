using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConosole
{
    class Console
    {
        static void Main(string[] args)
        {
            //Run the app, keep it running
            program 

            //Ask what kind of game mode.
            //Pretty sure all this shit needs to be in the ConsoleUI

            //Need computer to choose a random number everytime
            Random rnd = new Random();
            var randomNum = rnd.Next(0, 2);
            string compOptions = {"rock", "paper", "scissors" };
            var compChoice = compOptions(randomNum);

            //Store what the players choice is
            var playerChoice = "";

            System.Console.WriteLine("What's your choice: Rock, Paper, or Scissors?");
            System.Console.WriteLine("\nPlease enter your choice below:");
            System.Console.WriteLine("Choice: ");
            //make inputs lowercase
            playerChoice = System.Console.ReadLine().ToLower();

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

