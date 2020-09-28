using System;
namespace ConsoleApp3.scripts
{
    public class Sorting
    {
        public Sorting(int[] arr)
        {
            sortingNum = arr;
        }
        private int[] sortingNum;
 
        public int[] OrderAsc(int[] x)
        {
            int result;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        result = x[i];
                        x[i] = x[j];
                        x[j] = result;
                    }
                }
            }
            return x;
        }
        public int[] OrderDesc(int[] x)
        {
            int result;
            for (int i = 0; i < x.Length; i++)
            {

                for (int j = i + 1; j < x.Length; j++)
                {

                    if (x[i] < x[j])
                    {
                        result = x[i];
                        x[i] = x[j];
                        x[j] = result;
                    }
                }
            }
            return x;
        }

        public int[] OrderAsc()
        {
            int temp;
            var result = CopyArray();

            for (int i = 0; i < sortingNum.Length; i++)
            {
                for (int j = 0; j < sortingNum.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }

        public int[] OrderDesc()
        {
            int temp;
            var result = CopyArray();
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }

        private int[] CopyArray()
        {
            var result = new int[sortingNum.Length];
            for (int i = 0; i < sortingNum.Length; i++)
            {
                result[i] = sortingNum[i];
            }
            return result;
        }
    }
}
