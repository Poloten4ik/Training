using System;

namespace ConsoleApp3.scripts
{
    public class SortingConst
    {
        private int[] sortingNum;

        public SortingConst(int[] arr)
        {
            sortingNum = arr;
        }

        public int[] OrderedAsc()
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

        public int[] OrderedDesc()
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
