using System;

namespace UnityEngine
{
    /// <summary>
    /// 矩形的偏移量，边框等等。
    /// </summary>
    [Serializable]
    public sealed class RectOffset
    {
        public RectOffset() { }
        /// <summary>
        /// 用指定的偏移量创建一个新矩形。
        /// </summary>
        /// <param name="left">左边的大小</param>
        /// <param name="right">右边的大小</param>
        /// <param name="top">上边的大小</param>
        /// <param name="bottom">底边的大小</param>
        public RectOffset(int left, int right, int top, int bottom) { }
        /// <summary>
        /// 底边的大小
        /// </summary>
        public int bottom { get; set; }
        /// <summary>
        /// 左边+右边的简写
        /// </summary>
        public int horizontal { get { return default(int); } }
        /// <summary>
        /// 左边的大小
        /// </summary>
        public int left { get; set; }
        /// <summary>
        /// 右边的大小
        /// </summary>
        public int right { get; set; }
        /// <summary>
        /// 上边的大小
        /// </summary>
        public int top { get; set; }
        /// <summary>
        /// 上边+底边的简写
        /// </summary>
        public int vertical { get { return default(int); } }
        /// <summary>
        /// 给一个矩形加上边框偏移量。
        /// </summary>
        /// <param name="rect">某矩形</param>
        /// <returns>加上边框后的新矩形</returns>
        public Rect Add(Rect rect) { return default(Rect); }
        /// <summary>
        /// 从一个矩形上移除边框偏移量。
        /// </summary>
        /// <param name="rect">某矩形</param>
        /// <returns>移除边框后的新矩形</returns>
        public Rect Remove(Rect rect) { return default(Rect); }
        /// <summary>
        /// 返回RectOffset的字符串表达
        /// </summary>
        /// <returns>表达RectOffset的字符串</returns>
        public override string ToString() { return default(string); }
    }
}
