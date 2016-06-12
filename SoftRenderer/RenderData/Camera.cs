using SoftRenderer.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.RenderData
{
    /// <summary>
    /// 相机数据
    /// </summary>
    public struct Camera
    {
        public Vector3D pos;
        public Vector3D lookAt;
        public Vector3D up;
        /// <summary>
        /// 观察角，弧度
        /// </summary>
        public float fov;
        /// <summary>
        /// 长宽比
        /// </summary>
        public float aspect;
        /// <summary>
        /// 近裁平面
        /// </summary>
        public float zn;
        /// <summary>
        /// 远裁平面
        /// </summary>
        public float zf;

        public Camera(Vector3D pos, Vector3D lookAt, Vector3D up, float fov, float aspect, float zn, float zf)
        {
            this.pos = pos;
            this.lookAt = lookAt;
            this.up = up;
            this.fov = fov;
            this.aspect = aspect;
            this.zn = zn;
            this.zf = zf;
        }
    }
}
