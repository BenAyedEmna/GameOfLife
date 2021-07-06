using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{

    class Generation
    {
        Grid Grid; 
        public void NextGeneration()
        {
            int i,j;
            int AliveNeighbors ; 
            for(i=0;i<this.Grid.NbreColumn;i++)
            {
                for(j=0;j<this.Grid.NbreLine;i++)
                {
                    AliveNeighbors = this.Grid.CelluleGrid[i][j].AliveNeighbors(); 
                    if(AliveNeighbors==3)
                    {
                        this.Grid.CelluleGrid[i][j].Etat = EtatCell.viante;
                    }
                    if((AliveNeighbors < 2) || (AliveNeighbors > 3))
                    {
                        this.Grid.CelluleGrid[i][j].Etat = EtatCell.morte;
                    }
                }

            }
            
            

        }

    }
}
