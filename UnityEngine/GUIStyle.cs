using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    /// <summary>
    /// 用于GUI元素的样式信息。
    /// <para>大部分GUI函数接受一个可选的GUIStyle参数来覆盖默认样式。这允许针对不同的状态（例如，当鼠标正悬浮在控件上方时）改变或者切换色彩、字体以及其他细节。在整个GUI设计里需要一个一至的外观和感觉时，GUISkin类正是一种好的方式，它收集一系列GUIStyle设置并且一次性应用这些样式。</para>
    /// </summary>
    [Serializable]
    public sealed class GUIStyle
    {
        /// <summary>
        /// 创建一个空的GUIStyle对象。
        /// </summary>
        public GUIStyle() { }
        /// <summary>
        /// 从已存在的其他GUIStyle对象创建副本。
        /// </summary>
        /// <param name="other">已存在的GUIStyle对象</param>
        public GUIStyle(GUIStyle other) { }
        /// <summary>
        /// 从当前皮肤里获取指定名字的GUIStyle
        /// </summary>
        /// <param name="str">要获取的GUIStyle的名字</param>
        /// <returns>指定名字的GUIStyle</returns>
        public static implicit operator GUIStyle(string str) { return default(GUIStyle); }
        /// <summary>
        /// 当控件被按下时的渲染设置。
        /// </summary>
        public GUIStyleState active { get; set; }
        /// <summary>
        /// 文本的对齐。
        /// </summary>
        public TextAnchor alignment { get; set; }
        /// <summary>
        /// 所有背景图像的边框。
        /// <para>这相当于GUITexture的边框设置。它仅仅影响背景图像的渲染，而对定位无影响。</para>
        /// </summary>
        public RectOffset border { get; set; }
        [Obsolete("Don't use clipOffset - put things inside begingroup instead. This functionality will be removed in a later version.")]
        public Vector2 clipOffset { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TextClipping clipping { get; set; }
        /// <summary>
        /// 应用于此GUIStyle内容的像素偏移。
        /// </summary>
        public Vector2 contentOffset { get; set; }
        /// <summary>
        /// 如果非0，那么任何以此样式渲染的GUI元素都将拥有此指定高度。
        /// </summary>
        public float fixedHeight { get; set; }
        /// <summary>
        /// 如果非0，那么任何以此样式渲染的GUI元素都将拥有此指定宽度。
        /// </summary>
        public float fixedWidth { get; set; }
        /// <summary>
        /// 当键盘焦点在此元素上时的渲染设定。
        /// </summary>
        public GUIStyleState focused { get; set; }
        /// <summary>
        /// 用于渲染的字体。如果置为null，那么使用当前GUISkin的默认字体代替。
        /// </summary>
        public Font font { get; set; }
        /// <summary>
        /// 要使用的字体大小（针对动态字体）。
        /// <para>如果此属性被设置为非零值，那么字体导入器中指定的字体大小被此定制大小覆盖。此属性仅在那些设置为动态字体渲染的字体上有效。其他的字体总是使用默认字体大小。</para>
        /// </summary>
        public int fontSize { get; set; }
        /// <summary>
        /// 要使用的字体样式（针对动态字体）。
        /// <para>如果此属性被设置为normal之外的样式，那么字体导入器中指定的字体样式被此定制样式覆盖。此属性仅在那些设置为动态字体渲染的字体上有效。其他的字体总是以默认字体样式进行渲染。</para>
        /// </summary>
        public FontStyle fontStyle { get; set; }
        /// <summary>
        /// 当鼠标悬浮在控件正上方时的渲染设定。
        /// </summary>
        public GUIStyleState hover { get; set; }
        /// <summary>
        /// GUIContent里的图像与文本该如何组合在一起。
        /// </summary>
        public ImagePosition imagePosition { get; set; }
        public bool isHeightDependantOnWidth { get { return default(bool); } }
        /// <summary>
        /// 以此样式渲染时文本的每行的高度，以像素为单位计量。（只读）
        /// </summary>
        public float lineHeight { get { return default(float); } }
        /// <summary>
        /// 以此样式渲染的元素与其他GUI元素之间的边距。
        /// <para>此属性仅在使用自动布局时有效（参见：<seealso cref="GUILayout"/>）。</para>
        /// </summary>
        public RectOffset margin { get; set; }
        /// <summary>
        /// 此GUIStyle的名字。用于依据名字查找样式。
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 空GUIStyle的简写。
        /// <para>该样式不包含任何装饰，并且仅仅以默认的字体渲染所有东西。</para>
        /// </summary>
        public static GUIStyle none { get { return default(GUIStyle); } }
        /// <summary>
        /// 当组件是平常状态显示时的渲染设定。
        /// </summary>
        public GUIStyleState normal { get; set; }
        /// <summary>
        /// 当元素处于打开并且被按下时的渲染设定。
        /// </summary>
        public GUIStyleState onActive { get; set; }
        /// <summary>
        /// 当元素处于打开并且有键盘焦点时的渲染设定。
        /// </summary>
        public GUIStyleState onFocused { get; set; }
        /// <summary>
        /// 当控件是打开的并且鼠标正悬浮在其上方时的渲染设定
        /// </summary>
        public GUIStyleState onHover { get; set; }
        /// <summary>
        /// 当控件是打开时渲染设定。
        /// </summary>
        public GUIStyleState onNormal { get; set; }
        /// <summary>
        /// 加到背景图像的额外的空间。
        /// <para>这在你的图像拥有一个阴影并且你想要扩大背景图像使其超出此样式规定的GUI元素的矩形时非常有用。</para>
        /// </summary>
        public RectOffset overflow { get; set; }
        /// <summary>
        /// 从GUIStyle规定的边沿到开始实际内容之间的填充空间（内边距）。
        /// </summary>
        public RectOffset padding { get; set; }
        /// <summary>
        /// 是否允许使用HTML风格的标签来用于文本格式标记。
        /// <para>参见关于Rich Text的手册页以获得受支持的标签的列表。</para>
        /// </summary>
        public bool richText { get; set; }
        /// <summary>
        /// 是否允许GUI元素被垂直拉伸以获得更好的布局。
        /// </summary>
        public bool stretchHeight { get; set; }
        /// <summary>
        /// 是否允许GUI元素被水平拉伸以获得更好的布局。
        /// </summary>
        public bool stretchWidth { get; set; }
        /// <summary>
        /// 文本是否要自动换行。
        /// <para>此属性将会导致包含的任何文字自动换行以适应控件的宽度。</para>
        /// </summary>
        public bool wordWrap { get; set; }
        /// <summary>
        /// 当使用指定的内容以及指定的宽度进行渲染时，此元素会有多高。
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="width">宽度</param>
        /// <returns>高度</returns>
        public float CalcHeight(GUIContent content, float width) { return default(float); }
        /// <summary>
        /// 当使用指定的内容进行渲染时，计算出最小宽度与最大宽度。
        /// <para>被GUILayout用于正确地处理元素的自动换行。</para>
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="minWidth">最小宽度</param>
        /// <param name="maxWidth">最大宽度</param>
        public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { minWidth = default(float); maxWidth = default(float); }
        public Vector2 CalcScreenSize(Vector2 contentSize) { return default(Vector2); }
        public Vector2 CalcSize(GUIContent content) { return default(Vector2); }
        [ExcludeFromDocs]
        public void Draw(Rect position, GUIContent content, int controlID) { }
        public void Draw(Rect position, GUIContent content, int controlID, bool on) { }
        public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }
        public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }
        public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }
        public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }
        public void DrawCursor(Rect position, GUIContent content, int controlID, int Character) { }
        public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }
        public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { return default(Vector2); }
        public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { return default(int); }
        public override string ToString() { return default(string); }
    }
}