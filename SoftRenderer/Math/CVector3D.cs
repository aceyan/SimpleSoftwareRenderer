using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Math
{
    /// <summary>
    /// 行向量
    /// </summary>
    public struct CVector3D
    {
        public float x;
        public float y;
        public float z;
        public float w;


        public CVector3D(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public CVector3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = 0;
        }

        /// <summary>
        /// 向量长度
        /// </summary>
        public float Length
        {
            get
            {
                float sq = x * x + y * y + z * z;
                return (float)System.Math.Sqrt(sq);
            }
        }
        /// <summary>
        /// 规范化
        /// </summary>
        public CVector3D Normalize()
        {
            float length = Length;
            if(length != 0)
            {
                float s = 1 / length;
                x *= s;
                y *= s;
                z *= s;
            }
            return this;
        }
        /// <summary>
        /// 向量变换
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static CVector3D operator *(CVector3D lhs, CMatrix4x4 rhs)
        {
            CVector3D v = new CVector3D();
            v.x = lhs.x * rhs[0, 0] + lhs.y * rhs[1, 0] + lhs.z * rhs[2, 0] + lhs.w * rhs[3, 0];
            v.y = lhs.x * rhs[0, 1] + lhs.y * rhs[1, 1] + lhs.z * rhs[2, 1] + lhs.w * rhs[3, 1];
            v.z = lhs.x * rhs[0, 2] + lhs.y * rhs[1, 2] + lhs.z * rhs[2, 2] + lhs.w * rhs[3, 2];
            v.w = lhs.x * rhs[0, 3] + lhs.y * rhs[1, 3] + lhs.z * rhs[2, 3] + lhs.w * rhs[3, 3];
            return v;
        }

        public static CVector3D operator -(CVector3D lhs, CVector3D rhs)
        {
            CVector3D v = new CVector3D();
            v.x = lhs.x - rhs.x;
            v.y = lhs.y - rhs.y;
            v.z = lhs.z - rhs.z;
            v.w = 0;
            return v;
        }
        /// <summary>
        /// 点乘
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static float Dot(CVector3D lhs,CVector3D rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }
        /// <summary>
        /// 叉乘
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static CVector3D Cross(CVector3D lhs, CVector3D rhs)
        {
            float x = lhs.y * rhs.z - lhs.z * rhs.y;
            float y = lhs.z * rhs.x - lhs.x * rhs.z;
            float z = lhs.x * rhs.y - lhs.y * rhs.x;
            return new CVector3D(x, y, z, 0);
        }
    
    }
}
