﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineLengthEquality
    {
        
        public static void Check()
        {
            Console.WriteLine("Enter the (x,y) coordinates of the first point of line 1:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of line 1:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the first point of line 2:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point of line 2:");
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("The length of first line = " + length1);
            Console.WriteLine("The length of Second Line =" +length2);
            int comparisonResult = Convert.ToInt32 (length1.Equals(length2));

            if (comparisonResult == 1)
            {
                Console.WriteLine("Line 1 and Line2 are equal");
            }
            else
            {
                Console.WriteLine("Line 1 and Line2 are not equal");
            }



        }

    }       
}
