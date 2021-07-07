using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Grid
    {
        public int NbreLine { get; }
        public int NbreColumn { get; }
        public List<List<Cellule>> CelluleGrid { get; set; }

        public Grid(int Line, int Column)
        {
            if (Line < 0)
            {
                if (Column < 0)
                    throw new ArgumentOutOfRangeException("le nombre de lignes et de colonnes d'une grille doient etre positif");
                else
                    throw new ArgumentOutOfRangeException("le nombre de lignes d'une grille doit etre poositif");
            }
            if (Column < 0)
                throw new ArgumentOutOfRangeException("le nombre de colonnes d'une grille doit etre positif");
            this.NbreLine = Line;
            this.NbreColumn = Column;
        }

        public void CreateGrid()
        {
            this.CelluleGrid = new List<List<Cellule>>();
            int i, j;
            Random rnd = new Random();
            List<Cellule> CellList;
            CellList = new List<Cellule>();
            Cellule Cell;
            for(i=0;i<this.NbreColumn;i++)
            {
                CellList = new List<Cellule>();
                this.CelluleGrid.Add(CellList);
                for (j = 0; j < this.NbreLine; j++)
                {
                    Cell = new Cellule(j,i);
                    Cell.Etat = (EtatCell)rnd.Next(2);
                    CellList.Add(Cell);
                }
            }
        }
        public void NextGeneration()
        {
            int AliveNeighbors;
            foreach (List<Cellule> Column in this.CelluleGrid)
            {
                foreach (Cellule Cell in Column)
                {
                    AliveNeighbors = Cell.AliveNeighbors(this);
                    if ((AliveNeighbors==3) && (Cell.Etat != EtatCell.viante))
                    {
                        Cell.Etat = EtatCell.viante;
                    }
                    if((AliveNeighbors<2) || (AliveNeighbors > 3) && (Cell.Etat != EtatCell.morte))
                    {
                        Cell.Etat = EtatCell.morte;
                    }
                }

            }

        }
    }
}        