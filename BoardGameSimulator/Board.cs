using System;

namespace BoardGameSimulator
{
    public class Board
    {
        public int Size { get; set; }
        private string[] fields;

        public Board(int size)
        {
            Size = size;
            fields = new string[Size];
            GenerateRewards();
        }

        private void GenerateRewards()
        {
            Random rand = new Random();
            for (int i = 0; i < Size; i++)
            {
                if (rand.Next(0, 10) < 3)
                {
                    fields[i] = "Reward";
                }
                else
                {
                    fields[i] = "Empty";
                }
            }
        }

        public string GetField(int position)
        {
            if (position >= 0 && position < Size)
            {
                return fields[position];
            }
            return "Out of bounds";
        }
    }
}