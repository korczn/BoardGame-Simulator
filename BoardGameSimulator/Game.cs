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
            Console.WriteLine("Gra rozpoczęta!");
        }

        public void PlayTurn()
        {
            var currentPlayer = Players[CurrentPlayerIndex];
            Console.WriteLine($"{currentPlayer.Name}'s tura");

            Console.WriteLine("Rzuć kostką (naciśnij dowolny klawisz)");
            Console.ReadKey();

            Random diceRoll = new Random();
            int steps = diceRoll.Next(1, 7);  // Rzucenie kostką (1-6)
            Console.WriteLine($"{currentPlayer.Name} rzucił kostką i przesuwa się o {steps} pól.");

            currentPlayer.Move(steps);

            string field = Board.GetField(currentPlayer.Position);
            Console.WriteLine($"{currentPlayer.Name} stoi teraz na polu {currentPlayer.Position} ({field})");

            if (field == "Nagroda")
            {
                currentPlayer.UpdateScore(10);
                Console.WriteLine($"{currentPlayer.Name} zdobył nagrodę i zyskał 10 punktów!");
            }

            // Wykonanie specjalnej akcji postaci
            currentPlayer.PerformSpecialAction(this);

            // Przejście do następnego gracza
            CurrentPlayerIndex = (CurrentPlayerIndex + 1) % Players.Length;
        }

        public void DisplayScores()
        {
            Console.WriteLine("Koniec gry! Ostateczne wyniki:");
            foreach (var player in Players)
            {
                Console.WriteLine($"{player.Name}: {player.Score} punktów");
            }
        }
    }
}