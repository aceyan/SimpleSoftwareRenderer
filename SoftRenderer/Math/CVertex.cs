using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Math
{
    /// <summary>
    /// 顶点信息
    /// </summary>
    public struct CVertex
    {
        /// <summary>
        /// 顶点位置
        /// </summary>
        public CVector3D point;
        /// <summary>
        /// 纹理坐标
        /// </summary>
        public float u;
        public float v;
        /// <summary>
        /// 顶点色
        /// </summary>
        public Color color;
        /// <summary>
        /// 1/z，用于顶点信息的透视校正
        /// </summary>
        public float onePerZ;

        public CVertex(CVector3D point,float u, float v, float r, float g, float b)
        {
            this.point = point;
            color.r = r;
            color.g = g;
            color.b = b;
            onePerZ = 1;
            this.u = u;
            this.v = v;
        }

        public CVertex(float x, float y, float z, float u, float v, float r, float g, float b)
        {
            point = new CVector3D(x, y, z, 1);
            color.r = r;
            color.g = g;
            color.b = b;
            onePerZ = 1;
            this.u = u;
            this.v = v;
        }

        public CVertex(CVertex v)
        {
            point = new CVector3D(v.point.x, v.point.y, v.point.z, 1);
            color.r = v.color.r;
            color.g = v.color.g;
            color.b = v.color.b;
            onePerZ = 1;
            this.u = v.u;
            this.v = v.v;
        }
    }
    /// <summary>
    /// 颜色值0-1
    /// </summary>
    public struct Color
    {
        public float r;
        public float g;
        public float b;
    }
}
