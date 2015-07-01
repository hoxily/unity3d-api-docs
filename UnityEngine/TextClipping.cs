using System;

namespace UnityEngine
{
    /// <summary>
    /// 决定GUI系统遇到文本过大无法适应分配的矩形时如何处理的不同方式。
    /// </summary>
    public enum TextClipping
    {
        /// <summary>
        /// 文本自由地溢出元素之外。
        /// </summary>
        Overflow = 0,
        /// <summary>
        /// 文本被剪除以保证位于元素内。
        /// </summary>
        Clip = 1,
    }
}
