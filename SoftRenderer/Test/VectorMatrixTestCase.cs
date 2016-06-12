using SoftRenderer.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Test
{
    public class VectorMatrixTestCase
    {
        private static bool isEnable = false;
        public static void Test()
        {
            Vector3D a = new Vector3D(1, 2, 1,1);
            Vector3D b = new Vector3D(5, 6, 0,1);
            Vector3D c = new Vector3D(1, 2, 3, 1);

            float r1 = Vector3D.Dot(a,b);
            Vector3D r2 = a - b;
            Vector3D r3 = Vector3D.Cross(a,b);
            Console.WriteLine("a dot b:{0}", r1);
            Console.WriteLine("a - b:({0},{1},{2},{3})", r2.x, r2.y, r2.z, r2.w);
            Console.WriteLine("a X b:({0},{1},{2},{3})", r3.x, r3.y, r3.z, r3.w);
            //
            Matrix4x4 mat1 = new Matrix4x4(1,2,3,4,
                                            1,2,3,4,
                                            1,2,3,4,
                                            0,0,0,1);
            Matrix4x4 mat2 = new Matrix4x4(1, 2, 3, 4,
                                            1, 2, 3, 4,
                                            1, 2, 3, 4,
                                            1, 2, 3, 4);
            Matrix4x4 mat3 = new Matrix4x4();
            mat3.Identity();
            Matrix4x4 mat4 = new Matrix4x4(1, 0, 0, 0,
                                           0, 1, 0, 0,
                                           0, 0, 1, 0,
                                           1, 2, 3, 1);

            Matrix4x4 mat5 = new Matrix4x4(1, 2, 3, 4,
                                           4, 3, 2, 1,
                                           0, -1, 2, 0,
                                           1, 6, 4, -2);
            Console.WriteLine("mat5   Determinate:" + mat5.Determinate());
            Console.WriteLine("mat5   GetAdjoint:");
            showMat(mat5.GetAdjoint());

            Console.WriteLine("mat5   Inverse:" );
            showMat(mat5.Inverse());

            Console.WriteLine("mat5 *  mat5 Inverse:");
            showMat(mat5 * mat5.Inverse());

            Console.WriteLine("mat2   Transpose:");
            showMat(mat2.Transpose());


            Matrix4x4 matr1 = mat1 * mat3;
            Console.WriteLine("mat1 * mat3:");
            showMat(matr1);
            Matrix4x4 matr2 = mat1 * mat2;
            Console.WriteLine("mat1 * mat2:");
            showMat(matr2);
            Vector3D r4 = a * mat1;
            Console.WriteLine("a * mat1:({0},{1},{2},{3})", r4.x, r4.y, r4.z, r4.w);

            Vector3D r5 = a * mat4;
            Console.WriteLine("a * mat4:({0},{1},{2},{3})", r5.x, r5.y, r5.z, r5.w);
        }

        public static void showMat(Matrix4x4 mat)
        {
            if (isEnable)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("[{0},{1},{2},{3}]", mat[i, 0], mat[i, 1], mat[i, 2], mat[i, 3]);
                }
            }
           
        }

        public static void showVector3(Vector3D v)
        {
            if (isEnable)
            {
                Console.WriteLine("[{0},{1},{2},{3}]", v.x, v.y, v.z, v.w);
            }
        }
    }
}
