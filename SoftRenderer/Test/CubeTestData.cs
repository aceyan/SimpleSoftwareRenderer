using SoftRenderer.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Test
{
    /// <summary>
    /// 正方形测试数据
    /// </summary>
    public class CubeTestData
    {
        //顶点坐标
        public static CVector3D[] pointList = {
                                            new CVector3D(-1,  1, -1),
                                            new CVector3D(-1, -1, -1),
                                            new CVector3D(1, -1, -1),
                                            new CVector3D(1, 1, -1),

                                            new CVector3D( -1,  1, 1),
                                            new CVector3D(-1, -1, 1),
                                            new CVector3D(1, -1, 1),
                                            new CVector3D(1, 1, 1)
                                        };
        //三角形顶点索引 12个面
        public static int[] indexs = {   0,1,2,
                                   0,2,3,
                                   //
                                   7,6,5,
                                   7,5,4,
                                   //
                                   0,4,5,
                                   0,5,1,
                                   //
                                   1,5,6,
                                   1,6,2,
                                   //
                                   2,6,7,
                                   2,7,3,
                                   //
                                   3,7,4,
                                   3,4,0
                               };

        //uv坐标
        public static Point2D[] uvs ={
                                   new Point2D(0, 1),new Point2D( 1, 1),new Point2D(1, 0),
                                   new Point2D(0, 1),new Point2D(1, 0),new Point2D(0, 0),
                                   //
                                    new Point2D(0, 1),new Point2D( 1, 1),new Point2D(1, 0),
                                   new Point2D(0, 1),new Point2D(1, 0),new Point2D(0, 0),
                                   //
                                    new Point2D(0, 1),new Point2D( 1, 1),new Point2D(1, 0),
                                   new Point2D(0, 1),new Point2D(1, 0),new Point2D(0, 0),
                                   //
                                    new Point2D(0, 1),new Point2D( 1, 1),new Point2D(1, 0),
                                   new Point2D(0, 1),new Point2D(1, 0),new Point2D(0, 0),
                                   //
                                    new Point2D(0, 1),new Point2D( 1, 1),new Point2D(1, 0),
                                   new Point2D(0, 1),new Point2D(1, 0),new Point2D(0, 0),
                                   ///
                                    new Point2D(0, 1),new Point2D( 1, 1),new Point2D(1, 0),
                                   new Point2D(0, 1),new Point2D(1, 0),new Point2D(0, 0)
                              };

        public static CVector3D[] vertColors = {
                                             new CVector3D( 0, 1, 0), new CVector3D( 0, 0, 1), new CVector3D( 1, 0, 0),
                                               new CVector3D( 0, 1, 0), new CVector3D( 1, 0, 0), new CVector3D( 0, 0, 1),
                                               //
                                                new CVector3D( 0, 1, 0), new CVector3D( 0, 0, 1), new CVector3D( 1, 0, 0),
                                               new CVector3D( 0, 1, 0), new CVector3D( 1, 0, 0), new CVector3D( 0, 0, 1),
                                               //
                                                new CVector3D( 0, 1, 0), new CVector3D( 0, 0, 1), new CVector3D( 1, 0, 0),
                                               new CVector3D( 0, 1, 0), new CVector3D( 1, 0, 0), new CVector3D( 0, 0, 1),
                                               //
                                                new CVector3D( 0, 1, 0), new CVector3D( 0, 0, 1), new CVector3D( 1, 0, 0),
                                               new CVector3D( 0, 1, 0), new CVector3D( 1, 0, 0), new CVector3D( 0, 0, 1),
                                               //
                                                new CVector3D( 0, 1, 0), new CVector3D( 0, 0, 1), new CVector3D( 1, 0, 0),
                                               new CVector3D( 0, 1, 0), new CVector3D( 1, 0, 0), new CVector3D( 0, 0, 1),
                                               //
                                                new CVector3D( 0, 1, 0), new CVector3D( 0, 0, 1), new CVector3D( 1, 0, 0),
                                               new CVector3D( 0, 1, 0), new CVector3D( 1, 0, 0), new CVector3D( 0, 0, 1)
                                         };
    }
}
