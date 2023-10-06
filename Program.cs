namespace Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*            MinMax(1, 2, 3, 56, 23, 5);
            */
            int[] myArray = { 1, 2, 3 };
            int[] valuesToAdd = { 4, 5, 6 };

            int[] resultArray = InsertArray(myArray, valuesToAdd);

            Console.WriteLine("esas Array: " + string.Join(", ", myArray));
            Console.WriteLine("elave edilmis Array: " + string.Join(", ", resultArray));


        }

        #region task1
        public static void MinMax(params int[]arrcopy)
        {
            int min = arrcopy[0];
            int minindex = 0;
            int maxindex = 0;
            for (int i = 0; i < arrcopy.Length; i++)
            {
                if (arrcopy[i] < min)
                {
                    min = arrcopy[i];
                    minindex = i;
                }
            }
            Console.WriteLine("minimum=" + min);
            int max = arrcopy[0];
            for (int i = 0; i < arrcopy.Length; i++)
            {
                if (arrcopy[i] > max)
                {
                    max = arrcopy[i];
                    maxindex = i;
                }
            }
            arrcopy[maxindex] = min;
            arrcopy[minindex] = max;

            Console.WriteLine("max=" + max);
            foreach (int i in arrcopy)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
        #region task2 
        public static int[] InsertArray(int[] targetArray, params int[] valuesToInsert)
        {
            int newLength = targetArray.Length + valuesToInsert.Length;
            Array.Resize(ref targetArray, newLength);

            int startIndex = targetArray.Length - valuesToInsert.Length;
            for (int i = 0; i < valuesToInsert.Length; i++)
            {
                targetArray[startIndex + i] = valuesToInsert[i];
            }

            return targetArray;
        }

        #endregion

    }
}