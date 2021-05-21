using System;
using System.Collections;


namespace GraphicsPackage.Algorithms
{
    public class Circle
    {
        public ArrayList XPoints { get; }
        public ArrayList YPoints { get; }


        public ArrayList PKPoints { get; }

        public Circle()
        {
            XPoints = new ArrayList();
            YPoints = new ArrayList();
            PKPoints = new ArrayList();

        }
        public void Algorithm(int radius, int XOrigin, int YOrigin)
        {
            ArrayList tempXPoints = new ArrayList();
            ArrayList tempYPoints = new ArrayList();
            PKPoints.Clear();
            XPoints.Clear();
            YPoints.Clear();
            int pk = 1 - radius;
            PKPoints.Add(pk);
            int X = 0;
            int Y = radius;
            while (X < Y)
            {
                X++;
                if (pk < 0)
                {
                    pk = pk + 2 * X + 1;
                    PKPoints.Add(pk);
                }
                else
                {
                    Y--;
                    pk = pk + (2 * X) + 1 - (2 * Y);
                    PKPoints.Add(pk);
                }
                tempXPoints.Add(X);
                tempYPoints.Add(Y);
            }
            for (int i = 0; i < 8; i++)
            {
                for (int index = 0; index < tempXPoints.Count; index++)
                {
                    int xValue = Convert.ToInt32(tempXPoints[index]);
                    int yValue = Convert.ToInt32(tempYPoints[index]);
                    switch (i)
                    {
                        case 0: SetPixel(XOrigin + xValue, YOrigin + yValue); break;
                        case 1: SetPixel(XOrigin + yValue, YOrigin + xValue); break;
                        case 2: SetPixel(XOrigin + yValue, YOrigin - xValue); break;
                        case 3: SetPixel(XOrigin + xValue, YOrigin - yValue); break;
                        case 4: SetPixel(XOrigin - xValue, YOrigin - yValue); break;
                        case 5: SetPixel(XOrigin - yValue, YOrigin - xValue); break;
                        case 6: SetPixel(XOrigin - yValue, YOrigin + xValue); break;
                        case 7: SetPixel(XOrigin - xValue, YOrigin + yValue); break;
                    }
                }
            }
        }
        private void SetPixel(int x, int y)
        {
            XPoints.Add(x);
            YPoints.Add(y);
        }
        }
    }
