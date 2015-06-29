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
        public Color(float r, float g, float b) : this() { }
        /// <summary>
        /// 使用指定的 r，g，b，a 分量来创建一个新颜色。
        /// </summary>
        /// <param name="r">红色成分。</param>
        /// <param name="g">绿色成分。</param>
        /// <param name="b">蓝色成分。</param>
        /// <param name="a">不透明度成分。</param>
        public Color(float r, float g, float b, float a) : this() { }
        /// <summary>
        /// 从颜色a减去颜色b.各个分量分别相减。
        /// </summary>
        /// <param name="a">颜色a</param>
        /// <param name="b">颜色b</param>
        /// <returns>相减后的颜色</returns>
        public static Color operator -(Color a, Color b) { return default(Color); }
        public static bool operator !=(Color lhs, Color rhs) { return default(bool); }
        /// <summary>
        /// 将两个颜色相乘。各个分量分别相乘。
        /// </summary>
        /// <param name="a">颜色a</param>
        /// <param name="b">颜色b</param>
        /// <returns>相乘后的颜色</returns>
        public static Color operator *(Color a, Color b) { return default(Color); }
        /// <summary>
        /// 将某个颜色的各个分量都乘以同一个值，进行缩放。
        /// </summary>
        /// <param name="a">颜色a</param>
        /// <param name="b">缩放值b</param>
        /// <returns>缩放后的颜色</returns>
        public static Color operator *(Color a, float b) { return default(Color); }
        /// <summary>
        /// 将某个颜色的各个分量都乘以同一个值，进行缩放。
        /// </summary>
        /// <param name="a">颜色a</param>
        /// <param name="b">缩放值b</param>
        /// <returns>缩放后的颜色</returns>
        public static Color operator *(float b, Color a) { return default(Color); }
        /// <summary>
        /// 将颜色的各个分量分别除以同一个值。每个分量被分别缩放。
        /// </summary>
        /// <param name="a">颜色</param>
        /// <param name="b">除数</param>
        /// <returns>缩放后的颜色</returns>
        public static Color operator /(Color a, float b) { return default(Color); }
        /// <summary>
        /// 将两个颜色相加，它们的各个分量分别相加。
        /// </summary>
        /// <param name="a">颜色a</param>
        /// <param name="b">颜色b</param>
        /// <returns>相加后的颜色</returns>
        public static Color operator +(Color a, Color b) { return default(Color); }
        public static bool operator ==(Color lhs, Color rhs) { return default(bool); }
        /// <summary>
        /// 隐式地从Color类型转换成Vector4类型。
        /// </summary>
        /// <param name="c">要转换的Color</param>
        /// <returns>转换后的Vector4</returns>
        public static implicit operator Vector4(Color c) { return default(Vector4); }
        /// <summary>
        /// 隐式地从Vector4类型转换成Color类型。
        /// </summary>
        /// <param name="v">要转换的Vector4</param>
        /// <returns>转换后的Color</returns>
        public static implicit operator Color(Vector4 v) { return default(Color); }
        /// <summary>
        /// 实心的黑色。RGBA值为（0，0，0，1）。
        /// </summary>
        public static Color black { get { return default(Color); } }
        /// <summary>
        /// 实心的蓝色。RGBA值为（0，0，1，1）。
        /// </summary>
        public static Color blue { get { return default(Color); } }
        /// <summary>
        /// 完全的透明。RGBA值为（0，0，0，0）。
        /// </summary>
        public static Color clear { get { return default(Color); } }
        /// <summary>
        /// 青色。RGBA值为（0，1，1，1）。
        /// </summary>
        public static Color cyan { get { return default(Color); } }
        /// <summary>
        /// 应用了伽玛曲线后的颜色。
        /// </summary>
        public Color gamma { get { return default(Color); } }
        /// <summary>
        /// 灰色。RGBA值为（0.5，0.5，0.5，1）。
        /// </summary>
        public static Color gray { get { return default(Color); } }
        /// <summary>
        /// 此颜色的灰度值。（只读）
        /// </summary>
        public float grayscale { get { return default(float); } }
        /// <summary>
        /// 实心的绿色。RGBA值为（0，1，0，1）。
        /// </summary>
        public static Color green { get { return default(Color); } }
        /// <summary>
        /// 同Color.gray，灰色的英式拼写。RGBA值为（0.5，0.5，0.5，1）。
        /// </summary>
        public static Color grey { get { return default(Color); } }
        /// <summary>
        /// 应用了逆伽玛曲线后的颜色。
        /// </summary>
        public Color linear { get { return default(Color); } }
        /// <summary>
        /// 洋红。RGBA值为（1，0，1，1）。
        /// </summary>
        public static Color magenta { get { return default(Color); } }
        /// <summary>
        /// 实心的红色。RGBA值为（1，0，0，1）。
        /// </summary>
        public static Color red { get { return default(Color); } }
        /// <summary>
        /// 实心的白色。RGBA值为（1，1，1，1）。
        /// </summary>
        public static Color white { get { return default(Color); } }
        /// <summary>
        /// 黄色。虽然RGBA值为（1，0.92，0.016，1），但是这个颜色相当好看！
        /// </summary>
        public static Color yellow { get { return default(Color); } }
        /// <summary>
        /// 分别使用下标索引0，1，2，3来访问r、g、b、a分量。
        /// </summary>
        /// <param name="index">0，1，2，3分别对应r、g、b、a分量</param>
        /// <returns>指定的分量</returns>
        public float this[int index] { get { return default(float); } set { } }
        /// <summary>
        /// 确定指定的 System.Object 是否等于当前的 System.Object。
        /// </summary>
        /// <param name="other">要与当前对象进行比较的对象。</param>
        /// <returns>如果指定的对象等于当前对象，则为 true；否则为 false。</returns>
        public override bool Equals(object other) { return default(bool); }
        /// <summary>
        /// 哈希函数。
        /// </summary>
        /// <returns>当前 Color 的哈希代码。</returns>
        public override int GetHashCode() { return default(int); }
        /// <summary>
        /// 在颜色a与颜色b之间用参数t进行插值。
        /// <para>t被压紧到0到1之间。当t是0时返回颜色a.当t是1时返回颜色b.</para>
        /// </summary>
        /// <param name="a">颜色a</param>
        /// <param name="b">颜色b</param>
        /// <param name="t">插值参数</param>
        /// <returns>插值颜色</returns>
        public static Color Lerp(Color a, Color b, float t) { return default(Color); }
        /// <summary>
        /// 返回当前颜色的良好地格式化的字符串表达
        /// </summary>
        /// <returns>该颜色的字符串表达</returns>
        public override string ToString() { return default(string); }
        /// <summary>
        /// 返回当前颜色的良好地格式化的字符串表达
        /// </summary>
        /// <param name="format">格式化字符串</param>
        /// <returns>该颜色的字符串表达</returns>
        public string ToString(string format) { return default(string); }
    }
}
