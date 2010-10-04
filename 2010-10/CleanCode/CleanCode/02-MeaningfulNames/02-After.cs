using System.Collections.Generic;

namespace CleanCode
{
    public partial class MeaningfulNames
    {
        public List<Cell> GetFlaggedCells()
        {
            List<Cell> flaggedCells = new List<Cell>();
            foreach (Cell cell in gameBoard)
                if (cell.IsFlagged())
                    flaggedCells.Add(cell);
            return flaggedCells;
        }
    }
}