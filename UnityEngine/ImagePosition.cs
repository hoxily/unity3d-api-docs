using System;

namespace UnityEngine
{
    /// <summary>
    /// GUIStyle里面有关图像与文本如何布置。
    /// </summary>
    public enum ImagePosition
    {
        /// <summary>
        /// 图像在文本的左边。
        /// </summary>
        ImageLeft = 0,
        /// <summary>
        /// 图像在文本的上方。
        /// </summary>
        ImageAbove = 1,
        /// <summary>
        /// 仅显示图像。
        /// </summary>
        ImageOnly = 2,
        /// <summary>
        /// 仅显示文本。
        /// </summary>
        TextOnly = 3,
    }
}