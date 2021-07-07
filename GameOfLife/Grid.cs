using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Grid
    {
        public int NbreLine { get; set; }
        public int NbreColumn { get; set; }
        public List<List<Cellule>> CelluleGrid { get; set; }

        public Grid(int Line,int Column)
        {
            if(Line<0)
            {
                if (Column<0)
                    throw new ArgumentOutOfRangeException("le nombre de lignes et de colonnes d'une grille doient etre positif");
                else
                    throw new ArgumentOutOfRangeException("le nombre de lignes d'une grille doit etre poositif");
            }
            if (Column<0)
                throw new ArgumentOutOfRangeException("le nombre de colonnes d'une grille doit etre positif");

            this.NbreLine = Line;
            this.NbreColumn = Column; 
        }

        public void CreateGrid()
        {
            if(this.NbreLine<0)
            {
                if (this.NbreColumn < 0)
                    throw new ArgumentOutOfRangeException("on ne peut pas creer une grille avec des dimensions negatives"); 
            }                   
            if(this.NbreColumn<0)
                throw new ArgumentOutOfRangeException("on ne peut pas creer une grille avec des dimensions negatives");

            this.CelluleGrid = new List<List<Cellule>>(); 
            int i,j;
            Random rnd = new Random();
            for (i=0;i<this.NbreColumn;i++)
            {
                this.CelluleGrid[i] = new List<Cellule>(); 
                for (j=0;j<this.NbreLine;i++)
                {
                    this.CelluleGrid[i][j] = new Cellule(j,i); 
                    this.CelluleGrid[i][j].Etat = (EtatCell)rnd.Next(2);   
                }
            }
        }

    }
}
