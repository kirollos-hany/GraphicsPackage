using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPackage.Algorithms
{
    class Transmission2D
    {
        public static float[] Rotation(float d, int[] Point)
        {
            float[] NPoint = new float[3];
            float[,] TransMatrix = new float[3, 3];

            TransMatrix[0, 0] = MathF.Cos(d);
            TransMatrix[0, 1] = -MathF.Sin(d);
            TransMatrix[0, 2] = 0;
            TransMatrix[1, 0] = MathF.Sin(d);
            TransMatrix[1, 1] = MathF.Cos(d);
            TransMatrix[1, 2] = 0;
            TransMatrix[2, 0] = 0;
            TransMatrix[2, 1] = 0;
            TransMatrix[2, 2] = 1;
            float sum;
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {

                    sum += TransMatrix[i, j] * Point[j];

                }
                NPoint[i] = sum;
            }
            return NPoint;
        }


        //Scaling Function
        public static int[] Scaling(int Sx, int Sy, int[] Point)
        {
            int[] NPoint = new int[3];
            int[,] TransMatrix = new int[3, 3];

            TransMatrix[0, 0] = Sx;
            TransMatrix[0, 1] = 0;
            TransMatrix[0, 2] = 0;
            TransMatrix[1, 0] = 0;
            TransMatrix[1, 1] = Sy;
            TransMatrix[1, 2] = 0;
            TransMatrix[2, 0] = 0;
            TransMatrix[2, 1] = 0;
            TransMatrix[2, 2] = 1;
            int sum;
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {

                    sum += TransMatrix[i, j] * Point[j];

                }
                NPoint[i] = sum;
            }
            return NPoint;
        }


        //Translation Function
        public static int[] Translation(int dx, int dy, int[] Point)
        {
            int[] NPoint = new int[3];
            int[,] TransMatrix = new int[3, 3];

            TransMatrix[0, 0] = 1;
            TransMatrix[0, 1] = 0;
            TransMatrix[0, 2] = dx;
            TransMatrix[1, 0] = 0;
            TransMatrix[1, 1] = 1;
            TransMatrix[1, 2] = dy;
            TransMatrix[2, 0] = 0;
            TransMatrix[2, 1] = 0;
            TransMatrix[2, 2] = 1;
            int sum;
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {

                    sum += TransMatrix[i, j] * Point[j];

                }
                NPoint[i] = sum;

            }
            return NPoint;
        }

        //Reflection Function
        public static int[] Reflect(int Quatrer, int[] Point)
        {
            if (Quatrer == 2)
            {
                Point[0] = Point[0] * -1;
            }
            else if (Quatrer == 3)
            {
                Point[0] = Point[0] * -1;
                Point[1] = Point[1] * -1;
            }
            else if (Quatrer == 4)
            {
                Point[1] = Point[1] * -1;
            }
            else
            {
                Console.WriteLine("Wrong Quarter");
            }
            return Point;
        }
    }
}
