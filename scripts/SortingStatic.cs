using System;

namespace ConsoleApp3.scripts
{

    public static class SortingStatic
    {
        public static int[] OrderedAsc(int[] arr)
        {
            int temp;
            var result = CopyArray(arr);
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

        public static int[] OrderedDesc(int[] arr)
        {
            int temp;
            var result = CopyArray(arr);
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

        private static int[] CopyArray(int[] arr)
        {
            var result = new int[arr.Length];

            for (var i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i];
            }

            return result;
        }
    }
}

