using System;
using System.Collections;


namespace GraphicsPackage.Algorithms
{
    public class Circle
    {
        public int radius;
        public ArrayList Xpoints { get; }
        public ArrayList Ypoints { get; }
        public int PK;

        public Circle()
        {
            Xpoints = new ArrayList();
            Ypoints = new ArrayList();
        }
        public void Algorithm(int radius, int XOrigin, int YOrigin, int X, int Y)
        {
            PK = 1 - radius;
            X = 0;
            Y = radius;
            Xpoints.Clear();
            Ypoints.Clear();
            int i = 0;
            while(X !>= Y)
            {
                if(PK < 0)
                {
                    X++;
                    PK = PK + 2 * X + 1;
                }
                else
                {
                    X++;
                    Y--;
                    PK = PK + (2 * X) + 1 - (2 * Y);
                }
                X = X + XOrigin;
                Y = Y + YOrigin;
                Xpoints.Add(X);
                Ypoints.Add(Y);
                Xpoints.Add(-X);
                Ypoints.Add(-Y);
                Xpoints.Add(Y);
                Ypoints.Add(X);
                Xpoints.Add(-Y);
                Ypoints.Add(-X);
                i++;
            }
        }
    }
}