using GameOfLife;

namespace UniTest
{
    class RandomGeneratorWithAliveCell : IRandomGenerator
    {
        public EtatCell GetRandomCellState()
        {
            return EtatCell.viante; 
        }
    }
}
