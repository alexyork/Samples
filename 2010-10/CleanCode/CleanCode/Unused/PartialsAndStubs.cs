using System.Collections.Generic;

namespace CleanCode
{
    public partial class MeaningfulNames
    {
        List<int[]> theList = new List<int[]>();
        List<Cell> gameBoard = new List<Cell>();
    }

    public class Cell
    {
        public bool IsFlagged()
        {
            return false;
        }
    }

    public partial class Comments
    {
        public const string HOURLY_FLAG = "";
        public Employee employee;
    }

    public partial class Employee
    {
        public const string HOURLY_FLAG = "";
        public List<string> Flags;
        public int Age;
    }
}