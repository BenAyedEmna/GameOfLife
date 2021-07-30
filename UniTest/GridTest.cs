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
            Generation Generation1 = new Generation();
            Grid grid2;
            grid2=Generation1.NextGeneration(grid);
            Assert.IsTrue(grid2.CelluleGrid[0][0].IsDead()); 
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

        [TestMethod]
        public void CreateGrid_AllTheCellAreAlive()
        {
            var grid = new Grid(4, 4, new RandomGeneratorWithAliveCell());
            grid.CreateGrid();
            foreach (List<Cellule> Column in grid.CelluleGrid)
            {
                foreach (Cellule Cell in Column)
                {
                    Assert.IsTrue(Cell.IsAlive()); 
                }
            }
        }

        [TestMethod]
        public void CreateGridNextGeneration_AllTheCellAreAlive()
        {
            var grid = new Grid(4,4,new RandomGeneratorWithAliveCell());
            grid.CreateGrid();
            Generation Generation1 = new Generation();
            grid=Generation1.NextGeneration(grid);
            int AliveCellNbr = 0,i,j;
            for(i=0;i<grid.NbreColumn;i++)
            {
                for(j=0;j<grid.NbreLine;j++)
                {
                    if (grid.CelluleGrid[i][j].IsAlive())
                        AliveCellNbr++;
                }
            }
            Assert.IsTrue((grid.CelluleGrid[0][0].IsAlive()) && (grid.CelluleGrid[0][3].IsAlive()) && (grid.CelluleGrid[3][0].IsAlive()) && (grid.CelluleGrid[3][3].IsAlive()));
            Assert.AreEqual(AliveCellNbr,4);     
        }
    }


}
