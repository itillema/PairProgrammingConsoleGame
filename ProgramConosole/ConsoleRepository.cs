using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConosole
{
    public class ConsoleRepsoitory
    {
        private List<ConsoleGameServices> _listOfCompontents = new List<ConsoleGameServices>();

        // Create
        // --- Create new game(s) by Game Mode
        // --- Create new player (but don't save player after game is over)
        public void AddGame(ConsoleGameServices addGameMode)
        {
            _listOfCompontents.Add(addGameMode);
        }
        public void AddPlayer(ConsoleGameServices addPlayerName)
        {
            _listOfCompontents.Add(addPlayerName);
        }

        // Read
        public List<ConsoleGameServices> GetGameInfo()
        {
            return _listOfCompontents;
        }

        // Update --- Maybe if another game is chosen, will update the listOfComponents like GameMode, Player, Score, etc.

        // Delete --- Maybe after a winner, delete the listOfComponents

    }
}
