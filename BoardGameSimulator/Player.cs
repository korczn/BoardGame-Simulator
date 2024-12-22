namespace BoardGameSimulator
{
    public class Player
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Score { get; set; }
        public IPlayerRole Role { get; set; }

        public Player(string name, int startPosition, IPlayerRole role)
        {
            Name = name;
            Position = startPosition;
            Score = 0;
            Role = role;
        }

        public void Move(int steps)
        {
            Position += steps;
        }

        public void UpdateScore(int points)
        {
            Score += points;
        }

        public void PerformSpecialAction(Game game)
        {
            Role.PerformSpecialAction(this, game);
        }
    }
}