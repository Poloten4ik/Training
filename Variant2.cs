using System;

public class Variant2
{
	public int[] OrderedAsc(int[] x)
	{
		int result;
		for ( int i =0; i < x.Length; i++)
        {
			for ( int j = 0; j < x.Length; j++)
            {
				if ( x[i] < x[j])
                {
					result = x[i];
					x[i] = x[j];
					x[j] = result;
                }
            }
        }
		return x;
	}
	public int[] OrderedDesc(int[] x)
    {
		int result;
		for (int i = 0; i < x.Length; i++)
		{
			for (int j = 0; j < x.Length; j++)
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
