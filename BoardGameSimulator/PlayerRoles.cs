namespace BoardGameSimulator
{
    public interface IPlayerRole
    {
        void PerformSpecialAction(Player player, Game game);
    }

    public class Warrior : IPlayerRole
    {
        public void PerformSpecialAction(Player player, Game game)
        {
            // Wojownik zdobywa dodatkowe punkty za każdą nagrodę.
            player.UpdateScore(5);
            Console.WriteLine($"{player.Name} wykonuje specjalną akcję Wojownika i zdobywa 5 punktów!");
        }
    }

    public class Mage : IPlayerRole
    {
        public void PerformSpecialAction(Player player, Game game)
        {
            // Mag rzuca zaklęcie - może przenieść się o dodatkowe pole.
            int bonusMove = 2;
            player.Move(bonusMove);
            Console.WriteLine($"{player.Name} rzuca zaklęcie i przesuwa się o {bonusMove} dodatkowe pole!");
        }
    }

    public class Healer : IPlayerRole
    {
        public void PerformSpecialAction(Player player, Game game)
        {
            // Healer leczy innych graczy - zmienia wynik innego gracza.
            Console.WriteLine($"{player.Name} używa swojej zdolności leczenia!");
            if (game.Players.Length > 1)
            {
                // Leczymy innych graczy, przywracając im 3 punkty.
                foreach (var p in game.Players)
                {
                    if (p != player)
                    {
                        p.UpdateScore(3);
                        Console.WriteLine($"{p.Name} zyskał 3 punkty dzięki leczeniu {player.Name}!");
                    }
                }
            }
        }
    }
}