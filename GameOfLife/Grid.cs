using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Grid
    {
        private readonly IRandomGenerator _randomGenerator;
        public int NbreLine { get; }
        public int NbreColumn { get; }
        public List<List<Cellule>> CelluleGrid { get; set; }

        public Grid(int Line, int Column, IRandomGenerator randomGenerator)
        {
            if (Line < 0)
            {
                throw new ArgumentOutOfRangeException("le nombre de lignes d'une grille doit etre poositif");
            }

            if (Column < 0)
            {
                throw new ArgumentOutOfRangeException("le nombre de colonnes d'une grille doit etre positif");
            }

            _randomGenerator = randomGenerator;

            this.NbreLine = Line;
            this.NbreColumn = Column;
        }

        public void CreateGrid()
        {
            this.CelluleGrid = new List<List<Cellule>>();
            int i, j;
            List<Cellule> CellList;
            CellList = new List<Cellule>();
            Cellule Cell;
            for(i=0;i<this.NbreColumn;i++)
            {
                CellList = new List<Cellule>();
                this.CelluleGrid.Add(CellList);
                for (j = 0; j < this.NbreLine; j++)
                {
                    var initialState = _randomGenerator.GetRandomCellState();
                    Cell = new Cellule(j, i, initialState);
                    CellList.Add(Cell);
                }
            }
        }
        public void NextGeneration()
        {
            int aliveNeighbors;
            foreach (List<Cellule> Column in this.CelluleGrid)
            {
                foreach (Cellule Cell in Column)
                {
                    aliveNeighbors = Cell.AliveNeighbors(this);
                    if ((aliveNeighbors == 3) && (Cell.IsDead()))
                    {
                        Cell.BecomeAlive();
                    }
                    if ((aliveNeighbors<2) || (aliveNeighbors > 3) && (Cell.IsAlive()))
                    {
                        Cell.BecomeDead();
                    }
                }
            }
        }
    }
}        