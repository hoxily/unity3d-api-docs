using System;

namespace UnityEngine
{
    /// <summary>
    /// GUI元素的内容。
    /// <para>此类需要与GUIStyle紧密合作。GUIContent定义了要渲染什么，而GUIStyle定义了要如何渲染它。</para>
    /// <para>参见：<seealso cref="GUIStyle"/></para>
    /// </summary>
    [Serializable]
    public sealed class GUIContent
    {
        /// <summary>
        /// 空内容的简写。
        /// </summary>
        public static GUIContent none;
        /// <summary>
        /// <para>所有形状与尺寸的GUIContent的构造器。</para>
        /// <para>创建一个空的GUIContent。</para>
        /// </summary>
        public GUIContent() { }
        /// <summary>
        /// <para>所有形状与尺寸的GUIContent的构造器。</para>
        /// <para>创建一个已经存在的GUIContent对象的副本。</para>
        /// </summary>
        /// <param name="src"></param>
        public GUIContent(GUIContent src) { }
        /// <summary>
        /// <para>所有形状与尺寸的GUIContent的构造器。</para>
        /// <para>创建一个仅含有文本的GUIContent对象。</para>
        /// <para>在使用GUI时，你不需要为简单的文本字符串创建GUIContents——下面的两行代码在功能上是等价的：</para>
        /// <para>GUI.Button(new Rect(0,0,100,20), "Click Me");</para>
        /// <para>GUI.Button(new Rect(0,30,100,20), new GUIContent("Click Me"));</para>
        /// </summary>
        /// <param name="text">文本</param>
        public GUIContent(string text) { }
        /// <summary>
        /// <para>所有形状与尺寸的GUIContent的构造器。</para>
        /// <para>创建一个仅含有一张图像的GUIContent对象。</para>
        /// </summary>
        /// <param name="image">图像</param>
        public GUIContent(Texture image) { }
        /// <summary>
        /// <para>所有形状与尺寸的GUIContent的构造器。</para>
        /// <para>创建一个含有一些文本的GUIContent对象。当用户将鼠标悬浮在它上面时，全局的GUI.tooltip会被赋值为此对象的tooltip.</para>
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="tooltip">工具提示信息</param>
        public GUIContent(string text, string tooltip) { }
        /// <summary>
        /// <para>所有形状与尺寸的GUIContent的构造器。</para>
        /// <para>创建一个同时包含文本与图像的GUIContent对象。</para>
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="image">图像</param>
        public GUIContent(string text, Texture image) { }
        /// <summary>
        /// <para>所有形状与尺寸的GUIContent的构造器。</para>
        /// <para>创建一个含有一张图像的GUIContent对象。当用户将鼠标悬浮在它上面时，全局的GUI.tooltip会被赋值为此对象的tooltip.</para>
        /// </summary>
        /// <param name="image">图像</param>
        /// <param name="tooltip">工具提示信息</param>
        public GUIContent(Texture image, string tooltip) { }
        /// <summary>
        /// <para>所有形状与尺寸的GUIContent的构造器。</para>
        /// <para>创建一个同时含有文本、图像以及定义了工具提示信息的GUIContent对象。当用户将鼠标悬浮在它上面时，全局的GUI.tooltip会被赋值为此对象的tooltip.</para>
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="image">图像</param>
        /// <param name="tooltip">工具提示信息</param>
        public GUIContent(string text, Texture image, string tooltip) { }
        /// <summary>
        /// 所含的图标图像
        /// </summary>
        public Texture image { get; set; }
        /// <summary>
        /// 所含的文本
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 所含的工具提示信息
        /// </summary>
        public string tooltip { get; set; }
    }
}