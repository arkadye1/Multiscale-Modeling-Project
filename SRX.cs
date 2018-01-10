using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class SRX : Functions 
    {
        public MainForm mf;
        

        public void AddEnergyBound(double energy)
        {
           
            this.grid.ResetCurrentCellPosition();

            do
            {

                if (this.IsNotRecrystalizedCellOnBoundary(this.grid.CurrentCell))
                {
                    this.grid.CurrentCell.Energy = energy;
                }
                else {
                    this.grid.CurrentCell.Energy = 1;
                }
            } while (this.grid.Next());
        }

        public void AddEnergy(double energy)
        {

            this.grid.ResetCurrentCellPosition();

            do
            {

                if (this.IsNotRecrystalized(this.grid.CurrentCell))
                {
                    this.grid.CurrentCell.Energy = energy;
                }
            } while (this.grid.Next());
        }

        public void AddNucleationsOnBound(int nucleationsNumber)
        {
           
            int[] notUsedIds = this.GetNotUsedIds().Take(nucleationsNumber).ToArray();
            Cell[] cellsForNucleations = this.GetNotRecystalizedCells().Take(nucleationsNumber).ToArray();
            

            for (int i = 0; i < nucleationsNumber && i < notUsedIds.Length && i < cellsForNucleations.Length; ++i)
            {
                cellsForNucleations[i].ID = notUsedIds[i];
                cellsForNucleations[i].NewID = notUsedIds[i];
                cellsForNucleations[i].Recrystalized = true;
                cellsForNucleations[i].Energy = 1;
            }
        }
        public void AddNucleations(int nucleationsNumber)
        {

            int[] notUsedIds = this.GetNotUsedIds().Take(nucleationsNumber).ToArray();
            Cell[] cellsForNucleations = this.GetNotRecystalizedCells2().Take(nucleationsNumber).ToArray();


            for (int i = 0; i < nucleationsNumber && i < notUsedIds.Length && i < cellsForNucleations.Length; ++i)
            {
                cellsForNucleations[i].ID = notUsedIds[i];
                cellsForNucleations[i].NewID = notUsedIds[i];
                cellsForNucleations[i].Recrystalized = true;
                cellsForNucleations[i].Energy =1;
            }
        }


        public void Step()
        {
            foreach (Cell c in this.GetCellsToProcess())
            {
                Cell[] recrystalizedNeighboors = c.MoorNeighborhood.Where(i => i.ID > 1 && i.Recrystalized).ToArray();

                double e1 = c.MoorNeighborhood.Count(i => i.ID != c.ID) + c.Energy;
                int newId = recrystalizedNeighboors[Rand.Next(recrystalizedNeighboors.Length)].ID;
                double e2 = c.MoorNeighborhood.Count(i => i.ID != newId);

                if (e2 - e1 <= 1)
                {
                    c.ID = newId;
                    c.NewID = newId;
                    c.Recrystalized = true;
                    c.Energy = 0;
                }
            }
        }
 

        private IEnumerable<Cell> GetNotRecystalizedCells()
        {
            List<Cell> cells = new List<Cell>();

            this.grid.ResetCurrentCellPosition();

            do
            {
         
                if (this.IsNotRecrystalizedCellOnBoundary(this.grid.CurrentCell))
                {
                    cells.Add(this.grid.CurrentCell);
                }
            } while (this.grid.Next());

            return cells.OrderBy(i => Rand.Next());
        }

        private IEnumerable<Cell> GetNotRecystalizedCells2()
        {
            List<Cell> cells = new List<Cell>();

            this.grid.ResetCurrentCellPosition();

            do
            {

                if (this.IsNotRecrystalized(this.grid.CurrentCell))
                {
                    cells.Add(this.grid.CurrentCell);
                }
            } while (this.grid.Next());

            return cells.OrderBy(i => Rand.Next());
        }



        private bool IsNotRecrystalizedCellOnBoundary(Cell cell)
        {
            return cell.ID > 1 && !cell.Recrystalized && cell.MoorNeighborhood.Count(i => i.ID != cell.ID && !i.Recrystalized) > 0;
        }


        private bool IsNotRecrystalized(Cell cell) {
            return cell.ID > 1 && !cell.Recrystalized;
        }

        private IEnumerable<Cell> GetCellsToProcess()
        {
            List<Cell> cells = new List<Cell>();

            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.IsNotRecrystalizedCellWithRecrystalizedNeighboor(this.grid.CurrentCell))
                {
                    cells.Add(this.grid.CurrentCell);
                }
            } while (this.grid.Next());

            return cells.OrderBy(i => Rand.Next());
        }

        private bool IsNotRecrystalizedCellWithRecrystalizedNeighboor(Cell cell)
        {
            return cell.ID > 1 && !cell.Recrystalized && cell.MoorNeighborhood.Count(i => i.Recrystalized) > 0;
        }
    }
}
