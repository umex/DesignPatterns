using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.FunctionalTemplateMethod
{
    public class FunctionalTemplateMethodMain
    {
        static void Main(string[] args)
        {
            var numberOfPlayers = 2;
            int currentPlayer = 0;
            int turn = 1, maxTurns = 10;

            void Start()
            {
                Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
            }

            bool HaveWinner()
            {
                return turn == maxTurns;
            }

            void TakeTurn()
            {
                Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
                currentPlayer = (currentPlayer + 1) % numberOfPlayers;
            }

            int WinningPlayer()
            {
                return currentPlayer;
            }

            GameTemplate.Run(Start, TakeTurn, HaveWinner, WinningPlayer);
        }

    }
}
