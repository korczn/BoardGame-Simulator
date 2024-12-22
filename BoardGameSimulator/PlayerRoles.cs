namespace BoardGameSimulator
{
    public interface IPlayerRole
    {
        void PerformSpecialAction(Player player, Game game);
    }

    public class Warrior : Player, IPlayerRole
    {
        public Warrior(string name, int startPosition) : base(name, startPosition) { }

        public void PerformSpecialAction(Player player, Game game)
        {
            player.UpdateScore(5);
            Console.WriteLine($"{player.Name} performs a Warrior special action and gains 5 points!");
        }
    }

    public class Mage : Player, IPlayerRole
    {
        public Mage(string name, int startPosition) : base(name, startPosition) { }

        public void PerformSpecialAction(Player player, Game game)
        {
            Console.WriteLine($"{player.Name} casts a spell, influencing the game!");
        }
    }

    public class Healer : Player, IPlayerRole
    {
        public Healer(string name, int startPosition) : base(name, startPosition) { }

        public void PerformSpecialAction(Player player, Game game)
        {
            Console.WriteLine($"{player.Name} heals another player!");
        }
    }
}