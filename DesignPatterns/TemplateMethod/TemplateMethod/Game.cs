﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.TemplateMethod
{
    public abstract class Game
    {
        public void Run()
        {
            Start();
            while (!HaveWinner)
                TakeTurn();
            Console.WriteLine($"Player {WinningPlayer} wins.");
        }

        protected abstract void Start();
        protected abstract bool HaveWinner { get; }
        protected abstract void TakeTurn();
        protected abstract int WinningPlayer { get; }

        protected int currentPlayer;
        protected readonly int numberOfPlayers;

        public Game(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }
    }

}
