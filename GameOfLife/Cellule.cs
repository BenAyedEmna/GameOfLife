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
            if (row<0)
            {
                if(column<0)
                    throw new ArgumentOutOfRangeException("les cordonnes d'une cellule doient etre positives");
                else
                    throw new ArgumentOutOfRangeException("la ligne de la cellule doit etre positive");
            }
            if (column<0)
                throw new ArgumentOutOfRangeException("la colonne de la cellule doit etre positive");
            this._row = row;
            this._column = column;
            this._etat = etat;
        }
        public int AliveNeighbors(Grid grid)
        {
            //int aliveNeighbours = 0;

            //for (int i = -1; i <= 1; i++)

            //    for (int j = -1; j <= 1; j++)
            //        if(grid.CelluleGrid[grid.NbreColumn+i][grid.NbreLine+j].IsAlive())
            //            aliveNeighbours += 1; 
            //return aliveNeighbours; 

            int AliveNeighbors = 0;
            if (this._row + 1 < grid.NbreLine)
            {
                if (grid.CelluleGrid[this._column][this._row + 1].IsAlive())
                    AliveNeighbors++;

                if ((this._column > 0) && (grid.CelluleGrid[this._column - 1][this._row + 1].IsAlive()))
                    AliveNeighbors++;

                if ((this._column + 1 < grid.NbreColumn) && (grid.CelluleGrid[this._column + 1][this._row + 1].IsAlive()))
                    AliveNeighbors++;
            }

            if (this._row > 0)
            {
                if (grid.CelluleGrid[this._column][this._row - 1].IsAlive())
                    AliveNeighbors++;

                if ((this._column > 0) && (grid.CelluleGrid[this._column - 1][this._row - 1].IsAlive()))
                    AliveNeighbors++;

                if ((this._column + 1 < grid.NbreColumn) && (grid.CelluleGrid[this._column + 1][this._row - 1].IsAlive()))
                    AliveNeighbors++;
            }

            if ((this._column + 1 < grid.NbreColumn) && (grid.CelluleGrid[this._column + 1][this._row].IsAlive()))
                AliveNeighbors++;

            if ((this._column > 0) && (grid.CelluleGrid[this._column - 1][this._row].IsAlive()))
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
