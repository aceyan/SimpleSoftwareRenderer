using SoftRenderer.Math;
using SoftRenderer.RenderData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Test
{
    /// <summary>
    /// 四边形数据
    /// </summary>
    public class QuadTestData
    {
        //顶点坐标
        public static Vector3D[] pointList = {
                                            new Vector3D(-1,  1, 0),
                                            new Vector3D(-1, -1, 0),
                                            new Vector3D(1, -1, 0),
                                            new Vector3D(1, 1, 0),
                                        };
        //三角形顶点索引 12个面
        public static int[] indexs = {   0,1,2,
                                   0,2,3,
                               };

        //uv坐标
        public static Point2D[] uvs ={
                                   new Point2D(0, 1),new Point2D( 1, 1),new Point2D(1, 0),
                                   new Point2D(0, 1),new Point2D(1, 0),new Point2D(0, 0),
                              };
        //顶点色
        public static Vector3D[] vertColors = {
                                              new Vector3D( 0, 1, 0), new Vector3D( 0, 0, 1), new Vector3D( 1, 0, 0),
                                               new Vector3D( 0, 1, 0), new Vector3D( 1, 0, 0), new Vector3D( 0, 0, 1),
                                         };
        //法线
        public static Vector3D[] norlmas = {
                                                new Vector3D( 0, 0, -1), new Vector3D( 0, 0, -1), new Vector3D( 0, 0, -1),
                                               new Vector3D( 0, 0, -1), new Vector3D( 0, 0, -1), new Vector3D( 0, 0, -1),
                                            };
        //材质
        public static Material mat = new Material(new Color(0, 0, 0.1f), 0.1f, new Color(0.3f, 0.3f, 0.3f), new Color(1, 1, 1), 99);

    }
}
