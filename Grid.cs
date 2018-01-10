using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class Grid
    {
        protected Cell[,] cells;
        public int Width { set; get; }
        public int Height { set; get; }
        public bool periodic;
        public int curPosX;
        public int curPosY;

        public Grid(int width, int height, bool periodic)
        {
            this.Width = width;
            this.Height = height;
            this.periodic = periodic;
            
            this.cells = new Cell[height, width];

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    this.cells[i, j] = new Cell();
                }
            }

          
            this.ResetCurrentCellPosition();

            do
            {

                this.CurrentCell.Neighbors = this.NeighborhoodOfCurrentCell;
            } while (this.Next());
        }

        public Cell CurrentCell
        {
            get
            {
                return this.GetCell(this.curPosX, this.curPosY);
            }
        }

        public static int MathMod(int a, int b)
        {
            return ((a % b) + b) % b;
        }

        public Cell GetCell(int x, int y)
        {                     
            if (x < 0 || x >= this.Width || y < 0 || y >= this.Height)
            {
                // Periodic boundary condition
                if ( this.periodic )
                {
                    return this.cells[MathMod(y, this.Height), MathMod(x, this.Width)];

                }

                // Absorbent boundary condition
                else
                {
                    return new Cell();
                }
            }

            else
            {
                return this.cells[y,x];
            }
        }

        public void ResetCurrentCellPosition()
        {
            this.curPosX = 0;
            this.curPosY = 0;
        }

        public void SetCurrentCellPosition(int x, int y)
        {
            this.curPosX = x;
            this.curPosY = y;
        }

        
        public bool Next()
        {
         
            if (this.curPosX == this.Width - 1 && this.curPosY == this.Height - 1)
            {
                return false;                
            }

         
            if (this.curPosX == this.Width - 1)
            {
                this.curPosX = 0;
                this.curPosY += 1;
            }

            else
            {
                this.curPosX += 1;
            }

            return true;
        }

    
        public void CopyNewIDtoID()
        {
            for (int i = 0; i < this.Height; ++i)
            {
                for (int j = 0; j < this.Width; ++j)
                {
                    this.cells[i, j].ID = this.cells[i, j].NewID;
                }
            }

            
        }

      
        
        public Cell Neighbor1
        {
            get
            {
                return this.GetNeighbor(0, 1);
            }
        }

        public Cell Neighbor2
        {
            get
            {
                return this.GetNeighbor(1, 1);
            }
        }

        public Cell Neighbor3
        {
            get
            {
                return this.GetNeighbor(1, 0);
            }
        }

        public Cell Neighbor4
        {
            get
            {
                return this.GetNeighbor(1, -1);
            }
        }

        public Cell Neighbor5
        {
            get
            {
                return this.GetNeighbor(0, -1);
            }
        }

        public Cell Neighbor6
        {
            get
            {
                return this.GetNeighbor(-1, -1);
            }
        }

        public Cell Neighbor7
        {
            get
            {
                return this.GetNeighbor(-1, 0);
            }
        }

        public Cell Neighbor8
        {
            get
            {
                return this.GetNeighbor(-1, 1);
            }
        }

        protected Cell GetNeighbor(int diffX, int diffY)
        {
            return this.GetCell(this.curPosX + diffX, this.curPosY + diffY);
        }

        public Cell[] NeighborhoodOfCurrentCell
        {
            get
            {
                List<Cell> cells = new List<Cell>();

                cells.Add(this.Neighbor1);
                cells.Add(this.Neighbor2);
                cells.Add(this.Neighbor3);
                cells.Add(this.Neighbor4);
                cells.Add(this.Neighbor5);
                cells.Add(this.Neighbor6);
                cells.Add(this.Neighbor7);
                cells.Add(this.Neighbor8);

                return cells.ToArray();
            }
        }
    }
}
