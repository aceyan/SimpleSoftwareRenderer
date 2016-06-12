using SoftRenderer.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.RenderData
{
    /// <summary>
    /// 网格类
    /// </summary>
    public class Mesh
    {
        private Vertex[] _verts;
        /// <summary>
        /// 顶点数组
        /// </summary>
        public Vertex[] vertices
        {
            get { return _verts; }
        }

        private Material _mat;
        /// <summary>
        /// 材质
        /// </summary>
        public Material material
        {
            get { return _mat; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointList">顶点位置列表</param>
        /// <param name="indexs">顶点索引列表</param>
        /// <param name="Uvs">uv坐标列表</param>
        /// <param name="vertColor">顶点色列表</param>
        public Mesh(Vector3D[] pointList, int[] indexs, Point2D[] Uvs, Vector3D[] vertColors, Vector3D[] normals, Material mat)
        {
            _verts = new Vertex[indexs.Length];
            //生成顶点列表
            for (int i = 0; i < indexs.Length; i++)
            {
                int pointIndex = indexs[i];
                Vector3D point = pointList[pointIndex];
                _verts[i] = new Vertex(point, normals[i], Uvs[i].x, Uvs[i].y, vertColors[i].x, vertColors[i].y, vertColors[i].z);
            }
            _mat = mat;
        }
    }
}
