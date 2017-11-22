using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class Cell
    {

        /// 0  - null,  1  - inclusion. >1 - grain
        public int ID { set; get; }

        /// For store new id
        public int NewID { set; get; }
       
        public bool Selected { set; get; }

        public bool Filled { set; get; }


        /// Neighbors starts N->NW->W
        public Cell[] Neighbors { set; get; }

        public Cell() : this(0)
        {
            ;
        }

        public Cell(int id)
        {
            this.ID = id;
        }


// #####################################################
        public Cell Neighbor1
        {
            get { return this.Neighbors[0]; }
        }

        public Cell Neighbor2
        {
            get { return this.Neighbors[1]; }
        }

        public Cell Neighbor3
        {
            get { return this.Neighbors[2]; }
        }

        public Cell Neighbor4
        {
            get { return this.Neighbors[3]; }
        }

        public Cell Neighbor5
        {
            get { return this.Neighbors[4]; }
        }

        public Cell Neighbor6
        {
            get { return this.Neighbors[5]; }
        }

        public Cell Neighbor7
        {
            get { return this.Neighbors[6]; }
        }

        public Cell Neighbor8
        {
            get { return this.Neighbors[7]; }
        }
        //################################################
        public IEnumerable<Cell> MoorNeighborhood
        {
            get { return this.Neighbors; }
        }

        public IEnumerable<Cell> VonNeumannNeighborhood
        {
            get { return new Cell[] {this.Neighbor1, this.Neighbor3, this.Neighbor5, this.Neighbor7 }; }
        }

    }
}
