using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace grain_growth
{
    public class CA : Functions
    {
       
        public void AddRandomGrains(int number)
        {
            int[] notUsedIds = this.GetNotUsedIds();

            for (int i = 0; i < number; ++i)
            {
                if (i < notUsedIds.Length)
                {
                    Cell c;

                    // empty cell
                    do
                    {
                        c = this.grid.GetCell(Rand.Next(this.Width), Rand.Next(this.Height));
                    } while (c.ID != 0 || c.Selected);

                    c.ID = notUsedIds[i];
                }

                else
                {
                    
                    break;
                }
            }
        }

        
        public bool Step()
        {
            int changes = 0;

            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.grid.CurrentCell.ID == 0)
                {
                    if (this.Neighbor(this.grid.CurrentCell))
                    {
                        ++changes;
                    }
                }
            } while (this.grid.Next());

            if (changes > 0)
            {
                this.grid.CopyNewIDtoID();

                return true;
            }

            return false;
        }

        
        protected bool Neighbor(Cell c)
        {
            CountReturn cr = this.NeighborMostCommonCell(c);
            
            if (cr != null)
            {
                this.grid.CurrentCell.NewID = cr.ID;
                return true;
            }

            return false;
        }


        // most common cell 
        protected CountReturn NeighborMostCommonCell(Cell c)
        {
            Count counter = new Count();
          
            counter.AddCells(c.MoorNeighborhood);

            return counter.MostCommonID;
        }
    }
}
