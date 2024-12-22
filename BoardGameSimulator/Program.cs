using System;

namespace BoardGameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze planszowej!");

            // Tworzymy graczy z różnymi rolami
            Console.WriteLine("Podaj imię pierwszego gracza (Wojownik):");
            string playerName1 = Console.ReadLine();
            Player player1 = new Player(playerName1, 0, new Warrior());

            Console.WriteLine("Podaj imię drugiego gracza (Mag):");
            string playerName2 = Console.ReadLine();
            Player player2 = new Player(playerName2, 0, new Mage());

            Console.WriteLine("Podaj imię trzeciego gracza (Healer):");
            string playerName3 = Console.ReadLine();
            Player player3 = new Player(playerName3, 0, new Healer());

            Player[] players = new Player[] { player1, player2, player3 };
            Board board = new Board(20);
            Game game = new Game(players, board);

            game.StartGame();

            // Gra trwa przez 5 tur
            for (int i = 0; i < 5; i++)
            {
                game.PlayTurn();
            }

            game.DisplayScores();
        }
    }
}