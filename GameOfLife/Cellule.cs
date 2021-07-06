using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cellule
    {
        public int  Row { get; set; }
        public int Column { get; set; }
        public EtatCell Etat { get; set; }
        public Cellule(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }
        public Cellule(int row,int column,EtatCell etat)
        {
            this.Row = row;
            this.Column = column;
            this.Etat = etat;
        }
        public int AliveNeighbors(Grid grid)
        {   
           int AliveNeighbors = 0;
           if(this.Row+1<grid.NbreLine)
           {
                if(grid.CelluleGrid[this.Row+1][this.Column].Etat == EtatCell.viante)
                    AliveNeighbors++;

                if((this.Column>0)&&(grid.CelluleGrid[this.Row+1][this.Column-1].Etat == EtatCell.viante))           
                    AliveNeighbors++;

                if((this.Column+1<grid.NbreColumn)&&(grid.CelluleGrid[this.Row+1][this.Column+1].Etat == EtatCell.viante))              
                    AliveNeighbors++;
           }

           if(this.Row>0)
           {               
                if(grid.CelluleGrid[this.Row-1][this.Column].Etat == EtatCell.viante)           
                    AliveNeighbors++;

                if((this.Column>0)&&(grid.CelluleGrid[this.Row-1][this.Column-1].Etat == EtatCell.viante))
                    AliveNeighbors++;
           
                if((this.Column+1<grid.NbreColumn)&&(grid.CelluleGrid[this.Row-1][this.Column+1].Etat == EtatCell.viante))
                    AliveNeighbors++;
           }

           if((this.Column>0)&&(grid.CelluleGrid[this.Row][this.Column+1].Etat == EtatCell.viante))
              AliveNeighbors++;
           
           if((this.Column+1<grid.NbreColumn)&&(grid.CelluleGrid[this.Row][this.Column-1].Etat == EtatCell.viante))
               AliveNeighbors++;
           
           return AliveNeighbors;
        }
    }
}
