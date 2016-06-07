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
            CVector3D a = new CVector3D(1, 2, 1,1);
            CVector3D b = new CVector3D(5, 6, 0,1);
            CVector3D c = new CVector3D(1, 2, 3, 1);

            float r1 = CVector3D.Dot(a,b);
            CVector3D r2 = a - b;
            CVector3D r3 = CVector3D.Cross(a,b);
            Console.WriteLine("a dot b:{0}", r1);
            Console.WriteLine("a - b:({0},{1},{2},{3})", r2.x, r2.y, r2.z, r2.w);
            Console.WriteLine("a X b:({0},{1},{2},{3})", r3.x, r3.y, r3.z, r3.w);
            //
            CMatrix4x4 mat1 = new CMatrix4x4(1,2,3,4,
                                            1,2,3,4,
                                            1,2,3,4,
                                            0,0,0,1);
            CMatrix4x4 mat2 = new CMatrix4x4(1, 2, 3, 4,
                                            1, 2, 3, 4,
                                            1, 2, 3, 4,
                                            1, 2, 3, 4);
            CMatrix4x4 mat3 = new CMatrix4x4();
            mat3.Identity();
            CMatrix4x4 mat4 = new CMatrix4x4(1, 0, 0, 0,
                                           0, 1, 0, 0,
                                           0, 0, 1, 0,
                                           1, 2, 3, 1);
            CMatrix4x4 matr1 = mat1 * mat3;
            Console.WriteLine("mat1 * mat3:");
            showMat(matr1);
            CMatrix4x4 matr2 = mat1 * mat2;
            Console.WriteLine("mat1 * mat2:");
            showMat(matr2);
            CVector3D r4 = a * mat1;
            Console.WriteLine("a * mat1:({0},{1},{2},{3})", r4.x, r4.y, r4.z, r4.w);

            CVector3D r5 = a * mat4;
            Console.WriteLine("a * mat4:({0},{1},{2},{3})", r5.x, r5.y, r5.z, r5.w);
        }

        public static void showMat(CMatrix4x4 mat)
        {
            if (isEnable)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("[{0},{1},{2},{3}]", mat[i, 0], mat[i, 1], mat[i, 2], mat[i, 3]);
                }
            }
           
        }

        public static void showVector3(CVector3D v)
        {
            if (isEnable)
            {
                Console.WriteLine("[{0},{1},{2},{3}]", v.x, v.y, v.z, v.w);
            }
        }
    }
}
