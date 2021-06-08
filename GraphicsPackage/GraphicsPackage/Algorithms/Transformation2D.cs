using System;


namespace GraphicsPackage.Algorithms
{
    class Transformation2D
    {
        public int[] Shear(int [] points, int index, int sh)
        {
            if (index == 0)
            {
                    return ShearX(points, sh);
            }
            else if (index == 1)
            {
                    return ShearY(points, sh);
            }
            return null;
        }
        private int[] ShearX(int[] p, int sh_x)
        {
            int x_new = p[0] + sh_x * p[1];
            int y_new = p[1];
            return new int[3] { x_new, y_new, 1};
        }
        private int [] ShearY(int[] p, int sh_y)
        {
            int x_new = p[0];
            int y_new = p[1] + sh_y * p[0];
            return new int[3] { x_new, y_new, 1 };
        }
    
    public double[] Rotation(double theta, double[] Point)
        {
            double[] NPoint = new double[3];
            double[,] TransMatrix = new double[3, 3];
            TransMatrix[0, 0] = Math.Cos(theta);
            TransMatrix[0, 1] = -Math.Sin(theta);
            TransMatrix[0, 2] = 0;
            TransMatrix[1, 0] = Math.Sin(theta);
            TransMatrix[1, 1] = Math.Cos(theta);
            TransMatrix[1, 2] = 0;
            TransMatrix[2, 0] = 0;
            TransMatrix[2, 1] = 0;
            TransMatrix[2, 2] = 1;
            double sum;
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

        public int[] Reflect(int axisIndex, int[] Point)
        {
            if (axisIndex == 0)
            {
                return Scaling(1, -1, Point);
            }else if (axisIndex == 1)
            {
                return Scaling(-1, 1, Point);
            }
            else if(axisIndex == 2){
                return Scaling(-1, -1, Point);
            }
            return null;
        }
    }
}

