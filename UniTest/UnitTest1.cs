using System; 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Grid_RowNegatif_ThrowsArgumentOutOfRangeException()
        {
            int nbrRow,nbrColumn;
            nbrRow = -3;
            nbrColumn = 6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>( () => Grid.Grid(nbrRow,nbrColumn));
        }

        [TestMethod]
        public void Grid_columnNegatif_ThrowsArgumentOutOfRangeException()
        {
            int nbrRow, nbrColumn;
            nbrRow = 10;
            nbrColumn = -6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Grid.Grid(nbrRow,nbrColumn));
        }

        [TestMethod]
        public void Grid_RowcolumnNegatif_ThrowsArgumentOutOfRangeException()
        {
            int nbrRow, nbrColumn;
            nbrRow = -8;
            nbrColumn = -13;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Grid.Grid(nbrRow, nbrColumn));
        }

        [TestMethod]
        public void CreateGrid_RowColumnNegatif_ThrowsArgumentOutOfRangeException()
        {
            Grid grid;
            grid.NbreLine = -2;
            grid.NbreColumn = -6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Grid.CreateGrid()); 
        }

        [TestMethod]
        public void CreateGrid_RowNegatif_ThrowsArgumentOutOfRangeException()
        {
            Grid grid;
            grid.NbreLine = -2;
            grid.NbreColumn = 6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Grid.CreateGrid());
        }

        [TestMethod]
        public void CreateGrid_ColumnNegatif_ThrowsArgumentOutOfRangeException()
        {
           
            Grid grid; 
            grid.NbreLine= 2;
            grid.NbreColumn = -6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Grid.CreateGrid());
        }

    }
}
