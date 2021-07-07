using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;



namespace UniTest
{
    [TestClass]

    class CelulleTest
    {
        [TestMethod]
        public void Cellule_RowNegatif_ThrowsArgumentOutOfRangeException()
        {
            int Row, Column;
            Row = -4;
            Column = 6;
            Cellule Cell; 
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Cell=new Cellule(Row,Column));
        }

        [TestMethod]
        public void Cellule_ColumnNegatif_ThrowsArgumentOutOfRangeException()
        {
            int Row, Column;
            Row = 4;
            Column = -6;
            Cellule Cell; 
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Cell=new Cellule(Row, Column));
        }

        [TestMethod]
        public void Cellule_RowColumnNegatif_ThrowsArgumentOutOfRangeException()
        {
            int Row, Column;
            Row = -4;
            Column = -6;
            Cellule Cell;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => Cell = new Cellule(Row, Column));
        }

    }
}
