using SoftRenderer.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.RenderData
{
    /// <summary>
    /// 顶点信息
    /// </summary>
    public struct Vertex
    {
        /// <summary>
        /// 顶点位置
        /// </summary>
        public Vector3D point;
        /// <summary>
        /// 纹理坐标
        /// </summary>
        public float u;
        public float v;
        /// <summary>
        /// 顶点色
        /// </summary>
        public Color vcolor;
        /// <summary>
        /// 法线
        /// </summary>
        public Vector3D normal;

        //----------------------------------------------
        //
        //----------------------------------------------

        /// <summary>
        /// 光照颜色
        /// </summary>
        public Color lightingColor;

        /// <summary>
        /// 1/z，用于顶点信息的透视校正
        /// </summary>
        public float onePerZ;


        public Vertex(Vector3D point, Vector3D normal,float u, float v, float r, float g, float b)
        {
            this.point = point;
            this.normal = normal;
            this.point.w = 1;
            vcolor.r = r;
            vcolor.g = g;
            vcolor.b = b;
            onePerZ = 1;
            this.u = u;
            this.v = v;
            lightingColor.r = 1;
            lightingColor.g = 1;
            lightingColor.b = 1;
        }

        public Vertex(Vertex v)
        {
            point = v.point;
            normal = v.normal;
            vcolor.r = v.vcolor.r;
            vcolor.g = v.vcolor.g;
            vcolor.b = v.vcolor.b;
            onePerZ = 1;
            this.u = v.u;
            this.v = v.v;
            lightingColor.r = 1;
            lightingColor.g = 1;
            lightingColor.b = 1;
        }
    }
}
