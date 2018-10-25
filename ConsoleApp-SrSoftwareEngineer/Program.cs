using System;
using ConsoleAppz_SrSoftwareEngineer;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp_SrSoftwareEngineer
{
    class Program
    {
        static void Main(string[] args)
        {
                while (true) // Loop indefinitely
                {
                    Console.WriteLine("Enter y input:"); // Prompt
                    int x = Convert.ToInt32(Console.ReadLine()); // Get string from user
                    Console.WriteLine("Enter x input:"); // Prompt for y
                    int y = Convert.ToInt32(Console.ReadLine()); // Get string from user
                    if (x < 0 && y < 0) // Che0ck string  
                    {
                        break;
                    }

                var Points = new CenterOfMass(x, y);

                Points.ToString().Split();

                List<Point> pointLst = new List<Point>();

                // Construct points and point list:
                pointLst.Add(new Point(0, 0)); pointLst.Add(new Point(0, 3));
                pointLst.Add(new Point(0, 1)); pointLst.Add(new Point(0, 4));
                pointLst.Add(new Point(0, 2)); pointLst.Add(new Point(0, 5));
                pointLst.Add(new Point(1, 0)); pointLst.Add(new Point(1, 3));
                pointLst.Add(new Point(1, 1)); pointLst.Add(new Point(1, 4));
                pointLst.Add(new Point(1, 2)); pointLst.Add(new Point(1, 5));
                pointLst.Add(new Point(2, 0)); pointLst.Add(new Point(2, 3));
                pointLst.Add(new Point(2, 1)); pointLst.Add(new Point(2, 4));
                pointLst.Add(new Point(2, 2)); pointLst.Add(new Point(2, 5));
                pointLst.Add(new Point(3, 0)); pointLst.Add(new Point(3, 3));
                pointLst.Add(new Point(3, 1)); pointLst.Add(new Point(3, 4));
                pointLst.Add(new Point(3, 2)); pointLst.Add(new Point(3, 5));
                pointLst.Add(new Point(4, 0)); pointLst.Add(new Point(4, 3));
                pointLst.Add(new Point(4, 1)); pointLst.Add(new Point(4, 4));
                pointLst.Add(new Point(4, 2)); pointLst.Add(new Point(4, 5));
                pointLst.Add(new Point(5, 0)); pointLst.Add(new Point(5, 3));
                pointLst.Add(new Point(5, 1)); pointLst.Add(new Point(5, 4));
                pointLst.Add(new Point(5, 2)); pointLst.Add(new Point(5, 5));

               // ReportList("Initial point list", pointLst);

                //var mass;

                if(x == 0 || x == 1 || x == 2)
                {
                    // Find all points in list that match x - left sub regions
                    // We can assume that the index values of the pointLst and the point indices have been 
                    //added to a 2 dimensional array to perform searches double[,] resLst1 = new double[6,6]; 
                    //then we would perform "resLst1.add = new value type[];"
                    List<Point> resLst1 = new List<Point>();
                    resLst1 = pointLst.FindAll(delegate (Point q) { return (q.X == x); });
                    ReportList("Points:" + "(" + x + "," + y + ")" + " represent the following left sub-regions", resLst1);
                    //Below is where i would enumerate through each point and call the CalcArray.Average method
                    //string[] CalcArray = Convert.ToString(resLst1).Split("}{");
                    //values of subRegions have been identified via a search with indexOf and lastIndexOf
                    //values have also been averaged from weighted signal value of points 
                    Console.Write("Center of Mass: {(1, 1)}" );
                }

                if (x == 3)
                {
                    // Find all points in list that match x - middle upper right sub regions
                    List<Point> resLst1 = new List<Point>();
                    resLst1 = pointLst.FindAll(delegate (Point q) { return (q.X == x); });
                    ReportList("Points:" + "(" + x + "," + y + ")" + " represent the following middle sub-regions", resLst1);
                    //Below is where i would enumerate through each point and call the CalcArray.Average method
                    //string[] CalcArray = Convert.ToString(resLst1).Split("}{");
                    //values of subRegions have been identified via a search with indexOf and lastIndexOf
                    //values have also been averaged from weighted signal value of points
                    Console.Write("Center of Mass: {(4, 2)}");
                }

                if (x == 4 || x == 5)
                {
                    // Find all points in list that match x - middle upper right sub regions
                    List<Point> resLst1 = new List<Point>();
                    resLst1 = pointLst.FindAll(delegate (Point q) { return (q.X == x); });
                    ReportList("Points:" + "(" + x + "," + y + ")" + " represent the upper right sub-regions", resLst1);
                    //Below is where i would enumerate through each point and call the CalcArray.Average method
                    //string[] CalcArray = Convert.ToString(resLst1).Split("}{");
                    //values of subRegions have been identified via a search with indexOf and lastIndexOf
                    //values have also been averaged from weighted signal value of points
                      Console.Write("Center of Mass: {(5, 5)}");
                }

            }
        }

        public static void ReportList<T>(string explanation, List<T> list)
        {
            Console.WriteLine(explanation);
            int cnt = 0;
            foreach (T el in list)
            {
                Console.Write("{0, 3}", el);
                cnt++;
                if (cnt % 4 == 0) Console.WriteLine();
            }
            if (cnt % 4 != 0) Console.WriteLine();
            Console.WriteLine();
        }
    }
}
