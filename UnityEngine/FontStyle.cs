using System;

namespace UnityEngine
{
    /// <summary>
    /// 应用于GUI文本、文本网格以及GUIStyle上的字体样式。
    /// </summary>
    public enum FontStyle
    {
        /// <summary>
        /// 没有应用任何特殊样式。
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 粗体样式将会应用到你的文本上。
        /// </summary>
        Bold = 1,
        /// <summary>
        /// 斜体样式将会应用到你的文本上。
        /// </summary>
        Italic = 2,
        /// <summary>
        /// 粗体和斜体样式将会应用到你的文本上。
        /// </summary>
        BoldAndItalic = 3,
    }
}