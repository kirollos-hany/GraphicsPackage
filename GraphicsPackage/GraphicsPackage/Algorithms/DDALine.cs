using static System.Console;
using System.Collections;
using System;

namespace GraphicsPackage.Algorithms
{
    public class DDALine
    {
        public ArrayList XPoints { get; }
        public ArrayList YPoints { get; }

        public float Slope { get { return slope; } }

        private float slope;

        public DDALine()
        {
            YPoints = new ArrayList();
            XPoints = new ArrayList();
        }

        public void Algorithm(int xStart, int yStart, int xEnd, int yEnd)
        {
            XPoints.Clear();
            YPoints.Clear();
            int dx = xEnd - xStart, dy = yEnd - yStart,
            steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
            float xInc = dx / (float)steps, yInc = dy / (float)steps, x = xStart, y = yStart;
            slope = (float)dy / dx;

            XPoints.Add(Math.Round(x));
            YPoints.Add(Math.Round(y));
            for (int k = 0; k < steps; k++)
            {
                x += xInc;
                y += yInc;
                double roundedY = Math.Round(y);
                double roundedX = Math.Round(x);
                XPoints.Add(roundedX);
                YPoints.Add(roundedY);
            }

        }

    }
}
