using System.Collections.Generic;


namespace GameOfLife
{
    public class Generation
    {

        public Grid NextGeneration(Grid grid)
        {
            int Row, Column, AliveNeighbors;
            Grid NewGrid = new Grid(grid.NbreLine, grid.NbreColumn,new RandomGenerator());
            NewGrid.CreateGrid(); 
            for (Column = 0; Column < grid.NbreColumn; Column++)
            {
                for (Row = 0; Row < grid.NbreLine; Row++)
                {
                    AliveNeighbors = 0;
                    AliveNeighbors = grid.CelluleGrid[Column][Row].AliveNeighbors(grid); 

                    if ((AliveNeighbors == 3) && (NewGrid.CelluleGrid[Column][Row].IsDead()))
                        NewGrid.CelluleGrid[Column][Row].BecomeAlive();
                    else
                    {
                        if ((AliveNeighbors < 2) && (NewGrid.CelluleGrid[Column][Row].IsAlive()))
                            NewGrid.CelluleGrid[Column][Row].BecomeDead() ;
                        else
                        {
                            if ((AliveNeighbors > 3) && (NewGrid.CelluleGrid[Column][Row].IsAlive()))
                                NewGrid.CelluleGrid[Column][Row].BecomeDead();
                            else
                            if (AliveNeighbors == 2)
                                NewGrid.CelluleGrid[Column][Row]=grid.CelluleGrid[Column][Row];
                        }
                    }            
                }
            }
            return NewGrid;
        }
    }
}









