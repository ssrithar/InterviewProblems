using System.Text;

namespace LeetCode.Questions
{
    public class _2DArraySort
    {
        public _2DArraySort() 
        {
            //[[1,3],[2,6],[8,10],[15,18]]
            //[[1,4],[4,5]]

            var array = SetupMap();
            PrintArray(array);
            Array.Sort(array, (x, y) => x[0] - y[0]);
            PrintArray(array);
        }

        private int[][] SetupMap()
        {
            int[][] map = new int[4][];

            map[0] = new int[] { 2, 6 };
            map[1] = new int[] { 1, 3 };
            map[2] = new int[] { 8, 10 };
            map[3] = new int[] { 15, 18 };

            return map;
        }

        private void PrintArray(int[][] arrayToPrint)
        {
            StringBuilder sb = new StringBuilder("[");
            for (int i = 0; i <= arrayToPrint.GetUpperBound(0); i++)
            {
                sb.Append("[");
                for (int j = 0; j <= arrayToPrint[i].GetUpperBound(0); j++)
                {
                    sb.Append(arrayToPrint[i][j]);
                    if (j < arrayToPrint[i].GetUpperBound(0))
                    {
                        sb.Append(",");
                    }
                }
                sb.Append("]");

                if (i < arrayToPrint.GetUpperBound(0))
                {
                    sb.Append(",");
                }
            }
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
    }
}
