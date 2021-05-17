using System;
using System.Collections;


namespace GraphicsPackage.Algorithms
{
    class BresenhamLine
    {
        public ArrayList XPoints { get; }
        public ArrayList YPoints { get; }

        public ArrayList PKPoints { get; }

        public string Octant { get { return octant; } }
        private string octant;

        public float Slope { get { return slope; } }
        private float slope;

        public BresenhamLine()
        {
            XPoints = new ArrayList();
            YPoints = new ArrayList();
            PKPoints = new ArrayList();
            octant = "";
            slope = 0f;
        }

        public void Algorithm(int xStart, int yStart, int xEnd, int yEnd)
        {
            XPoints.Clear();
            YPoints.Clear();
            PKPoints.Clear();
            CalcSlope(xStart, yStart, xEnd, yEnd);
            int dx = Math.Abs(xEnd - xStart), dy = Math.Abs(yEnd - yStart);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);

            if (IsFirstOctant(xStart, xEnd))
            {
                x = xStart;
                y = yStart;
                octant = "1st";
                XPoints.Add(x);
                YPoints.Add(y);
                PKPoints.Add(p);
                while (x < xEnd)
                {
                    x++;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y++;
                        p += twoDyMinusDx;
                    }
                    XPoints.Add(x);
                    YPoints.Add(y);
                    PKPoints.Add(p);
                }
            }
            else if (IsSecondOctant(yStart, yEnd))
            {
                SwapCoordinates(ref xStart, ref yStart, ref xEnd, ref yEnd);
                dx = Math.Abs(xEnd - xStart);
                dy = Math.Abs(yEnd - yStart);
                p = 2 * dy - dx;
                PKPoints.Add(p);
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                x = xStart;
                y = yStart;
                octant = "2nd";
                //XPoints.Add(x);
                //YPoints.Add(y);
                XPoints.Add(y);
                YPoints.Add(x);
                while (x < xEnd)
                {
                    x++;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y++;
                        p += twoDyMinusDx;
                    }
                    //XPoints.Add(x);
                    //YPoints.Add(y);
                    XPoints.Add(y);
                    YPoints.Add(x);
                    PKPoints.Add(p);
                }
            }
            else if (IsThirdOctant(yStart, yEnd))
            {
                SwapCoordinates(ref xStart, ref yStart, ref xEnd, ref yEnd);
                dx = Math.Abs(xEnd - xStart);
                dy = Math.Abs(yEnd - yStart);
                p = 2 * dy - dx;
                PKPoints.Add(p);
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                x = xStart;
                y = yStart;
                octant = "3rd";
                //XPoints.Add(x);
                //YPoints.Add(y);
                XPoints.Add(y);
                YPoints.Add(x);
                while (x < xEnd)
                {
                    x++;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y--;
                        p += twoDyMinusDx;
                    }
                    //XPoints.Add(x);
                    //YPoints.Add(y);
                    XPoints.Add(y);
                    YPoints.Add(x);
                    PKPoints.Add(p);
                }
            }
            else if (IsFourthOctant(xStart, xEnd))
            {
                x = xStart;
                y = yStart;
                octant = "4th";
                XPoints.Add(x);
                YPoints.Add(y);
                PKPoints.Add(p);
                while (x > xEnd)
                {
                    x--;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y++;
                        p += twoDyMinusDx;
                    }
                    XPoints.Add(x);
                    YPoints.Add(y);
                    PKPoints.Add(p);
                }
            }
            else if (IsFifthOctant(xStart, xEnd))
            {
                x = xStart;
                y = yStart;
                octant = "5th";
                XPoints.Add(x);
                YPoints.Add(y);
                PKPoints.Add(p);
                while (x > xEnd)
                {
                    x--;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y--;
                        p += twoDyMinusDx;
                    }
                    XPoints.Add(x);
                    YPoints.Add(y);
                    PKPoints.Add(p);
                }
            }
            else if (IsSixthOctant(yStart, yEnd))
            {
                SwapCoordinates(ref xStart, ref yStart, ref xEnd, ref yEnd);
                dx = Math.Abs(xEnd - xStart);
                dy = Math.Abs(yEnd - yStart);
                p = 2 * dy - dx;
                PKPoints.Add(p);
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                x = xStart;
                y = yStart;
                octant = "6th";
                //XPoints.Add(x);
                //YPoints.Add(y);
                XPoints.Add(y);
                YPoints.Add(x);
                while (x > xEnd)
                {
                    x--;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y--;
                        p += twoDyMinusDx;
                    }
                    //XPoints.Add(x);
                    //YPoints.Add(y);
                    XPoints.Add(y);
                    YPoints.Add(x);
                    PKPoints.Add(p);
                }
            }
            else if (IsSeventhOctant(yStart, yEnd))
            {
                SwapCoordinates(ref xStart, ref yStart, ref xEnd, ref yEnd);
                dx = Math.Abs(xEnd - xStart);
                dy = Math.Abs(yEnd - yStart);
                p = 2 * dy - dx;
                PKPoints.Add(p);
                twoDy = 2 * dy;
                twoDyMinusDx = 2 * (dy - dx);
                x = xStart;
                y = yStart;
                octant = "7th";
                //XPoints.Add(x);
                //YPoints.Add(y);
                XPoints.Add(y);
                YPoints.Add(x);
                while (x > xEnd)
                {
                    x--;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y++;
                        p += twoDyMinusDx;
                    }
                    //XPoints.Add(x);
                    //YPoints.Add(y);
                    XPoints.Add(y);
                    YPoints.Add(x);
                    PKPoints.Add(p);
                }
            }
            else if (IsEighthOctant(xStart, xEnd))
            {
                x = xStart;
                y = yStart;
                octant = "8th";
                XPoints.Add(x);
                YPoints.Add(y);
                PKPoints.Add(p);
                while (x < xEnd)
                {
                    x++;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y--;
                        p += twoDyMinusDx;
                    }
                    XPoints.Add(x);
                    YPoints.Add(y);
                    PKPoints.Add(p);
                }
            }
        }
        private void SwapCoordinates(ref int xStart, ref int yStart, ref int xEnd, ref int yEnd)
        {
            int temp = xStart;
            xStart = yStart;
            yStart = temp;
            temp = xEnd;
            xEnd = yEnd;
            yEnd = temp;
        }
        private void CalcSlope(int xStart, int yStart, int xEnd, int yEnd)
        {
            this.slope = (float)(yEnd - yStart) / (xEnd - xStart);
        }

        private bool IsFirstOctant(int xStart, int xEnd)
        {
            return xStart < xEnd && slope <= 1 && slope >= 0;
        }

        private bool IsSecondOctant(int yStart, int yEnd)
        {
            return yStart < yEnd && slope > 1;
        }

        private bool IsThirdOctant(int yStart, int yEnd)
        {
            return yStart < yEnd && slope < -1;
        }

        private bool IsFourthOctant(int xStart, int xEnd)
        {
            return xEnd < xStart && slope <= 0 && slope >= -1;
        }

        private bool IsFifthOctant(int xStart, int xEnd)
        {
            return xEnd < xStart && slope > 0 && slope <= 1;
        }

        private bool IsSixthOctant(int yStart, int yEnd)
        {
            return yEnd < yStart && slope > 1;
        }

        private bool IsSeventhOctant(int yStart, int yEnd)
        {
            return yEnd < yStart && slope < -1;
        }

        private bool IsEighthOctant(int xStart, int xEnd)
        {
            return xStart < xEnd && slope >= -1 && slope <= 0;
        }


    }
}

