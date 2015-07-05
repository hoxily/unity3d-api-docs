using System;
using System.Collections;

namespace UnityEngine
{
    /// <summary>
    /// 定义GUI的样子以及行为。
    /// <para>GUISkin包含GUI设定和一批GUIStyle对象。</para>
    /// <para>当前生效GUI皮肤通过GUI.skin读取或者设置。</para>
    /// </summary>
    [Serializable]
    [ExecuteInEditMode]
    public sealed class GUISkin : ScriptableObject
    {
        public GUISkin() { }

        public GUIStyle box { get; set; }
        public GUIStyle button { get; set; }
        public GUIStyle[] customStyles { get; set; }
        public Font font { get; set; }
        public GUIStyle horizontalScrollbar { get; set; }
        public GUIStyle horizontalScrollbarLeftButton { get; set; }
        public GUIStyle horizontalScrollbarRightButton { get; set; }
        public GUIStyle horizontalScrollbarThumb { get; set; }
        public GUIStyle horizontalSlider { get; set; }
        public GUIStyle horizontalSliderThumb { get; set; }
        public GUIStyle label { get; set; }
        public GUIStyle scrollView { get; set; }
        public GUISettings settings { get { return default(GUISettings); } }
        public GUIStyle textArea { get; set; }
        public GUIStyle textField { get; set; }
        public GUIStyle toggle { get; set; }
        public GUIStyle verticalScrollbar { get; set; }
        public GUIStyle verticalScrollbarDownButton { get; set; }
        public GUIStyle verticalScrollbarThumb { get; set; }
        public GUIStyle verticalScrollbarUpButton { get; set; }
        public GUIStyle verticalSlider { get; set; }
        public GUIStyle verticalSliderThumb { get; set; }
        public GUIStyle window { get; set; }
        /// <summary>
        /// 尝试查找一个GUIStyle对象。此函数可能返回null而不会给出错误。
        /// </summary>
        /// <param name="styleName">所查找的GUIStyle对象的名字</param>
        /// <returns>如果没有找到返回null</returns>
        public GUIStyle FindStyle(string styleName) { return default(GUIStyle); }
        public IEnumerator GetEnumerator() { return default(IEnumerator); }
        /// <summary>
        /// 获取指定名字的GUIStyle对象。
        /// </summary>
        /// <param name="styleName">名字</param>
        /// <returns></returns>
        public GUIStyle GetStyle(string styleName) { return default(GUIStyle); }
    }
}