using System; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;
using System.Collections.Generic; 

namespace UniTest
{
    [TestClass]
    public class GridTest
    {
        [TestMethod]
        public void Grid_RowNegatif_ThrowsArgumentOutOfRangeException()
        {
            var nbrRow = -3;
            var nbrColumn = 6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>( () => new Grid(nbrRow,nbrColumn, new RandomGenerator()));
        }

        [TestMethod]
        public void Grid_columnNegatif_ThrowsArgumentOutOfRangeException()
        {
            var nbrRow = 10;
            var nbrColumn = -6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Grid(nbrRow,nbrColumn, new RandomGenerator()));
        }

        [TestMethod]
        public void Grid_RowcolumnNegatif_ThrowsArgumentOutOfRangeException()
        {
            var nbrRow = -8;
            var nbrColumn = -13;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Grid(nbrRow, nbrColumn, new RandomGenerator()));
        }
        
        [TestMethod]
        public void Grid_OneCellule()
        {
            var grid = new Grid(1,1, new RandomGenerator());
            grid.CreateGrid(); 
            grid.NextGeneration();
            Assert.IsTrue(grid.CelluleGrid[0][0].IsDead()); 
        }

        [TestMethod]
        public void CreateGrid_NbreCelluleTotal_GridCreated()
        {
            var grid = new Grid(4,7, new RandomGenerator());
            grid.CreateGrid();
            int CellTotalNbr,AliveCellNbr=0, DeadCellNbr = 0;
            CellTotalNbr = grid.NbreLine * grid.NbreColumn; 
            foreach(List<Cellule> Column in grid.CelluleGrid)
            {
                foreach(Cellule Cell in Column)
                {
                    if(Cell.IsAlive())
                        AliveCellNbr++;
                    else
                    {
                        if(Cell.IsDead())
                            DeadCellNbr++;
                    }
                }
            }
            Assert.AreEqual(CellTotalNbr, DeadCellNbr + AliveCellNbr); 
        }

        [TestMethod]
        public void CreateGrid_AllTheCellAreDead()
        {
            var grid = new Grid(4, 7, new RandomGeneratorWithDeadCell());
            grid.CreateGrid();

            foreach (List<Cellule> column in grid.CelluleGrid)
            {
                foreach (Cellule cell in column)
                {
                    Assert.IsTrue(cell.IsDead());
                }
            }
        }
    }
}
