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
    public class CelulleTest
    {
        [TestMethod]
        public void Cellule_RowNegatif_ThrowsArgumentOutOfRangeException()
        {
            var row = -4;
            var column = 6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Cellule(row,column, EtatCell.viante));
        }

        [TestMethod]
        public void Cellule_ColumnNegatif_ThrowsArgumentOutOfRangeException()
        {
            var row = 4;
            var column = -6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Cellule(row, column, EtatCell.viante));
        }

        [TestMethod]
        public void Cellule_RowColumnNegatif_ThrowsArgumentOutOfRangeException()
        {
            var row = -4;
            var column = -6;
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Cellule(row, column, EtatCell.viante));
        }

    }
}
