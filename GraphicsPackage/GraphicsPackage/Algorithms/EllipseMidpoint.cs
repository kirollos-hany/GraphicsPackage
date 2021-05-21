using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace GraphicsPackage
{
    public class EllipseMidpoint
    {
        public List<int> Xpoints = new List<int>();
        public List<int> Ypoints = new List<int>();

        public List<double> P1points = new List<double>();
        public List<double> P2points = new List<double>();


        public EllipseMidpoint()
        {

        }

        public void Algorithm(int rx, int ry, int xCenter, int yCenter)
        {
            Xpoints.Clear();
            Ypoints.Clear();
        List<int> XTempPoints = new List<int>();
        List<int> YTempPoints = new List<int>();
        int x = 0, y = ry, dx, dy;
            double d1, d2;

            d1 = ((ry * ry) - (rx * rx * ry) + (0.25 * rx * rx));
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;
            P1points.Add(d1);

            // region 1
            while (dx < dy)
            {

                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);

                }
                P1points.Add(d1);

                XTempPoints.Add(x);
                YTempPoints.Add(y);
                //setPixel(xCenter+x,yCenter+y);
                //setPixel(xCenter-x,yCenter+y);
                //setPixel(xCenter-x,yCenter-y);
                //setPixel(xCenter+x,yCenter-y);

            }

            d2 = (((ry * ry) * ((x + 0.5) * (x + 0.5))) +
                 ((rx * rx) * ((y - 1) * (y - 1))) -
                 (rx * rx * ry * ry));
            P2points.Add(d2);
            while (y >= 0)
            {

                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }

                XTempPoints.Add(x);
                YTempPoints.Add(y);
                //setPixel(xCenter+x,yCenter+y);
                //setPixel(xCenter-x,yCenter+y);
                //setPixel(xCenter-x,yCenter-y);
                //setPixel(xCenter+x,yCenter-y);
                P2points.Add(d2);
            }

            P1points.RemoveAt(P1points.Count - 1);
            P2points.RemoveAt(P2points.Count - 1);
            P2points.RemoveAt(P2points.Count - 1);

            P1points.AddRange(P2points);

            Console.WriteLine("count xpoints =" + Xpoints.Count);
            Console.WriteLine("count ypoints =" + Ypoints.Count);

            Console.WriteLine("count p1 =" + P1points.Count);
            Console.WriteLine("count p2 =" + P2points.Count);
            //for (int l = 0; l < P1points.Count; l += 1)
            //{
            //    Console.WriteLine("p1 =" + P1points[l]);
            //}

            //for (int l = 0; l < P2points.Count; l += 1)
            //{
            //    Console.WriteLine("p2 =" + P2points[l]);
            //}





            for (int i = 0; i < 4; i++)
            {
                for (int index = 0; index < XTempPoints.Count - 1; index++)
                {
                    int xValue = XTempPoints[index];
                    int yValue = YTempPoints[index];
                    switch (i)
                    {
                        case 0: setPixel(xCenter + xValue, yCenter + yValue); break;
                        case 1: setPixel(xCenter + -xValue, yCenter + yValue); break;
                        case 2: setPixel(xCenter - xValue, yCenter - yValue); break;
                        case 3: setPixel(xCenter + xValue, yCenter - yValue); break;
                    }
                }
            }






            int pos = -1;
            Console.WriteLine("k" + "\t" + "P1k" + "\t" + "(Xk+1,Yk+1)" + "\t" + "(2Xk+1,2Yk+1)");
            Console.WriteLine("--" + "\t" + "---" + "\t" + "-------" + "\t\t" + "----------");
            try
            {
                for (int i = 0; i < Xpoints.Count / 4; i += 1)
                {

                    Console.WriteLine(i + "\t" + P1points[i] + "\t"
                  + "(" + Xpoints[i] + "," + Ypoints[i] + ")"
                  + "\t\t" + "(" + 2 * ry * ry * Xpoints[i] + ","
                  + 2 * rx * rx * Ypoints[i] + ")");
                    if (2 * ry * ry * Xpoints[i] > 2 * rx * rx * Ypoints[i] && pos < 0)
                    {
                        pos = i;
                    }
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error! " + e);
            }

            Console.WriteLine("region 2 po=" + P2points[0] + "  start point " + "(" + Xpoints[pos] + ", " + Ypoints[pos] + ")");


        }
        private void setPixel(int x, int y)
        {
            Xpoints.Add(x);
            Ypoints.Add(y);

        }
    }
}



/*if ((2 * ry * ry * x) > (2 * rx * rx * y))
{
    Console.WriteLine("k" + "\t" + "P1k" + "\t" + "(Xk+1,Yk+1)" + "\t" + "(2Xk+1,2Yk+1)");
    Console.WriteLine("--" + "\t" + "--" + "\t" + "-------" + "\t\t" + "-------");
    for (int j = Ypoints.Count; j > 0; j -= 1)
    {

        Console.WriteLine(j + "\t" + P2points[j] + "\t" + "(" + Xpoints[j] + "," + Ypoints[j] + ")" + "\t\t" + "(" + 2 * ry * ry * Xpoints[j] + "," + 2 * rx * rx * Ypoints[j] + ")");
    }
}*/
