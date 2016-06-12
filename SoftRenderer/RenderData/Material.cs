using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.RenderData
{
    /// <summary>
    /// 材质
    /// </summary>
    public struct Material
    {
        /// <summary>
        /// 自发光颜色值
        /// </summary>
        public Color emissive;
        /// <summary>
        /// 环境光反射系数
        /// </summary>
        public float ka;
        /// <summary>
        /// 漫反射颜色值
        /// </summary>
        public Color diffuse;
        /// <summary>
        /// 镜面反射颜色值
        /// </summary>
        public Color specular;
        /// <summary>
        /// 光泽度
        /// </summary>
        public float shininess;

        public Material(Color emissive, float ka, Color diffuse, Color specular, float shininess)
        {
            this.emissive = emissive;
            this.ka = ka;
            this.diffuse = diffuse;
            this.specular = specular;
            this.shininess = shininess;
        }
    }
}
