using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;
namespace GraphicsPackage.Algorithms
{
    class EllipseMidpoint
    {
        public ArrayList RegionOneX { get; }

        public ArrayList RegionOneY { get; }

        public ArrayList RegionTwoX { get; }

        public ArrayList RegionTwoY { get; }

        public ArrayList DecisionRegionOne { get; }

        public ArrayList DecisionRegionTwo { get; }

        public EllipseMidpoint()
        {
            RegionOneX = new ArrayList();
            RegionOneY = new ArrayList();
            RegionTwoX = new ArrayList();
            RegionTwoY = new ArrayList();
            DecisionRegionOne = new ArrayList();
            DecisionRegionTwo = new ArrayList();
        }

        public void Algorithm(int rx, int ry, int xc, int yc)
        {
            RegionOneX.Clear();
            RegionOneY.Clear();
            RegionTwoX.Clear();
            RegionTwoY.Clear();
            DecisionRegionOne.Clear();
            DecisionRegionTwo.Clear();
            double dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;

            // Initial decision parameter of region 1
            //p0=ry^2+1/4*rx^2-rx^2ry
            d1 = (ry * ry) - (rx * rx * ry) +
                            (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;
            DecisionRegionOne.Add(d1);



            // For region 1
            //WriteLine("Region1");
            while (dx < dy)
            {

                // Print points based on 4-way symmetry
                /*
                WriteLine(string.Format("{0:0.000000}",
                                    (x + xc)) + ", " + string.Format
                                    ("{0:0.000000}", (y + yc)));
                WriteLine(string.Format("{0:0.000000}",
                                    (-x + xc)) + ", " + string.Format
                                    ("{0:0.000000}", (y + yc)));
                WriteLine(string.Format("{0:0.000000}",
                                    (x + xc)) + ", " + string.Format
                                    ("{0:0.000000}", (-y + yc)));
                WriteLine(string.Format("{0:0.000000}",
                                    (-x + xc)) + ", " + string.Format
                                    ("{0:0.000000}", (-y + yc)));*/
                RegionOneX.Add(x + xc);
                RegionOneX.Add(-x + xc);
                RegionOneX.Add(x + xc);
                RegionOneX.Add(-x + xc);

                RegionOneY.Add(y + yc);
                RegionOneY.Add(y + yc);
                RegionOneY.Add(-y + yc);
                RegionOneY.Add(-y + yc);

                // Checking and updating value of
                // decision parameter based on algorithm
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                    DecisionRegionOne.Add(d1);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                    DecisionRegionOne.Add(d1);
                }
            }

            // Decision parameter of region 2
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);
            DecisionRegionTwo.Add(d2);

            // Plotting points of region 2
            //WriteLine("Region2:");
            while (y >= 0)
            {

                // printing points based on 4-way symmetry
                /*
                WriteLine(string.Format("{0:0.000000}",
                                    (x + xc)) + ", " + string.Format
                                    ("{0:0.000000}", (y + yc)));
                WriteLine(string.Format("{0:0.000000}",
                                    (-x + xc)) + ", " + string.Format
                                    ("{0:0.000000}", (y + yc)));
                WriteLine(string.Format("{0:0.000000}",
                                    (x + xc)) + ", " + string.Format
                                    ("{0:0.000000}", (-y + yc)));
                WriteLine(string.Format("{0:0.000000}",
                                    (-x + xc)) + ", " + string.Format
                                    ("{0:0.000000}", (-y + yc)));*/

                RegionTwoX.Add(x + xc);
                RegionTwoX.Add(-x + xc);
                RegionTwoX.Add(x + xc);
                RegionTwoX.Add(-x + xc);

                RegionTwoY.Add(y + yc);
                RegionTwoY.Add(y + yc);
                RegionTwoY.Add(-y + yc);
                RegionTwoY.Add(-y + yc);

                // Checking and updating parameter
                // value based on algorithm
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                    DecisionRegionTwo.Add(d2);
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                    DecisionRegionTwo.Add(d2);
                }
            }
        }
    }
}
