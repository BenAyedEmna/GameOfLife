using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Generation
    {
        //public Grid grid { get; set; }
        //public Generation(Grid grille)
        //{
        //    this.grid = grille; 
        //}
        public void NextGeneration(Grid grid)
        {
            int aliveNeighbors;
            foreach (List<Cellule> Column in grid.CelluleGrid)
            {
                foreach (Cellule Cell in Column)
                {
                    aliveNeighbors = Cell.AliveNeighbors(grid);
                    if ((aliveNeighbors == 3) && (Cell.IsDead()))
                        Cell.BecomeAlive();
                    else
                    {
                        if (((aliveNeighbors < 2) || (aliveNeighbors > 3)) && (Cell.IsAlive()))
                            Cell.BecomeDead();
                    }
                }
            }
        }
    }
}
