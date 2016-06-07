using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Math
{
    /// <summary>
    /// 数学工具
    /// </summary>
    public class MathUntil
    {
        /// <summary>
        /// 获取平移矩阵
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static CMatrix4x4 GetTranslate(float x, float y, float z)
        {
            return new CMatrix4x4(1, 0, 0, 0,
                                   0, 1, 0, 0,
                                   0, 0, 1, 0,
                                   x, y, z, 1);
        }
        /// <summary>
        /// 获取缩放矩阵
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static CMatrix4x4 GetScale(float x, float y, float z)
        {
            return new CMatrix4x4(x, 0, 0, 0,
                                  0, y, 0, 0,
                                  0, 0, z, 0,
                                  0, 0, 0, 1);
        }
        /// <summary>
        /// 获取旋转矩阵
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="r">弧度</param>
        /// <returns></returns>
        public static CMatrix4x4 GetRotate(float x, float y, float z, float r)
        {
            CMatrix4x4 rm = new CMatrix4x4();
            rm.Identity();
            rm[0, 0] = (float)(x * x * (1 - System.Math.Cos(r)) + System.Math.Cos(r));
            rm[0, 1] = (float)(x * y * (1 - System.Math.Cos(r)) +  z * System.Math.Sin(r));
            rm[0, 2] = (float)(x * z * (1 - System.Math.Cos(r)) - y * System.Math.Sin(r));
            //
            rm[1, 0] = (float)(y * x * (1 - System.Math.Cos(r)) - z * System.Math.Sin(r));
            rm[1, 1] = (float)(y * y * (1 - System.Math.Cos(r)) + System.Math.Cos(r));
            rm[1, 2] = (float)(y * z * (1 - System.Math.Cos(r)) + z * System.Math.Sin(r));
            //
            rm[2, 0] = (float)(z * x * (1 - System.Math.Cos(r)) + z * System.Math.Sin(r));
            rm[2, 1] = (float)(z * y * (1 - System.Math.Cos(r)) - System.Math.Sin(r));
            rm[2, 2] = (float)(z * z * (1 - System.Math.Cos(r)) + z * System.Math.Cos(r));
            return rm;
        }

        public static CMatrix4x4 GetRotateY(float r)
        {
            CMatrix4x4 rm = new CMatrix4x4();
            rm.Identity();
            rm[0, 0] = (float)(System.Math.Cos(r));

            rm[0, 2] = (float)(System.Math.Sin(r));
            //
           
            rm[2, 0] = (float)(-System.Math.Sin(r));
            rm[2, 2] = (float)(System.Math.Cos(r));
            return rm;
        }

        public static CMatrix4x4 GetRotateX(float r)
        {
            CMatrix4x4 rm = new CMatrix4x4();
            rm.Identity();
            rm[1, 1] = (float)(System.Math.Cos(r));
            rm[1, 2] = (float)(-System.Math.Sin(r));
            //

            rm[2, 1] = (float)(System.Math.Sin(r));
            rm[2, 2] = (float)(System.Math.Cos(r));
            return rm;
        }

        public static CMatrix4x4 GetRotateZ(float r)
        {
            CMatrix4x4 rm = new CMatrix4x4();
            rm.Identity();
            rm[0, 0] = (float)(System.Math.Cos(r));
            rm[0, 1] = (float)(-System.Math.Sin(r));
            //
            rm[1, 0] = (float)(System.Math.Sin(r));
            rm[1, 1] = (float)(System.Math.Cos(r));
            return rm;
        }
        /// <summary>
        /// 获取视矩阵
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="lookAt"></param>
        /// <param name="up"></param>
        /// <returns></returns>
        public static CMatrix4x4 GetView(CVector3D pos, CVector3D lookAt, CVector3D up)
        {
            //视线方向
            CVector3D dir = lookAt - pos;
            CVector3D right = CVector3D.Cross(up, dir);
            right.Normalize();
            //平移部分
            CMatrix4x4 t = new CMatrix4x4(1,0,0,0,
                                           0,1,0,0,
                                           0,0,1,0,
                                           -pos.x, -pos.y, -pos.z, 1);
            //旋转部分
            CMatrix4x4 r= new CMatrix4x4(right.x,up.x,dir.x,0,
                                           right.y,up.y,dir.y,0,
                                           right.z,up.z,dir.z,0,
                                           0, 0, 0, 1);
            return t * r;
        }

        /// <summary>
        /// 获取投影矩阵 dx风格， cvv为 x-1,1  y-1,1  z0,1
        /// </summary>
        /// <param name="fov">观察角，弧度</param>
        /// <param name="aspect">长宽比</param>
        /// <param name="zn">近裁z</param>
        /// <param name="zf">远裁z</param>
        /// <returns></returns>
        public static CMatrix4x4 GetProjection(float fov, float aspect, float zn, float zf)
        {
            CMatrix4x4 p = new CMatrix4x4();
            p.SetZero();
            p[0, 0] = (float)(1 / (System.Math.Tan(fov * 0.5f) * aspect));
            p[1, 1] = (float)(1 / System.Math.Tan(fov * 0.5f));
            p[2, 2] = zf / (zf - zn);
            p[2, 3] = 1f;
            p[3, 2] = (zn * zf) / (zn - zf);
            return p;
        }

        /// <summary>
        /// 线性插值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float Lerp(float a, float b, float t)
        {
            return b * t + (1 - t) * a;
        }
        /// <summary>
        /// 屏幕空间插值生成新顶点，此时已近经过透视除法，z信息已经没有作用
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static void ScreenSpaceLerpVertex(ref CVertex v, CVertex v1, CVertex v2, float t)
        {
            v.onePerZ = MathUntil.Lerp(v1.onePerZ, v2.onePerZ, t);
            //
            v.u = MathUntil.Lerp(v1.u, v2.u, t);
            v.v = MathUntil.Lerp(v1.v, v2.v, t);
            //
            v.color.r = MathUntil.Lerp(v1.color.r, v2.color.r, t);
            v.color.g = MathUntil.Lerp(v1.color.g, v2.color.g, t);
            v.color.b = MathUntil.Lerp(v1.color.b, v2.color.b, t);
        }

        public static int Range(int v, int min, int max)
        {
            if(v <= min)
            {
                return min;
            }
            if(v >= max)
            {
                return max;
            }
            return v;
        }
    }
}
