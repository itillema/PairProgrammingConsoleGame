﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConosole
{
    public enum GameModes
    {
        singleGame = 1,
        bestOfThree ,
        bestOfFive
    }
    public enum GameComponents
    {
        rock = 1,
        paper,
        scissors
    }
    
    //POCO
    public class ConsoleGame
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public int CompScore { get; set; }
        public GameModes TypeOfGame { get; set; }
        public GameComponents GameMoves { get; set; }

        //Constructor---One Empty, one overloaded
        public ConsoleGame() { }

        public ConsoleGame(string name, int playerScore, int compScore, GameModes modes, GameComponents moves)
        {
            PlayerName = name;
            PlayerScore = playerScore;
            CompScore = compScore;
            TypeOfGame = modes;
            GameMoves = moves;
        }
        // Create
        // Read
        // Update
        // Delete
    }
}