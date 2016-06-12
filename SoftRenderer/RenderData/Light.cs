using SoftRenderer.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.RenderData
{
    /// <summary>
    /// 灯光信息
    /// </summary>
    public struct Light
    {
        /// <summary>
        /// 灯光时间坐标
        /// </summary>
        public Vector3D worldPosition;
        /// <summary>
        /// 灯光颜色
        /// </summary>
        public Color lightColor;

        public Light(Vector3D worldPosition, Color lightColor)
        {
            this.worldPosition = worldPosition;
            this.lightColor = lightColor;
        }
    }
}
