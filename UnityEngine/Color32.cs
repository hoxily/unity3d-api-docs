using System;

namespace UnityEngine
{
    /// <summary>
    /// 以32比特格式描述的RGBA颜色。
    /// <para>每个颜色分量都是一个byte值，值的范围从0到255.</para>
    /// <para>成分（r，g，b）定义了 RGB 颜色空间里的一种颜色。Alpha成分（a）定义了透明度——alpha值为255时表示完全不透明，alpha值为0时表示完全透明。</para>
    /// </summary>
    public struct Color32
    {
        /// <summary>
        /// 颜色的Alpha分量
        /// </summary>
        public byte a;
        /// <summary>
        /// 颜色的蓝色分量
        /// </summary>
        public byte b;
        /// <summary>
        /// 颜色的绿色分量
        /// </summary>
        public byte g;
        /// <summary>
        /// 颜色的红色分量
        /// </summary>
        public byte r;
        /// <summary>
        /// 使用指定的r，g，b，a分量来构造一个新的颜色。
        /// </summary>
        /// <param name="r">颜色的红色分量</param>
        /// <param name="g">颜色的绿色分量</param>
        /// <param name="b">颜色的蓝色分量</param>
        /// <param name="a">颜色的不透明度分量</param>
        public Color32(byte r, byte g, byte b, byte a) : this() { }

        /// <summary>
        /// 隐式地从Color类型颜色转换到Color32类型的颜色
        /// </summary>
        /// <param name="c">要转换的Color颜色</param>
        /// <returns>转换完成的Color32颜色</returns>
        public static implicit operator Color32(Color c) { return default(Color32); }
        /// <summary>
        /// 隐式地从Color32类型颜色转换到Color类型的颜色
        /// </summary>
        /// <param name="c">要转换的Color32颜色</param>
        /// <returns>转换完成的Color颜色</returns>
        public static implicit operator Color(Color32 c) { return default(Color); }
        /// <summary>
        /// 在颜色a与颜色b之间用参数t进行插值。
        /// <para>t被压紧到0到1之间。当t是0时返回颜色a.当t是1时返回颜色b.</para>
        /// </summary>
        /// <param name="a">颜色a</param>
        /// <param name="b">颜色b</param>
        /// <param name="t">插值参数</param>
        /// <returns>插值颜色</returns>
        public static Color32 Lerp(Color32 a, Color32 b, float t) { return default(Color32); }
        /// <summary>
        /// 该颜色的字符串表达
        /// </summary>
        /// <returns>该颜色的字符串表达</returns>
        public override string ToString() { return default(string); }
        /// <summary>
        /// 返回该颜色的良好地格式化后的字符串
        /// </summary>
        /// <param name="format">格式化字符串</param>
        /// <returns>该颜色的字符串表达</returns>
        public string ToString(string format) { return default(string); }
    }
}