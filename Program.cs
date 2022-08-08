using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompairLine_Problem
{
    public static class Program
    {
        private static int x1;
        private static int x2;
        private static int y2;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter X co-ordinates: (x1 and y1)");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Y co-ordinates: (x2 and y2)");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            CalculateLength.LengthCalculation(x1, y1, x2, y2);

            Console.WriteLine("To Check Both Line Equals or not by Equals method");
            Console.WriteLine("Enter start and end points of First line: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            EqualityCheck.LenghthEqualityCheck(a1, b1, a2, b2);

            Console.WriteLine("To Compare Both Line by CompareTo method");
            Console.WriteLine("Please Enter the first line coordinates");
            int l1 = Convert.ToInt32(Console.ReadLine());
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter start and end points of Second line: ");
            int l2 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            TwoLineComparison.CheckTwoLineComparison(l1, m1, l2, m2);
        }
    }
}
