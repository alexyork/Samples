using System.Collections.Generic;

namespace CleanCode
{
    public partial class MeaningfulNames
    {
        public List<int[]> Get()
        {
            List<int[]> list1 = new List<int[]>();
            foreach (int[] x in theList)
                if (x[0] == 4)
                    list1.Add(x);
            return list1;
        }
    }
}



















// 1) What kind of things are in theList?
// 2) What is the significance of the zero-th item?
// 3) What is the significance of the constant 4?
// 4) How would I use the list being returned?