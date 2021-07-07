using System;

namespace GameOfLife
{
    public class RandomGenerator : IRandomGenerator
    {
        public EtatCell GetRandomCellState()
        {
            Random rnd = new Random();

            return (EtatCell)rnd.Next(2);
        }
    }
}