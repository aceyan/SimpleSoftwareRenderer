using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftRenderer.Math
{
    /// <summary>
    /// 4*4矩阵，行优先存储
    /// </summary>
    public class CMatrix4x4
    {
        private float[,] _m = new float[4, 4];

        public CMatrix4x4()
        {

        }
        public CMatrix4x4(float a1, float a2, float a3, float a4,
            float b1, float b2, float b3, float b4,
            float c1, float c2, float c3, float c4,
            float d1, float d2, float d3, float d4)
        {
            _m[0, 0] = a1;  _m[0, 1] = a2;  _m[0, 2] = a3;  _m[0, 3] = a4;
            //
            _m[1, 0] = b1;  _m[1, 1] = b2;  _m[1, 2] = b3;  _m[1, 3] = b4;
            //
            _m[2, 0] = c1;  _m[2, 1] = c2;  _m[2, 2] = c3;  _m[2, 3] = c4;
            //
            _m[3, 0] = d1;  _m[3, 1] = d2;  _m[3, 2] = d3;  _m[3, 3] = d4;
        }

        /// <summary>
        /// 矩阵乘法
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static CMatrix4x4 operator *(CMatrix4x4 lhs, CMatrix4x4 rhs)
        {
            CMatrix4x4 nm = new CMatrix4x4();
            nm.SetZero();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        nm._m[i, j] += lhs._m[i,k] * rhs._m[k, j];
                    }
                }
            }
            return nm;
        }

        public float this[int i,int j]
        {
            get { return _m[i,j]; }
            set { _m[i, j] = value; }
        }

        /// <summary>
        /// 单位化矩阵
        /// </summary>
        public void Identity()
        {
            _m[0, 0] = 1; _m[0, 1] = 0; _m[0, 2] = 0;  _m[0, 3] = 0;
            //
            _m[1, 0] = 0; _m[1, 1] = 1; _m[1, 2] = 0;  _m[1, 3] = 0;
            //
            _m[2, 0] = 0; _m[2, 1] = 0; _m[2, 2] = 1; _m[2, 3] = 0;
            //
            _m[3, 0] = 0; _m[3, 1] = 0; _m[3, 2] = 0; _m[3, 3] = 1;
        }

        public void SetZero()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    _m[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// 求转置
        /// </summary>
        /// <returns></returns>
        public CMatrix4x4 Transpose()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {

                    float temp = _m[i, j];
                    _m[i, j] = _m[j, i];
                    _m[j, i] = temp;
                }
            }
            return this;
        }
        /// <summary>
        /// 求矩阵行列式
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public float Determinate()
        {
            return Determinate(_m, 4);
        }
        
        private float Determinate(float[,] m, int n)
        {
            if(n == 1)
            {//递归出口
                return m[0, 0];
            }
            else
            {
                float result = 0;
                float[,] tempM = new float[n-1, n-1];
                for (int i = 0; i < n; i++)
                {
                    //求代数余子式
                    for (int j = 0; j < n - 1; j++)//行
                    {
                        for (int k = 0; k < n - 1; k++)//列
                        {
                            int x = j + 1;//原矩阵行
                            int y = k >= i ? k + 1 : k;//原矩阵列
                            tempM[j, k] = m[x, y];
                        }
                    }

                    result += (float)System.Math.Pow(-1, 1 + (1 + i)) * m[0, i] * Determinate(tempM, n - 1);
                }
                return result;
            }
        }
        /// <summary>
        /// 获取当前矩阵的伴随矩阵
        /// </summary>
        /// <returns></returns>
        public CMatrix4x4 GetAdjoint()
        {
            int x,y;
            float[,] tempM = new float[3,3];
            CMatrix4x4 result = new CMatrix4x4();
            for (int i = 0; i < 4; i++)
            {
                 for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            for (int t = 0; t < 3; ++t)
                            {
                                x = k >= i ? k + 1 : k;
                                y = t >= j ? t + 1 : t;

                                tempM[k,t] = _m[x,y];  
                            }
                        }
                        result._m[i, j] = (float)System.Math.Pow(-1, (1 + j) + (1 + i)) * Determinate(tempM, 3);
                    }
            }
            return result.Transpose();
        }
        /// <summary>
        /// 求当前矩阵的逆矩阵
        /// </summary>
        /// <returns></returns>
        public CMatrix4x4 Inverse()
        {
            float a = Determinate();
            if( a == 0)
            {
                Console.WriteLine("矩阵不可逆");
                return null;
            }
            CMatrix4x4 adj = GetAdjoint();//伴随矩阵
            for (int i = 0; i < 4; i++)
			{
                for (int j = 0; j < 4; j++)
                {
                    adj._m[i, j] = adj._m[i, j] / a;
                }
			}
            return adj;
        }
    }
}
