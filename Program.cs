using System;
using System.Globalization;

namespace ConsoleApp2
{
    
     
    public class Program
    {
        public static void Main(string[] args)
        {
            Sorting numSorting = new Sorting();

            int[] x = new int[] { 5, 6, 4, 7, 2, 3, 1, 0, 10, 8, 9 };
            int[] arrAsc = numSorting.OrderAsc(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(arrAsc[i]);
            }
            int[] arrDesc = numSorting.OrderDesc(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(arrDesc[i]);
            }
            Variant2 variant2 = new Variant2();
            variant2.OrderedAsc(x);
        }
        
    }

   

}
