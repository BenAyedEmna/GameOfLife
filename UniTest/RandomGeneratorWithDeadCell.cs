using GameOfLife;

namespace UniTest
{
    public class RandomGeneratorWithDeadCell : IRandomGenerator
    {
        public EtatCell GetRandomCellState()
        {
            return EtatCell.morte;
        }
    }
}