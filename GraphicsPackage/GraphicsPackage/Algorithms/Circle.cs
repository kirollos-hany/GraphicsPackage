using System;
using System.Collections;


namespace GraphicsPackage.Algorithms
{
    public class Circle
    {
        public int radius;
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
                XPoints.Add(X + XOrigin);
                XPoints.Add(-X + XOrigin);
                XPoints.Add(X + XOrigin);
                XPoints.Add(-X + XOrigin);

                YPoints.Add(Y + YOrigin);
                YPoints.Add(Y + YOrigin);
                YPoints.Add(-Y + YOrigin);
                YPoints.Add(-Y + YOrigin);
            }
            }
        }
    }
