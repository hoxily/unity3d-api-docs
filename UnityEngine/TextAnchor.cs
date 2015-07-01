using System;

namespace UnityEngine
{
    /// <summary>
    /// 文本锚点的摆放位置。
    /// <para>这被用于GUIText.anchor属性。</para>
    /// <para>参见：GUI Text 组件。</para>
    /// </summary>
    public enum TextAnchor
    {
        /// <summary>
        /// 文本被固定于左上角。
        /// </summary>
        UpperLeft = 0,
        /// <summary>
        /// 文本被固定于上方的水平中央处。
        /// </summary>
        UpperCenter = 1,
        /// <summary>
        /// 文本被固定于右上角。
        /// </summary>
        UpperRight = 2,
        /// <summary>
        /// 文本被固定于左侧的垂直中央处。
        /// </summary>
        MiddleLeft = 3,
        /// <summary>
        /// 文本被固定于水平和垂直的中央处。
        /// </summary>
        MiddleCenter = 4,
        /// <summary>
        /// 文本被固定于右侧的垂直中央处。
        /// </summary>
        MiddleRight = 5,
        /// <summary>
        /// 文本被固定于左下角。
        /// </summary>
        LowerLeft = 6,
        /// <summary>
        /// 文本被固定于下方的水平中央处。
        /// </summary>
        LowerCenter = 7,
        /// <summary>
        /// 文本被固定于右下角。
        /// </summary>
        LowerRight = 8,
    }
}
