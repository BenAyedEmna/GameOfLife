using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cellule
    {
        private readonly int _row;
        private readonly int _column;
        private EtatCell _etat;

        public Cellule(int row, int column, EtatCell etat)
        {
            this._row = row;
            this._column = column;
            this._etat = etat;
        }
        public int AliveNeighbors(Grid grid)
        {
            int AliveNeighbors = 0;
            if (this._row + 1 < grid.NbreLine)
            {
                if (grid.CelluleGrid[this._row + 1][this._column].IsAlive())
                    AliveNeighbors++;

                if ((this._column > 0) && (grid.CelluleGrid[this._row + 1][this._column - 1].IsAlive()))
                    AliveNeighbors++;

                if ((this._column + 1 < grid.NbreColumn) && (grid.CelluleGrid[this._row + 1][this._column + 1].IsAlive()))
                    AliveNeighbors++;
            }

            if (this._row > 0)
            {
                if (grid.CelluleGrid[this._row - 1][this._column].IsAlive())
                    AliveNeighbors++;

                if ((this._column > 0) && (grid.CelluleGrid[this._row - 1][this._column - 1].IsAlive()))
                    AliveNeighbors++;

                if ((this._column + 1 < grid.NbreColumn) && (grid.CelluleGrid[this._row - 1][this._column + 1].IsAlive()))
                    AliveNeighbors++;
            }

            if ((this._column > 0) && (grid.CelluleGrid[this._row][this._column + 1].IsAlive()))
                AliveNeighbors++;

            if ((this._column + 1 < grid.NbreColumn) && (grid.CelluleGrid[this._row][this._column - 1].IsAlive()))
                AliveNeighbors++;

            return AliveNeighbors;
        }

        public void BecomeAlive()
        {
            this._etat = EtatCell.viante;
        }

        public void BecomeDead()
        {
            this._etat = EtatCell.morte;
        }

        public bool IsDead()
        {
            return this._etat == EtatCell.morte;
        }

        public bool IsAlive()
        {
            return this._etat == EtatCell.viante;
        }
    }
}
