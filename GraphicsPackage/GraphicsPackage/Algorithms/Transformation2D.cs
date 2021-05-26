using System;


namespace GraphicsPackage.Algorithms
{
    class Transformation2D
    {
        public static float[] Rotation(float theta, int[] Point)
        {
            float[] NPoint = new float[3];
            float[,] TransMatrix = new float[3, 3];
            TransMatrix[0, 0] = MathF.Cos(theta);
            TransMatrix[0, 1] = -MathF.Sin(theta);
            TransMatrix[0, 2] = 0;
            TransMatrix[1, 0] = MathF.Sin(theta);
            TransMatrix[1, 1] = MathF.Cos(theta);
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
        public static int[] Reflect(int Quarter, int[] Point)
        {
            if (Quarter == 2)
            {
                Point[0] = Point[0] * -1;
            }
            else if (Quarter == 3)
            {
                Point[0] = Point[0] * -1;
                Point[1] = Point[1] * -1;
            }
            else if (Quarter== 4)
            {
                Point[1] = Point[1] * -1;
            }
            return Point;
        }
    }
}
