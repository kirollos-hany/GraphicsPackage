using System;


namespace GraphicsPackage.Algorithms
{
    class Transformation2D
    {
        public float[] Rotation(float theta, int[] Point)
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
        public int[] Scaling(int Sx, int Sy, int[] Point)
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
        public int[] Translation(int dx, int dy, int[] Point)
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
        public int[] Reflect(int Quarter, int[] Point)
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
        //Sher Function
        public static float[] SherX(float SHx, float[] Point)
        {
            float[] NPoint = new float[3];
            float[,] SherX = new float[3, 3];
            //INSIALIZING SHERX
            SherX[0, 0] = 1f;
            SherX[0, 1] = SHx;
            SherX[0, 2] = 0f;
            SherX[1, 0] = 0f;
            SherX[1, 1] = 1f;
            SherX[1, 2] = 0f;
            SherX[2, 0] = 0f;
            SherX[2, 1] = 0f;
            SherX[2, 2] = 1f;

            float sum;
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {

                    sum += SherX[i, j] * Point[j];

                }
                NPoint[i] = sum;

            }
            return NPoint;
        }

        //SherY Function
        public static float[] SherY(float SHy, float[] Point)
        {
            float[] NPoint = new float[3];
            float[,] SherY = new float[3, 3];
            //INSIALIZING SHERY
            SherY[0, 0] = 1f;
            SherY[0, 1] = 0f;
            SherY[0, 2] = 0f;
            SherY[1, 0] = SHy;
            SherY[1, 1] = 1f;
            SherY[1, 2] = 0f;
            SherY[2, 0] = 0f;
            SherY[2, 1] = 0f;
            SherY[2, 2] = 1f;

            float sum;
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {

                    sum += SherY[i, j] * Point[j];

                }
                NPoint[i] = sum;

            }
            return NPoint;
        }
    }
}
