using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace grain_growth
{
   
    public class Count
    {
        protected Dictionary<int, int> counter;

        public Count()
        {
            this.counter = new Dictionary<int, int>();
        }

        public void AddCell(Cell cell)
        {
            // 0 - null, 1 - inclusion 
            if ( cell.ID > 1 && !cell.Selected )
            {
                if ( !this.counter.ContainsKey(cell.ID) )
                {
                    this.counter[cell.ID] = 0;
                }

                ++this.counter[cell.ID];
            }
        }

        public void AddCells(IEnumerable<Cell> cells)
        {
            foreach (Cell c in cells)
            {
                this.AddCell(c);
            }
        }

        public CountReturn MostCommonID
        {
            get
            {
                if (this.counter.Count > 0)
                {
                   
                    KeyValuePair<int, int> max = this.counter.Aggregate((l, r) => l.Value > r.Value ? l : r);

                    return new CountReturn
                    {
                        ID = max.Key,
                        Count = max.Value
                    };
                }

                return null;
            }
        }
    }
}
// http://stackoverflow.com/questions/2805703/good-way-to-get-the-key-of-the-highest-value-of-a-dictionary-in-c-sharp