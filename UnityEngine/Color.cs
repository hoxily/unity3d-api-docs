namespace UnityEngine
{
    /// <summary>
    /// 描述 RGBA 颜色。
    /// <para>在Unity的各处，这个结构用于传递颜色。每个颜色分量是一个浮点值，取值范围从0到1.</para>
    /// <para>成分（r，g，b）定义了 RGB 颜色空间里的一种颜色。Alpha成分（a）定义了透明度——alpha值为壹时表示完全不透明，alpha值为零时表示完全透明。</para>
    /// </summary>
    public struct Color
    {
        /// <summary>
        /// 颜色的不透明度成分。
        /// </summary>
        public float a;
        /// <summary>
        /// 颜色的蓝色成分。
        /// </summary>
        public float b;
        /// <summary>
        /// 颜色的绿色成分。
        /// </summary>
        public float g;
        /// <summary>
        /// 颜色的红色成分。
        /// </summary>
        public float r;
        /// <summary>
        /// 使用指定的 r，g，b 分量来创建一个新颜色，设置 a 为 1.
        /// </summary>
        /// <param name="r">红色成分。</param>
        /// <param name="g">绿色成分。</param>
        /// <param name="b">蓝色成分。</param>
        public Color(float r, float g, float b):this(r,g,b,1.0f) { }
        /// <summary>
        /// 使用指定的 r，g，b，a 分量来创建一个新颜色。
        /// </summary>
        /// <param name="r">红色成分。</param>
        /// <param name="g">绿色成分。</param>
        /// <param name="b">蓝色成分。</param>
        /// <param name="a">不透明度成分。</param>
        public Color(float r, float g, float b, float a) { this.a = a; this.b = b; this.g = g; this.r = r; }
    }
}
