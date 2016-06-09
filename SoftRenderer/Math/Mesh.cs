using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Math
{
    /// <summary>
    /// 网格类
    /// </summary>
    public class Mesh
    {
        private CVertex[] _verts;
        /// <summary>
        /// 顶点数组
        /// </summary>
        public CVertex[] Verts
        {
            get { return _verts; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointList">顶点位置列表</param>
        /// <param name="indexs">顶点索引列表</param>
        /// <param name="Uvs">uv坐标列表</param>
        /// <param name="vertColor">顶点色列表</param>
        public Mesh(CVector3D[] pointList, int[] indexs, Point2D[] Uvs, CVector3D[] vertColors)
        {
            _verts = new CVertex[indexs.Length];
            //生成顶点列表
            for (int i = 0; i < indexs.Length; i++)
            {
                int pointIndex = indexs[i];
                CVector3D point = pointList[pointIndex];
                _verts[i] = new CVertex(point, Uvs[i].x, Uvs[i].y, vertColors[i].x, vertColors[i].y, vertColors[i].z);
            }
        }
    }
}
