using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.RenderData
{
    /// <summary>
    /// 颜色值0-1
    /// </summary>
    public struct Color
    {
        public float r;
        public float g;
        public float b;

        public Color(float r, float g, float b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public Color(System.Drawing.Color c)
        {
            this.r = (float)c.R / 255;
            this.g = (float)c.G / 255;
            this.b = (float)c.B / 255;
        }
        /// <summary>
        /// 转换为系统的color
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Color TransFormToSystemColor()
        {
            float r = this.r  * 255;
            float g = this.g  * 255;
            float b = this.b  * 255;
            return System.Drawing.Color.FromArgb((int)r, (int)g, (int)b);
        }
        /// <summary>
        /// 颜色乘法，用于颜色混合，实际叫做Modulate（调制）
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Color operator * (Color a, Color b)
        {
            Color c = new Color();
            c.r = a.r * b.r;
            c.g = a.g * b.g;
            c.b = a.b * b.b;
            return c;
        }

        public static Color operator * (float a, Color b)
        {
            Color c = new Color();
            c.r = a * b.r;
            c.g = a * b.g;
            c.b = a * b.b;
            return c;
        }
        public static Color operator * (Color a, float b)
        {
            Color c = new Color();
            c.r = a.r * b;
            c.g = a.g * b;
            c.b = a.b * b;
            return c;
        }

        public static Color operator + (Color a, Color b)
        {
            Color c = new Color();
            c.r = a.r + b.r;
            c.g = a.g + b.g;
            c.b = a.b + b.b;
            return c;
        }
    }
}
