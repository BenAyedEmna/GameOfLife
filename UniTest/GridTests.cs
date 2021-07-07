using System; 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife; 

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

    }
}
