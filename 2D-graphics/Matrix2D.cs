using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_graphics
{
    class Matrix2D
    {
        private float[] matrix_xy;
        public Matrix2D(float x, float y)
        {
            matrix_xy = new float[] { x, y, 1 };

        }
        public float GetX()
        {
            return matrix_xy[0];
        }
        public float GetY()
        {
            return matrix_xy[1];
        }
        public PointF screenPoint2D(int scale)
        {
            return new PointF(GetX() * scale, -GetY() * scale);
        }

        public void Mul(float[,] matrix, float x0, float y0)
        {
            float sum;
            matrix_xy[0] -= x0;
            matrix_xy[1] -= y0;
            float[] res = new float[3];
            for (int j = 0; j < 3; j++)
            {
                sum = 0;
                for (int k = 0; k < 3; k++)
                    sum += matrix_xy[k] * matrix[k, j];
                res[j] = sum;
            }
            res[0] += x0;
            res[1] += y0;
            matrix_xy = res;
        }
    }
}
