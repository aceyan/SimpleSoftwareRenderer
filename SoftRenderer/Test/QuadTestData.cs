using SoftRenderer.Math;
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

        public static Vector3D[] vertColors = {
                                              new Vector3D( 0, 1, 0), new Vector3D( 0, 0, 1), new Vector3D( 1, 0, 0),
                                               new Vector3D( 0, 1, 0), new Vector3D( 1, 0, 0), new Vector3D( 0, 0, 1),
                                         };

        public static Vector3D[] norlmas = {
                                                new Vector3D( 0, 1, -1, 0), new Vector3D( 0, 0, 1), new Vector3D( 1, 0, 0),
                                               new Vector3D( 0, 1, 0), new Vector3D( 1, 0, 0), new Vector3D( 0, 0, 1),
                                            };
    }
}
