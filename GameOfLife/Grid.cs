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

        public void CreateGrid()
        {
            int i,j; 
            for (i=0;i<this.NbreColumn;i++)
            {
                for (j=0;j<this.NbreLine;i++)
                {
                    CelluleGrid[i][j].Etat = EtatCell.morte;   
                }
            }
        }

    }
}
