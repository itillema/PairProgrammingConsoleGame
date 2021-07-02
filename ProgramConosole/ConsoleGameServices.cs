using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConosole
{
    public enum GameModes
    {
        singleGame = 1,
        bestOfThree = 3,
        bestOfFive = 5
    }
    public enum GameComponents
    {
        rock = 1,
        paper,
        scissors
            //lizard
            //spock
    }
    
    //POCO
    public class ConsoleGameServices
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public int CompScore { get; set; }
        public string PlayerChoice { get; set; }
        public string CompChoice { get; set; }
        public GameModes TypeOfGame { get; set; }
        public GameComponents GameMoves { get; set; }
        public int PlayerResult { get; set; }
        public int CompResult { get; set; }
        public int GameLoopTimes { get; set; }

        //Constructor---One Empty, one overloaded with properties
        public ConsoleGameServices() { }

        public ConsoleGameServices(string name, int playerScore, int compScore, GameModes modes, GameComponents moves, string playerChoice, string compChoice, int playerResult, int compResult, int gameLoopTimes)
        {
            PlayerName = name;
            PlayerScore = playerScore;
            CompScore = compScore;
            TypeOfGame = modes;
            GameMoves = moves;
            PlayerChoice = playerChoice;
            CompChoice = compChoice;
            PlayerResult = playerResult;
            CompResult = compResult;
            GameLoopTimes = gameLoopTimes;
        }
        
        
    }
}
