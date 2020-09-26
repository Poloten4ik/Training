using System;
public class Sorting
{
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
}
