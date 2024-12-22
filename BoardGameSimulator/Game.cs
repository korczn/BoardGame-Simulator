using System;

namespace BoardGameSimulator
{
    public class Game
    {
        public Player[] Players { get; set; }
        public Board Board { get; set; }
        public int CurrentPlayerIndex { get; set; }

        public Game(Player[] players, Board board)
        {
            Players = players;
            Board = board;
            CurrentPlayerIndex = 0;
        }

        public void StartGame()
        {
            Console.WriteLine("Game started!");
        }

        public void PlayTurn()
        {
            var currentPlayer = Players[CurrentPlayerIndex];
            Console.WriteLine($"{currentPlayer.Name}'s turn");

            Random diceRoll = new Random();
            int steps = diceRoll.Next(1, 7);
            Console.WriteLine($"{currentPlayer.Name} rolls a {steps}");

            currentPlayer.Move(steps);

            string field = Board.GetField(currentPlayer.Position);
            Console.WriteLine($"{currentPlayer.Name} is now on field {currentPlayer.Position} ({field})");

            if (field == "Reward")
            {
                currentPlayer.UpdateScore(10);
                Console.WriteLine($"{currentPlayer.Name} gets 10 points!");
            }

            CurrentPlayerIndex = (CurrentPlayerIndex + 1) % Players.Length;
        }

        public void DisplayScores()
        {
            Console.WriteLine("Game Over! Final scores:");
            foreach (var player in Players)
            {
                Console.WriteLine($"{player.Name}: {player.Score} points");
            }
        }
    }
}