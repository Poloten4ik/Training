using System;
using System.Globalization;
using ConsoleApp3.scripts;

namespace ConsoleApp2
{        
    public class Program
    {
        public static void Main(string[] args)
        {
            var x = new int[] { 5, 6, 4, 7, 2, 3, 1, 0, 10, 8, 9 };
            var numSorting = new Sorting(x);

            var arrAsc = numSorting.OrderAsc();
            var orderedAsc = numSorting.OrderDesc(x);
            
            var arrDesc = numSorting.OrderDesc();
            var orderedDesc = numSorting.OrderDesc(x); 
        }
    }
}
