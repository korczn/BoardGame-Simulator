using System;

namespace BoardGameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Warrior("Warrior", 0);
            Player player2 = new Mage("Mage", 0);
            Player player3 = new Healer("Healer", 0);

            Player[] players = new Player[] { player1, player2, player3 };
            Board board = new Board(20);
            Game game = new Game(players, board);

            game.StartGame();

            for (int i = 0; i < 5; i++)
            {
                game.PlayTurn();
            }

            game.DisplayScores();
        }
    }
}