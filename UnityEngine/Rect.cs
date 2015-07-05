using System;

namespace UnityEngine
{
    /// <summary>
    /// 通过x，y位置以及宽度、高度加以定义的2维矩形。
    /// <para>Rect结构主要用于2维操作。UnityGUI系统广泛地使用此结构，并且也被用来设置摄像机视野的显示屏位置。</para>
    /// <para>矩形可以通过两种方式加以指定。第一种方式需要提供左上角坐标以及宽高。这通过x，y，width，height属性实现。</para>
    /// <para>第二种指定矩形的方式为，提供它的左右两边的X坐标以及它的上下两边的Y坐标。通过xMin，xMax，yMin，yMax属性来表示。</para>
    /// <para>尽管x、y属性可能看起来与xMin、xMax一样，实际上它们的行为有些微不同。x与y值被假定与width和height一同使用。这意味着，如果你改变了x或者y而未改变width或者height，那么矩形会改变位置，但保持大小不变。另一方面，如果你改变了xMin或者yMin的值，却没有改变xMax或者yMax，那么这个矩的大小将会改变并且它的左上角位置也会发生变化。</para>
    /// <para>参见：GUI Scripting Guide, Camera.rect, Camera.pixelRect.</para>
    /// </summary>
    public struct Rect
    {
        /// <summary>
        /// 依据已经存在的Rect对象创建副本。
        /// </summary>
        /// <param name="source">已存在的Rect</param>
        public Rect(Rect source):this() { }
        /// <summary>
        /// 创建一个新的矩形。
        /// </summary>
        /// <param name="left">左边的x坐标</param>
        /// <param name="top">上边的y坐标</param>
        /// <param name="width">矩形的宽</param>
        /// <param name="height">矩形的高</param>
        public Rect(float left, float top, float width, float height):this() { }
        /// <summary>
        /// 如果两个矩形不相同，那么返回true.
        /// </summary>
        /// <param name="lhs">不等式左边</param>
        /// <param name="rhs">不等式右边</param>
        /// <returns>两个矩形是否不等</returns>
        public static bool operator !=(Rect lhs, Rect rhs) { return default(bool); }
        /// <summary>
        /// 如果两个矩形相同，那么返回true.
        /// </summary>
        /// <param name="lhs">等式左边</param>
        /// <param name="rhs">等式右边</param>
        /// <returns>两个矩形是否相等</returns>
        public static bool operator ==(Rect lhs, Rect rhs) { return default(bool); }

        [Obsolete("use yMax")]
        public float bottom { get { return default(float); } }
        /// <summary>
        /// 矩形的中心坐标
        /// </summary>
        public Vector2 center { get; set; }
        /// <summary>
        /// 矩形的高度
        /// </summary>
        public float height { get; set; }
        [Obsolete("use xMin")]
        public float left { get { return default(float); } }
        /// <summary>
        /// 矩形的右上角。
        /// <para>改变此值将会保持左边与底边不变（因此width与height也将会改变）。</para>
        /// </summary>
        public Vector2 max { get; set; }
        /// <summary>
        /// 矩形的左下角。
        /// <para>改变此值将会保持右边与上边不变（因此width与height也将会改变）。</para>
        /// </summary>
        public Vector2 min { get; set; }
        /// <summary>
        /// 矩形的左上角坐标。
        /// <para>这是组合成Vector2的x、y坐标。</para>
        /// </summary>
        public Vector2 position { get; set; }
        [Obsolete("use xMax")]
        public float right { get { return default(float); } }
        /// <summary>
        /// 矩形的大小。
        /// <para>这是组合成Vector2的width和height.</para>
        /// </summary>
        public Vector2 size { get; set; }
        [Obsolete("use yMin")]
        public float top { get { return default(float); } }
        /// <summary>
        /// 矩形的宽度
        /// </summary>
        public float width { get; set; }
        /// <summary>
        /// 矩形的左边的坐标
        /// </summary>
        public float x { get; set; }
        /// <summary>
        /// 矩形的右边的坐标。
        /// <para>改变此值会保持矩形的左边不变（因此width也将会发生改变）。</para>
        /// </summary>
        public float xMax { get; set; }
        /// <summary>
        /// 矩形的左边的坐标。
        /// <para>改变此值会保持矩形的右边不变（因此width也将会发生改变）。</para>
        /// </summary>
        public float xMin { get; set; }
        /// <summary>
        /// 矩形的上边的坐标
        /// </summary>
        public float y { get; set; }
        /// <summary>
        /// 矩形的底边坐标。
        /// <para>改变此值将会保持矩形的上边不变（因此height也将会发生改变）。</para>
        /// </summary>
        public float yMax { get; set; }
        /// <summary>
        /// 矩形的上边坐标。
        /// <para>改变此值将会保持矩形的底边不变（因此height也将会发生改变）。</para>
        /// </summary>
        public float yMin { get; set; }
        /// <summary>
        /// 如果point的x、y分量所构成的点在该矩形内，那么返回true.
        /// </summary>
        /// <param name="point">要测试的点</param>
        /// <returns>是否在矩形内</returns>
        public bool Contains(Vector2 point) { return default(bool); }
        /// <summary>
        /// 如果point的x、y分量所构成的点在该矩形内，那么返回true.
        /// </summary>
        /// <param name="point">要测试的点</param>
        /// <returns>是否在矩形内</returns>
        public bool Contains(Vector3 point) { return default(bool); }
        /// <summary>
        /// 如果point的x、y分量所构成的点在该矩形内，那么返回true.
        /// <para>如果allowInverse的值为true，那么矩形的宽和高允许取负值（例如，min值比max值大），并且测试仍然可以正常工作。</para>
        /// </summary>
        /// <param name="point">要测试的点</param>
        /// <param name="allowInverse">是否允许宽高取负值</param>
        /// <returns>是否在矩形内</returns>
        public bool Contains(Vector3 point, bool allowInverse) { return default(bool); }
        /// <summary>
        /// 确定指定的 System.Object 是否等于当前的 Rect。
        /// </summary>
        /// <param name="other">要与当前对象进行比较的对象。</param>
        /// <returns>如果指定的对象等于当前对象，则为 true；否则为 false。</returns>
        public override bool Equals(object other) { return default(bool); }
        /// <summary>
        /// 哈希函数。
        /// </summary>
        /// <returns>当前Rect对象的哈希代码。</returns>
        public override int GetHashCode() { return default(int); }
        /// <summary>
        /// 根据min/max坐标值来创建一个矩形。
        /// </summary>
        /// <param name="left">左边的坐标</param>
        /// <param name="top">上边的坐标</param>
        /// <param name="right">右边的坐标</param>
        /// <param name="bottom">底边的坐标</param>
        /// <returns>符合指定参数的矩形</returns>
        public static Rect MinMaxRect(float left, float top, float right, float bottom) { return default(Rect); }
        /// <summary>
        /// 根据规范化后的坐标，返回位于某个矩形内的坐标点。
        /// </summary>
        /// <param name="rectangle">某个矩形</param>
        /// <param name="normalizedRectCoordinates">规范化后的坐标</param>
        /// <returns>矩形内的坐标点</returns>
        public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates) { return default(Vector2); }
        /// <summary>
        /// 如果其他矩形与此矩形重叠，那么返回true.
        /// </summary>
        /// <param name="other">测试重叠的其他矩形</param>
        /// <returns>是否重叠</returns>
        public bool Overlaps(Rect other) { return default(bool); }
        /// <summary>
        /// 如果其他矩形与此矩形重叠，那么返回true.
        /// <para>如果allowInverse为true，那么这两个矩形的宽与高允许取负值（例如，min值比max大），并且测试工作依然正常工作。</para>
        /// </summary>
        /// <param name="other"></param>
        /// <param name="allowInverse"></param>
        /// <returns></returns>
        public bool Overlaps(Rect other, bool allowInverse) { return default(bool); }
        /// <summary>
        /// 根据位于某矩形内的坐标点，返回规范化后的坐标。
        /// </summary>
        /// <param name="rectangle">某矩形</param>
        /// <param name="point">位于矩形内的坐标点</param>
        /// <returns>规范化后的坐标</returns>
        public static Vector2 PointToNormalized(Rect rectangle, Vector2 point) { return default(Vector2); }
        /// <summary>
        /// 设置一个已存在的矩形的各个成份。
        /// </summary>
        /// <param name="left">左边的坐标</param>
        /// <param name="top">上边的坐标</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        public void Set(float left, float top, float width, float height) { }
        /// <summary>
        /// 返回当前矩形的良好格式化的字符串。
        /// </summary>
        /// <returns>该矩形的字符串表达</returns>
        public override string ToString() { return default(string); }
        /// <summary>
        /// 返回当前矩形的良好格式化的字符串。
        /// </summary>
        /// <param name="format">格式化字符串</param>
        /// <returns>该矩形的字符串表达</returns>
        public string ToString(string format) { return default(string); }
    }
}