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
            int nbrRow,nbrColumn;
            nbrRow = -3;
            nbrColumn = 6;
            Grid grid;   
            Assert.ThrowsException<System.ArgumentOutOfRangeException>( () => grid=new Grid(nbrRow,nbrColumn));
        }

        [TestMethod]
        public void Grid_columnNegatif_ThrowsArgumentOutOfRangeException()
        {
            int nbrRow, nbrColumn;
            nbrRow = 10;
            nbrColumn = -6;
            Grid grid;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => grid=new Grid(nbrRow,nbrColumn));
        }

        [TestMethod]
        public void Grid_RowcolumnNegatif_ThrowsArgumentOutOfRangeException()
        {
            int nbrRow, nbrColumn;
            nbrRow = -8;
            nbrColumn = -13;
            Grid grid;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => grid=new Grid(nbrRow, nbrColumn));
        }
        
        [TestMethod]
        public void Grid_OneCellule()
        {
            Grid grid;
            grid = new Grid(1,1);
            grid.CreateGrid(); 
            grid.NextGeneration();
            Assert.IsTrue(grid.CelluleGrid[0][0].Etat == EtatCell.morte); 
        }

        [TestMethod]
        public void CreateGrid_NbreCelluleTotal_GridCreated()
        {
            Grid grid;
            grid = new Grid(4,7);
            grid.CreateGrid();
            int CellTotalNbr,AliveCellNbr=0, DeadCellNbr = 0;
            CellTotalNbr = grid.NbreLine * grid.NbreColumn; 
            foreach(List<Cellule> Column in grid.CelluleGrid)
            {
                foreach(Cellule Cell in Column)
                {
                    if(Cell.Etat == EtatCell.viante)
                        AliveCellNbr++;
                    else
                    {
                        if(Cell.Etat == EtatCell.morte)
                            DeadCellNbr++;
                    }
                    
                }
            }
            Assert.AreEqual(CellTotalNbr, DeadCellNbr + AliveCellNbr); 
        }




       
    }
}
