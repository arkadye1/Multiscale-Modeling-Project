using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class Functions
    {
        private const int MAX_GRAIN_ID = 150; 
        public int Width { set; get; }
        public int Height { set; get; }
        protected Grid grid;
        protected int? idForSelectedGrain;

        public Grid Grid
        {
            get
            {
                return this.grid;
            }

            set
            {
                this.grid = value;
                this.Width = this.grid.Width;
                this.Height = this.grid.Height;
            }
        }
        
        public int[] GetNotUsedIds()
        {            
            bool[] usesArr = Enumerable.Repeat(false, MAX_GRAIN_ID).ToArray();

            usesArr[0] = true; 
            usesArr[1] = true;

            this.grid.ResetCurrentCellPosition();
    
            do
            {
                usesArr[this.grid.CurrentCell.ID] = true;

            } while (this.grid.Next());

            List<int> ret = new List<int>();

            for (int i = 0; i < usesArr.Length; ++i)
            {
                if ( usesArr[i] == false)
                    ret.Add(i);
            }

            return ret.ToArray();
        }

        public void StartSelectGrains(bool IDchange)
        {
            if (IDchange)
            {
                this.idForSelectedGrain = this.GetNotUsedIds().First();
            }
            else
            {
                this.idForSelectedGrain = null;
            }

            this.grid.ResetCurrentCellPosition();

            do
            {
                this.grid.CurrentCell.Selected = false;
            } while (this.grid.Next());
        }

        public void SelectGrain(int x, int y)
        {
            int selectedId = this.grid.GetCell(x, y).ID;

            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.grid.CurrentCell.ID == selectedId)
                {
                    this.grid.CurrentCell.Selected = true;

                    if (this.idForSelectedGrain.HasValue)
                    {
                        this.grid.CurrentCell.ID = this.idForSelectedGrain.Value;
                        this.grid.CurrentCell.NewID = this.idForSelectedGrain.Value;
                    }
                }
            } while (this.grid.Next());
        }
    
    
        public void EndSelectGrains()
        {
            this.grid.ResetCurrentCellPosition();

            do
            {
                if (!this.grid.CurrentCell.Selected && this.grid.CurrentCell.ID > 1)
                {
                    this.grid.CurrentCell.ID = 0;
                    this.grid.CurrentCell.NewID = 0;
                }
            } while (this.grid.Next());
        }

        public void SelectGrainBoundary(int x, int y)
        {
            int selectedId = this.grid.GetCell(x, y).ID;

            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.grid.CurrentCell.ID == selectedId)
                {
                    this.grid.CurrentCell.Selected = true;

                    if (this.idForSelectedGrain.HasValue)
                    {
                        this.grid.CurrentCell.ID = this.idForSelectedGrain.Value;
                        this.grid.CurrentCell.NewID = this.idForSelectedGrain.Value;
                    }
                }
            } while (this.grid.Next());


        }

        
       
        public void AddSquareInclusion(int x0, int y0, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    this.AddInclusion(x0 + i, y0 + j);
                }
            }
        }

        // http://stackoverflow.com/questions/1201200/fast-algorithm-for-drawing-filled-circles 
      
        public void AddCircleInclusion(int x0, int y0, int radius)
        {
            int x = radius;
            int y = 0;
            int xChange = 1 - (radius << 1);
            int yChange = 0;
            int radiusError = 0;

            while (x >= y)
            {
                for (int i = x0 - x; i <= x0 + x; i++)
                {
                    this.AddInclusion(i, y0 + y);
                    this.AddInclusion(i, y0 - y);
                }
                for (int i = x0 - y; i <= x0 + y; i++)
                {
                    this.AddInclusion(i, y0 + x);
                    this.AddInclusion(i, y0 - x);
                }

                y++;
                radiusError += yChange;
                yChange += 2;
                if (((radiusError << 1) + xChange) > 0)
                {
                    x--;
                    radiusError += xChange;
                    xChange += 2;
                }
            }
        }

       
        protected void AddInclusion(int x, int y)
        {
            Cell c = this.grid.GetCell(x, y);
            c.ID = 1;
            c.NewID = 1;
        }

       
    }
}
