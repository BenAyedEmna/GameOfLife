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
        public Grid Grid { get; set; }
        public int AliveNeighbors()
        {   
           int AliveNeighbors = 0;
           if(this.Grid.CelluleGrid[this.Row+1][this.Column].Etat==EtatCell.viante)
           {
                AliveNeighbors++;
           }
           if(this.Grid.CelluleGrid[this.Row-1][this.Column].Etat == EtatCell.viante)
           {
                AliveNeighbors++;
           }
           if(this.Grid.CelluleGrid[this.Row][this.Column+1].Etat == EtatCell.viante)
           {
              AliveNeighbors++;
           }
           if(this.Grid.CelluleGrid[this.Row][this.Column-1].Etat == EtatCell.viante)
           {
               AliveNeighbors++;
           }
           if(this.Grid.CelluleGrid[this.Row+1][this.Column+1].Etat == EtatCell.viante)
           {
               AliveNeighbors++;
           }
           if(this.Grid.CelluleGrid[this.Row-1][this.Column-1].Etat == EtatCell.viante)
           {
               AliveNeighbors++;
           }
           if(this.Grid.CelluleGrid[this.Row-1][this.Column+1].Etat == EtatCell.viante)
           {
               AliveNeighbors++;
           }
           if(this.Grid.CelluleGrid[this.Row+1][this.Column-1].Etat == EtatCell.viante)
           {
               AliveNeighbors++;
           }
           return AliveNeighbors;
        }
    }
}
