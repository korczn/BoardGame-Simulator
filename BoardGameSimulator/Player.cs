namespace BoardGameSimulator
{
    public class Player
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Score { get; set; }

        public Player(string name, int startPosition)
        {
            Name = name;
            Position = startPosition;
            Score = 0;
        }

        public void Move(int steps)
        {
            Position += steps;
        }

        public void UpdateScore(int points)
        {
            Score += points;
        }
    }
}