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
        public static CVector3D[] pointList = {
                                            new CVector3D(-1,  1, 0),
                                            new CVector3D(-1, -1, 0),
                                            new CVector3D(1, -1, 0),
                                            new CVector3D(1, 1, 0),
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

        public static CVector3D[] vertColors = {
                                              new CVector3D( 0, 1, 0), new CVector3D( 0, 0, 1), new CVector3D( 1, 0, 0),
                                               new CVector3D( 0, 1, 0), new CVector3D( 1, 0, 0), new CVector3D( 0, 0, 1),
                                         };
    }
}
