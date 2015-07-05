using System;

namespace UnityEngine
{
    /// <summary>
    /// GUILayout类是Unity的自动布局的图形用户界面接口。
    /// <para>参见：GUI Layout教程</para>
    /// </summary>
    public sealed class GUILayout
    {
        public GUILayout() { }
        /// <summary>
        /// 在一个固定的屏幕区域开始一个含有GUI控件的GUILayout块。
        /// <para>默认情况下，所有使用GUILayout创建的GUI控件都是从屏幕的左上角开始放置。如果你想要放置一系列自动布局的控件到任意地方，那么你需要使用GUILayout.BeginArea来定义一个新的区域给自动布局系统使用。</para>
        /// <para>参见：EndArea</para>
        /// <para>当混合GUILayout代码时这个函数非常有用。它必须以一个EndArea调用来匹配。BeginArea/EndArea不能嵌套。</para>
        /// </summary>
        /// <param name="screenRect">此区域在屏幕上的矩形区域</param>
        public static void BeginArea(Rect screenRect) { }
        /// <summary>
        /// 在一个固定的屏幕区域开始一个含有GUI控件的GUILayout块。
        /// <para>默认情况下，所有使用GUILayout创建的GUI控件都是从屏幕的左上角开始放置。如果你想要放置一系列自动布局的控件到任意地方，那么你需要使用GUILayout.BeginArea来定义一个新的区域给自动布局系统使用。</para>
        /// <para>参见：EndArea</para>
        /// <para>当混合GUILayout代码时这个函数非常有用。它必须以一个EndArea调用来匹配。BeginArea/EndArea不能嵌套。</para>
        /// </summary>
        /// <param name="screenRect">此区域在屏幕上的矩形区域</param>
        /// <param name="content">在此区域上展示的文本、图像以及工具提示信息</param>
        public static void BeginArea(Rect screenRect, GUIContent content) { }
        /// <summary>
        /// 在一个固定的屏幕区域开始一个含有GUI控件的GUILayout块。
        /// <para>默认情况下，所有使用GUILayout创建的GUI控件都是从屏幕的左上角开始放置。如果你想要放置一系列自动布局的控件到任意地方，那么你需要使用GUILayout.BeginArea来定义一个新的区域给自动布局系统使用。</para>
        /// <para>参见：EndArea</para>
        /// <para>当混合GUILayout代码时这个函数非常有用。它必须以一个EndArea调用来匹配。BeginArea/EndArea不能嵌套。</para>
        /// </summary>
        /// <param name="screenRect">此区域在屏幕上的矩形区域</param>
        /// <param name="style">要使用的样式。如果留空，那么使用空GUIStyle（GUIStyle.none），将会给出一个透明的背景。</param>
        public static void BeginArea(Rect screenRect, GUIStyle style) { }
        /// <summary>
        /// 在一个固定的屏幕区域开始一个含有GUI控件的GUILayout块。
        /// <para>默认情况下，所有使用GUILayout创建的GUI控件都是从屏幕的左上角开始放置。如果你想要放置一系列自动布局的控件到任意地方，那么你需要使用GUILayout.BeginArea来定义一个新的区域给自动布局系统使用。</para>
        /// <para>参见：EndArea</para>
        /// <para>当混合GUILayout代码时这个函数非常有用。它必须以一个EndArea调用来匹配。BeginArea/EndArea不能嵌套。</para>
        /// </summary>
        /// <param name="screenRect">此区域在屏幕上的矩形区域</param>
        /// <param name="text">在此区域上展示的文本</param>
        public static void BeginArea(Rect screenRect, string text) { }
        /// <summary>
        /// 在一个固定的屏幕区域开始一个含有GUI控件的GUILayout块。
        /// <para>默认情况下，所有使用GUILayout创建的GUI控件都是从屏幕的左上角开始放置。如果你想要放置一系列自动布局的控件到任意地方，那么你需要使用GUILayout.BeginArea来定义一个新的区域给自动布局系统使用。</para>
        /// <para>参见：EndArea</para>
        /// <para>当混合GUILayout代码时这个函数非常有用。它必须以一个EndArea调用来匹配。BeginArea/EndArea不能嵌套。</para>
        /// </summary>
        /// <param name="screenRect">此区域在屏幕上的矩形区域</param>
        /// <param name="image">在此区域上展示的纹理</param>
        public static void BeginArea(Rect screenRect, Texture image) { }
        /// <summary>
        /// 在一个固定的屏幕区域开始一个含有GUI控件的GUILayout块。
        /// <para>默认情况下，所有使用GUILayout创建的GUI控件都是从屏幕的左上角开始放置。如果你想要放置一系列自动布局的控件到任意地方，那么你需要使用GUILayout.BeginArea来定义一个新的区域给自动布局系统使用。</para>
        /// <para>参见：EndArea</para>
        /// <para>当混合GUILayout代码时这个函数非常有用。它必须以一个EndArea调用来匹配。BeginArea/EndArea不能嵌套。</para>
        /// </summary>
        /// <param name="screenRect">此区域在屏幕上的矩形区域</param>
        /// <param name="content">在此区域上展示的文本、图像以及工具提示信息</param>
        /// <param name="style">要使用的样式。如果留空，那么使用空GUIStyle（GUIStyle.none），将会给出一个透明的背景。</param>
        public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }
        /// <summary>
        /// 在一个固定的屏幕区域开始一个含有GUI控件的GUILayout块。
        /// <para>默认情况下，所有使用GUILayout创建的GUI控件都是从屏幕的左上角开始放置。如果你想要放置一系列自动布局的控件到任意地方，那么你需要使用GUILayout.BeginArea来定义一个新的区域给自动布局系统使用。</para>
        /// <para>参见：EndArea</para>
        /// <para>当混合GUILayout代码时这个函数非常有用。它必须以一个EndArea调用来匹配。BeginArea/EndArea不能嵌套。</para>
        /// </summary>
        /// <param name="screenRect">此区域在屏幕上的矩形区域</param>
        /// <param name="text">在此区域上展示的文本</param>
        /// <param name="style">要使用的样式。如果留空，那么使用空GUIStyle（GUIStyle.none），将会给出一个透明的背景。</param>
        public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }
        /// <summary>
        /// 在一个固定的屏幕区域开始一个含有GUI控件的GUILayout块。
        /// <para>默认情况下，所有使用GUILayout创建的GUI控件都是从屏幕的左上角开始放置。如果你想要放置一系列自动布局的控件到任意地方，那么你需要使用GUILayout.BeginArea来定义一个新的区域给自动布局系统使用。</para>
        /// <para>参见：EndArea</para>
        /// <para>当混合GUILayout代码时这个函数非常有用。它必须以一个EndArea调用来匹配。BeginArea/EndArea不能嵌套。</para>
        /// </summary>
        /// <param name="screenRect">此区域在屏幕上的矩形区域</param>
        /// <param name="image">在此区域上展示的纹理</param>
        /// <param name="style">要使用的样式。如果留空，那么使用空GUIStyle（GUIStyle.none），将会给出一个透明的背景。</param>
        public static void BeginArea(Rect screenRect, Texture image, GUIStyle style) { }
        /// <summary>
        /// 开始一个水平的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被水平地放置。该组必须以一个EndHorizontal调用来结束。</para>
        /// </summary>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。</param>
        public static void BeginHorizontal(params GUILayoutOption[] options) { }
        /// <summary>
        /// 开始一个水平的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被水平地放置。该组必须以一个EndHorizontal调用来结束。</para>
        /// </summary>
        /// <param name="style">要使用的背景图像以及填充值的样式。如果留空，那么背景会是透明的。</param>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。任何传递到此处的值都会覆盖由style定义的设置项。</param>
        public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options) { }
        /// <summary>
        /// 开始一个水平的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被水平地放置。该组必须以一个EndHorizontal调用来结束。</para>
        /// </summary>
        /// <param name="content">用于此组的文本、图像以及工具提示信息</param>
        /// <param name="style">要使用的背景图像以及填充值的样式。如果留空，那么背景会是透明的。</param>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。任何传递到此处的值都会覆盖由style定义的设置项。</param>
        public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options) { }
        /// <summary>
        /// 开始一个水平的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被水平地放置。该组必须以一个EndHorizontal调用来结束。</para>
        /// </summary>
        /// <param name="text">在此组上展示的文本</param>
        /// <param name="style">要使用的背景图像以及填充值的样式。如果留空，那么背景会是透明的。</param>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。任何传递到此处的值都会覆盖由style定义的设置项。</param>
        public static void BeginHorizontal(string text, GUIStyle style, params GUILayoutOption[] options) { }
        /// <summary>
        /// 开始一个水平的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被水平地放置。该组必须以一个EndHorizontal调用来结束。</para>
        /// </summary>
        /// <param name="image">在此组上展示的纹理</param>
        /// <param name="style">要使用的背景图像以及填充值的样式。如果留空，那么背景会是透明的。</param>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。任何传递到此处的值都会覆盖由style定义的设置项。</param>
        public static void BeginHorizontal(Texture image, GUIStyle style, params GUILayoutOption[] options) { }
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style) { return default(Vector2); }
        public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options) { return default(Vector2); }
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options) { return default(Vector2); }
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options) { return default(Vector2); }
        public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options) { return default(Vector2); }
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options) { return default(Vector2); }
        public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options) { return default(Vector2); }
        /// <summary>
        /// 开始一个垂直的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被垂直地放置。该组必须以一个EndVertical调用来结束。</para>
        /// </summary>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。</param>
        public static void BeginVertical(params GUILayoutOption[] options) { }
        /// <summary>
        /// 开始一个垂直的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被垂直地放置。该组必须以一个EndVertical调用来结束。</para>
        /// </summary>
        /// <param name="style">要使用的背景图像以及填充值的样式。如果留空，那么背景会是透明的。</param>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。任何传递到此处的值都会覆盖由style定义的设置项。</param>
        public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options) { }
        /// <summary>
        /// 开始一个垂直的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被垂直地放置。该组必须以一个EndVertical调用来结束。</para>
        /// </summary>
        /// <param name="content">用于此组的文本、图像以及工具提示信息</param>
        /// <param name="style">要使用的背景图像以及填充值的样式。如果留空，那么背景会是透明的。</param>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。任何传递到此处的值都会覆盖由style定义的设置项。</param>
        public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options) { }
        /// <summary>
        /// 开始一个垂直的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被垂直地放置。该组必须以一个EndVertical调用来结束。</para>
        /// </summary>
        /// <param name="text">在此组上展示的文本</param>
        /// <param name="style">要使用的背景图像以及填充值的样式。如果留空，那么背景会是透明的。</param>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。任何传递到此处的值都会覆盖由style定义的设置项。</param>
        public static void BeginVertical(string text, GUIStyle style, params GUILayoutOption[] options) { }
        /// <summary>
        /// 开始一个垂直的控件组。
        /// <para>所有在此元素内渲染的控件相互之间将会被垂直地放置。该组必须以一个EndVertical调用来结束。</para>
        /// </summary>
        /// <param name="image">在此组上展示的纹理</param>
        /// <param name="style">要使用的背景图像以及填充值的样式。如果留空，那么背景会是透明的。</param>
        /// <param name="options">一个可选的布局选项列表，该列表规定了额外的布局属性。任何传递到此处的值都会覆盖由style定义的设置项。</param>
        public static void BeginVertical(Texture image, GUIStyle style, params GUILayoutOption[] options) { }
        public static void Box(GUIContent content, params GUILayoutOption[] options) { }
        public static void Box(string text, params GUILayoutOption[] options) { }
        public static void Box(Texture image, params GUILayoutOption[] options) { }
        public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options) { }
        public static void Box(string text, GUIStyle style, params GUILayoutOption[] options) { }
        public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options) { }
        public static bool Button(GUIContent content, params GUILayoutOption[] options) { return default(bool); }
        public static bool Button(string text, params GUILayoutOption[] options) { return default(bool); }
        public static bool Button(Texture image, params GUILayoutOption[] options) { return default(bool); }
        public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        /// <summary>
        /// 结束一个由BeginArea开始的GUILayout块。
        /// </summary>
        public static void EndArea() { }
        /// <summary>
        /// 结束一个由BeginHorizontal开始的组。
        /// </summary>
        public static void EndHorizontal() { }
        public static void EndScrollView() { }
        /// <summary>
        /// 结束一个由BeginVertical开始的组。
        /// </summary>
        public static void EndVertical() { }
        /// <summary>
        /// 传递一个选项，该选项决定一个控件是否允许垂直方向的展开。
        /// </summary>
        /// <param name="expand">是否在垂直方向展开</param>
        /// <returns>该选项</returns>
        public static GUILayoutOption ExpandHeight(bool expand) { return default(GUILayoutOption); }
        /// <summary>
        /// 传递一个选项，该选项决定一个控件是否允许水平方向的展开。
        /// </summary>
        /// <param name="expand">是否在水平方向展开</param>
        /// <returns>该选项</returns>
        public static GUILayoutOption ExpandWidth(bool expand) { return default(GUILayoutOption); }
        /// <summary>
        /// 插入一个灵活的空白元素。
        /// <para>这个元素将会用尽布局余下的所有空间。</para>
        /// <para>请注意：此元素会覆盖GUILayout.ExpandWidth和GUILayout.ExpandHeight.</para>
        /// </summary>
        public static void FlexibleSpace() { }
        /// <summary>
        /// 传递一个选项，该选项让一个控件拥有固定的高度。
        /// <para>请注意：此选项将会覆盖自动的高度布局参数。</para>
        /// </summary>
        /// <param name="height">指定的高度</param>
        /// <returns>该选项</returns>
        public static GUILayoutOption Height(float height) { return default(GUILayoutOption); }
        public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options) { return default(float); }
        public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options) { return default(float); }
        public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options) { return default(float); }
        public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options) { return default(float); }
        public static void Label(GUIContent content, params GUILayoutOption[] options) { }
        public static void Label(string text, params GUILayoutOption[] options) { }
        public static void Label(Texture image, params GUILayoutOption[] options) { }
        public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options) { }
        public static void Label(string text, GUIStyle style, params GUILayoutOption[] options) { }
        public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options) { }
        /// <summary>
        /// 传递一个选项，该选项规定了控件的最大高度。
        /// </summary>
        /// <param name="maxHeight">最大高度</param>
        /// <returns>该选项</returns>
        public static GUILayoutOption MaxHeight(float maxHeight) { return default(GUILayoutOption); }
        /// <summary>
        /// 传递一个选项，该选项规定了控件的最大宽度。
        /// </summary>
        /// <param name="maxWidth">最大宽度</param>
        /// <returns>该选项</returns>
        public static GUILayoutOption MaxWidth(float maxWidth) { return default(GUILayoutOption); }
        /// <summary>
        /// 传递一个选项，该选项规定了控件的最小高度。
        /// </summary>
        /// <param name="minHeight">最小高度</param>
        /// <returns>该选项</returns>
        public static GUILayoutOption MinHeight(float minHeight) { return default(GUILayoutOption); }
        /// <summary>
        /// 传递一个选项，该选项规定了控件的最小宽度。
        /// </summary>
        /// <param name="minWidth">最小宽度</param>
        /// <returns>该选项</returns>
        public static GUILayoutOption MinWidth(float minWidth) { return default(GUILayoutOption); }
        public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options) { return default(string); }
        public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options) { return default(string); }
        public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options) { return default(string); }
        public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options) { return default(string); }
        public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options) { return default(bool); }
        public static bool RepeatButton(string text, params GUILayoutOption[] options) { return default(bool); }
        public static bool RepeatButton(Texture image, params GUILayoutOption[] options) { return default(bool); }
        public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        public static int SelectionGrid(int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options) { return default(int); }
        public static int SelectionGrid(int selected, string[] texts, int xCount, params GUILayoutOption[] options) { return default(int); }
        public static int SelectionGrid(int selected, Texture[] images, int xCount, params GUILayoutOption[] options) { return default(int); }
        public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options) { return default(int); }
        public static int SelectionGrid(int selected, string[] texts, int xCount, GUIStyle style, params GUILayoutOption[] options) { return default(int); }
        public static int SelectionGrid(int selected, Texture[] images, int xCount, GUIStyle style, params GUILayoutOption[] options) { return default(int); }
        /// <summary>
        /// 在当前布局组里插入一块空白。
        /// <para>空白的方向依赖于使用此函数时当前所处的布局。如果处于一个垂直的组，那么空白将会是垂直的。</para>
        /// <para>请注意：此函数将会覆盖GUILayout.ExpandWidth和GUILayout.ExpandHeight选项。</para>
        /// </summary>
        /// <param name="pixels">空白的垂直或水平方向的大小</param>
        public static void Space(float pixels) { }
        public static string TextArea(string text, params GUILayoutOption[] options) { return default(string); }
        public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options) { return default(string); }
        public static string TextArea(string text, int maxLength, params GUILayoutOption[] options) { return default(string); }
        public static string TextArea(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options) { return default(string); }
        public static string TextField(string text, params GUILayoutOption[] options) { return default(string); }
        public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options) { return default(string); }
        public static string TextField(string text, int maxLength, params GUILayoutOption[] options) { return default(string); }
        public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options) { return default(string); }
        public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options) { return default(bool); }
        public static bool Toggle(bool value, string text, params GUILayoutOption[] options) { return default(bool); }
        public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options) { return default(bool); }
        public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options) { return default(bool); }
        public static int Toolbar(int selected, GUIContent[] content, params GUILayoutOption[] options) { return default(int); }
        public static int Toolbar(int selected, string[] texts, params GUILayoutOption[] options) { return default(int); }
        public static int Toolbar(int selected, Texture[] images, params GUILayoutOption[] options) { return default(int); }
        public static int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options) { return default(int); }
        public static int Toolbar(int selected, string[] texts, GUIStyle style, params GUILayoutOption[] options) { return default(int); }
        public static int Toolbar(int selected, Texture[] images, GUIStyle style, params GUILayoutOption[] options) { return default(int); }
        public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options) { return default(float); }
        public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options) { return default(float); }
        public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options) { return default(float); }
        public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options) { return default(float); }
        /// <summary>
        /// 传递一个选项，该选项使得控件拥有一个固定的宽度。
        /// </summary>
        /// <param name="width">指定的宽度</param>
        /// <returns>该选项</returns>
        public static GUILayoutOption Width(float width) { return default(GUILayoutOption); }
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options) { return default(Rect); }
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options) { return default(Rect); }
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options) { return default(Rect); }
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options) { return default(Rect); }
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options) { return default(Rect); }
        public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options) { return default(Rect); }
    }
}
