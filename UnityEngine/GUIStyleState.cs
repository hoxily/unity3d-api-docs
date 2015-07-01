using System;

namespace UnityEngine
{
    /// <summary>
    /// GUIStyle对象所使用的针对给定状态的具体的值。
    /// <para>GUIStyle包含所有用于显示GUI元素的值。</para>
    /// </summary>
    [Serializable]
    public sealed class GUIStyleState
    {
        public GUIStyleState() { }
        /// <summary>
        /// 在此给定状态下GUI元素所使用的背景图像。
        /// </summary>
        public Texture2D background { get; set; }
        /// <summary>
        /// 在此给定状态下GUI元素的文本的颜色。
        /// </summary>
        public Color textColor { get; set; }
    }
}