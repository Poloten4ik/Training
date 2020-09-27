using System;
using System.Globalization;
using ConsoleApp3.scripts;

namespace ConsoleApp2
{        
    public class Program
    {
        public static void Main(string[] args)
        {
            Sorting numSorting = new Sorting();

            var x = new int[] { 5, 6, 4, 7, 2, 3, 1, 0, 10, 8, 9 };
            var arrAsc = numSorting.OrderAsc(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(arrAsc[i]);
            }
            var arrDesc = numSorting.OrderDesc(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(arrDesc[i]);
            }

            SortingConst variant2 = new SortingConst(x);
            var orderedAsc = variant2.OrderedAsc();
            var orderedDesc = variant2.OrderedDesc();



            var orderedStaticAsc = SortingStatic.OrderedAsc(x);
            var orderedStaticDesc = SortingStatic.OrderedDesc(x);
        }

    }

   

}
