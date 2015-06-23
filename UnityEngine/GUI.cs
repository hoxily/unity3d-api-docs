using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    /// <summary>
    /// GUI 类是 Unity 的手动定位的图形用户界面的接口。
    /// </summary>
    public class GUI
    {
        public GUI() { }
        /// <summary>
        /// 为所有由 GUI 渲染的背景元素着色的颜色。
        /// </summary>
        public static Color backgroundColor { get; set; }
        /// <summary>
        /// 如果任何控件改变了输入数据，那么返回 true.
        /// </summary>
        public static bool changed { get; set; }
        public static Color color { get; set; }
        public static Color contentColor { get; set; }
        public static int depth { get; set; }
        public static bool enabled { get; set; }
        public static Matrix4x4 matrix { get; set; }
        protected static string mouseTooltip { get { return default(string); } }
        public static GUISkin skin { get; set; }
        /// <summary>
        /// 当前鼠标正下方控件的工具提示信息，或者键盘焦点所在控件的工具提示信息（只读）。
        /// <para>当你创建 GUI 控件时，你可以传给它们一条工具提示信息。这可以通过传递一个自定义的 GUIContent 对象给 content 参数，而不是仅仅传递一个字符串来显示。</para>
        /// <para>当鼠标从一个含有工具提示信息的控件正上方经过时，它就会把这个全局的 GUI.tooltip 设置成你为此控件设置的工具提示信息。如果鼠标没有悬浮在任何控件上，那么此值将会被设置为键盘焦点所在控件的工具提示信息。你可以在 OnGUI 代码的末尾放置一个 label 来显示 GUI.tooltip 的值。</para>
        /// </summary>
        public static string tooltip { get; set; }
        protected static Rect tooltipRect { get; set; }
        /// <summary>
        /// 开始一个组。必须用一个 EndGroup 调用来完成配对。
        /// <para>当你开始一个组后， GUI 控件的坐标系统被重新定义，该组的左上角成了坐标原点（0，0）。组内的所有控件都依据该组进行剪除。组可以被嵌套，如果真是这样的话，子组将依据父组进行剪除。</para>
        /// <para>当在屏幕上移动大批量 GUI 元素时非常有用。一个常见的用例是设计你的菜单，让其适应特定大小的屏幕，然后当它遇到更大的屏幕时使菜单居中。参见：matrix, BeginScrollView.</para>
        /// </summary>
        /// <param name="position">该组在屏幕上的矩形区域</param>
        public static void BeginGroup(Rect position) { }
        /// <summary>
        /// 开始一个组。必须用一个 EndGroup 调用来完成配对。
        /// <para>当你开始一个组后， GUI 控件的坐标系统被重新定义，该组的左上角成了坐标原点（0，0）。组内的所有控件都依据该组进行剪除。组可以被嵌套，如果真是这样的话，子组将依据父组进行剪除。</para>
        /// <para>当在屏幕上移动大批量 GUI 元素时非常有用。一个常见的用例是设计你的菜单，让其适应特定大小的屏幕，然后当它遇到更大的屏幕时使菜单居中。参见：matrix, BeginScrollView.</para>
        /// </summary>
        /// <param name="position">该组在屏幕上的矩形区域</param>
        /// <param name="content">用于该组的文本、图像以及工具提示信息。如果提供了该参数，那么任何鼠标点击都被该组“捕获”。否则，不会捕获鼠标点击，不会渲染背景，并且鼠标点击会被传递下去。</param>
        public static void BeginGroup(Rect position, GUIContent content) { }
        /// <summary>
        /// 开始一个组。必须用一个 EndGroup 调用来完成配对。
        /// <para>当你开始一个组后， GUI 控件的坐标系统被重新定义，该组的左上角成了坐标原点（0，0）。组内的所有控件都依据该组进行剪除。组可以被嵌套，如果真是这样的话，子组将依据父组进行剪除。</para>
        /// <para>当在屏幕上移动大批量 GUI 元素时非常有用。一个常见的用例是设计你的菜单，让其适应特定大小的屏幕，然后当它遇到更大的屏幕时使菜单居中。参见：matrix, BeginScrollView.</para>
        /// </summary>
        /// <param name="position">该组在屏幕上的矩形区域</param>
        /// <param name="style">背景的样式</param>
        public static void BeginGroup(Rect position, GUIStyle style) { }
        /// <summary>
        /// 开始一个组。必须用一个 EndGroup 调用来完成配对。
        /// <para>当你开始一个组后， GUI 控件的坐标系统被重新定义，该组的左上角成了坐标原点（0，0）。组内的所有控件都依据该组进行剪除。组可以被嵌套，如果真是这样的话，子组将依据父组进行剪除。</para>
        /// <para>当在屏幕上移动大批量 GUI 元素时非常有用。一个常见的用例是设计你的菜单，让其适应特定大小的屏幕，然后当它遇到更大的屏幕时使菜单居中。参见：matrix, BeginScrollView.</para>
        /// </summary>
        /// <param name="position">该组在屏幕上的矩形区域</param>
        /// <param name="text">在该组上显示的文本</param>
        public static void BeginGroup(Rect position, string text) { }
        /// <summary>
        /// 开始一个组。必须用一个 EndGroup 调用来完成配对。
        /// <para>当你开始一个组后， GUI 控件的坐标系统被重新定义，该组的左上角成了坐标原点（0，0）。组内的所有控件都依据该组进行剪除。组可以被嵌套，如果真是这样的话，子组将依据父组进行剪除。</para>
        /// <para>当在屏幕上移动大批量 GUI 元素时非常有用。一个常见的用例是设计你的菜单，让其适应特定大小的屏幕，然后当它遇到更大的屏幕时使菜单居中。参见：matrix, BeginScrollView.</para>
        /// </summary>
        /// <param name="position">该组在屏幕上的矩形区域</param>
        /// <param name="image">在该组上显示的纹理</param>
        public static void BeginGroup(Rect position, Texture image) { }
        /// <summary>
        /// 开始一个组。必须用一个 EndGroup 调用来完成配对。
        /// <para>当你开始一个组后， GUI 控件的坐标系统被重新定义，该组的左上角成了坐标原点（0，0）。组内的所有控件都依据该组进行剪除。组可以被嵌套，如果真是这样的话，子组将依据父组进行剪除。</para>
        /// <para>当在屏幕上移动大批量 GUI 元素时非常有用。一个常见的用例是设计你的菜单，让其适应特定大小的屏幕，然后当它遇到更大的屏幕时使菜单居中。参见：matrix, BeginScrollView.</para>
        /// </summary>
        /// <param name="position">该组在屏幕上的矩形区域</param>
        /// <param name="content">用于该组的文本、图像以及工具提示信息。如果提供了该参数，那么任何鼠标点击都被该组“捕获”。否则，不会捕获鼠标点击，不会渲染背景，并且鼠标点击会被传递下去。</param>
        /// <param name="style">背景的样式</param>
        public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }
        /// <summary>
        /// 开始一个组。必须用一个 EndGroup 调用来完成配对。
        /// <para>当你开始一个组后， GUI 控件的坐标系统被重新定义，该组的左上角成了坐标原点（0，0）。组内的所有控件都依据该组进行剪除。组可以被嵌套，如果真是这样的话，子组将依据父组进行剪除。</para>
        /// <para>当在屏幕上移动大批量 GUI 元素时非常有用。一个常见的用例是设计你的菜单，让其适应特定大小的屏幕，然后当它遇到更大的屏幕时使菜单居中。参见：matrix, BeginScrollView.</para>
        /// </summary>
        /// <param name="position">该组在屏幕上的矩形区域</param>
        /// <param name="text">在该组上显示的文本</param>
        /// <param name="style">背景的样式</param>
        public static void BeginGroup(Rect position, string text, GUIStyle style) { }
        /// <summary>
        /// 开始一个组。必须用一个 EndGroup 调用来完成配对。
        /// <para>当你开始一个组后， GUI 控件的坐标系统被重新定义，该组的左上角成了坐标原点（0，0）。组内的所有控件都依据该组进行剪除。组可以被嵌套，如果真是这样的话，子组将依据父组进行剪除。</para>
        /// <para>当在屏幕上移动大批量 GUI 元素时非常有用。一个常见的用例是设计你的菜单，让其适应特定大小的屏幕，然后当它遇到更大的屏幕时使菜单居中。参见：matrix, BeginScrollView.</para>
        /// </summary>
        /// <param name="position">该组在屏幕上的矩形区域</param>
        /// <param name="image">在该组上显示的纹理</param>
        /// <param name="style">背景的样式</param>
        public static void BeginGroup(Rect position, Texture image, GUIStyle style) { }
        public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect) { return default(Vector2); }
        public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical) { return default(Vector2); }
        public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar) { return default(Vector2); }
        public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar) { return default(Vector2); }
        /// <summary>
        /// 创建一个图形框。
        /// </summary>
        /// <param name="position">该图形框在屏幕上的矩形区域</param>
        /// <param name="content">用于该图形框的文本、图像以及工具提示信息</param>
        public static void Box(Rect position, GUIContent content) { }
        /// <summary>
        /// 创建一个图形框。
        /// </summary>
        /// <param name="position">该图形框在屏幕上的矩形区域</param>
        /// <param name="text">在该图形框上显示的文本</param>
        public static void Box(Rect position, string text) { }
        /// <summary>
        /// 创建一个图形框。
        /// </summary>
        /// <param name="position">该图形框在屏幕上的矩形区域</param>
        /// <param name="image">在该图形框上显示的纹理</param>
        public static void Box(Rect position, Texture image) { }
        /// <summary>
        /// 创建一个图形框。
        /// </summary>
        /// <param name="position">该图形框在屏幕上的矩形区域</param>
        /// <param name="content">用于该图形框的文本、图像以及工具提示信息</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 box 样式。</param>
        public static void Box(Rect position, GUIContent content, GUIStyle style) { }
        /// <summary>
        /// 创建一个图形框。
        /// </summary>
        /// <param name="position">该图形框在屏幕上的矩形区域</param>
        /// <param name="text">在该图形框上显示的文本</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 box 样式。</param>
        public static void Box(Rect position, string text, GUIStyle style) { }
        /// <summary>
        /// 创建一个图形框。
        /// </summary>
        /// <param name="position">该图形框在屏幕上的矩形区域</param>
        /// <param name="image">在该图形框上显示的纹理</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 box 样式。</param>
        public static void Box(Rect position, Texture image, GUIStyle style) { }
        [WrapperlessIcall]
        public static void BringWindowToBack(int windowID) { }
        [WrapperlessIcall]
        public static void BringWindowToFront(int windowID) { }
        /// <summary>
        /// 创建一个单击按钮。用户点击它们然后某些事就会立即发生。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="content">用于该按钮的文本、图像以及工具提示信息</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool Button(Rect position, GUIContent content) { return default(bool); }
        /// <summary>
        /// 创建一个单击按钮。用户点击它们然后某些事就会立即发生。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="text">在该按钮上显示的文本</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool Button(Rect position, string text) { return default(bool); }
        /// <summary>
        /// 创建一个单击按钮。用户点击它们然后某些事就会立即发生。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="image">在该按钮上显示的纹理</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool Button(Rect position, Texture image) { return default(bool); }
        /// <summary>
        /// 创建一个单击按钮。用户点击它们然后某些事就会立即发生。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="content">用于该按钮的文本、图像以及工具提示信息</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool Button(Rect position, GUIContent content, GUIStyle style) { return default(bool); }
        /// <summary>
        /// 创建一个单击按钮。用户点击它们然后某些事就会立即发生。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="text">在该按钮上显示的文本</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool Button(Rect position, string text, GUIStyle style) { return default(bool); }
        /// <summary>
        /// 创建一个单击按钮。用户点击它们然后某些事就会立即发生。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="image">在该按钮上显示的纹理</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool Button(Rect position, Texture image, GUIStyle style) { return default(bool); }
        protected static Vector2 DoBeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { return default(Vector2); }
        public static void DragWindow() { }
        public static void DragWindow(Rect position) { }
        [ExcludeFromDocs]
        public static void DrawTexture(Rect position, Texture image) { }
        [ExcludeFromDocs]
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }
        [ExcludeFromDocs]
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }
        public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }
        [ExcludeFromDocs]
        public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords) { }
        public static void DrawTextureWithTexCoords(Rect position, Texture image, Rect texCoords, bool alphaBlend) { }
        /// <summary>
        /// 结束一个组。
        /// <para>应该与 GUI.BeginGroup 配对使用。参见：BeginGroup.</para>
        /// </summary>
        public static void EndGroup() { }
        public static void EndScrollView() { }
        public static void EndScrollView(bool handleScrollWheel) { }
        [WrapperlessIcall]
        public static void FocusControl(string name) { }
        [WrapperlessIcall]
        public static void FocusWindow(int windowID) { }
        [WrapperlessIcall]
        public static string GetNameOfFocusedControl() { return default(string); }
        public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue) { return default(float); }
        public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { return default(float); }
        public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue) { return default(float); }
        public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { return default(float); }
        /// <summary>
        /// 在屏幕创建文本标签或者纹理标签。
        /// <para>Label 没有用户交互，它不捕获鼠标点击，并且总是以常规样式进行渲染。如果你想要让一个控件可见地对用户输入做出响应，那么请使用 Box 控件。</para>
        /// </summary>
        /// <param name="position">该标签在屏幕上的矩形区域。</param>
        /// <param name="content">用于该标签的文本、图像以及工具提示信息。</param>
        public static void Label(Rect position, GUIContent content) { }
        /// <summary>
        /// 在屏幕创建文本标签或者纹理标签。
        /// <para>Label 没有用户交互，它不捕获鼠标点击，并且总是以常规样式进行渲染。如果你想要让一个控件可见地对用户输入做出响应，那么请使用 Box 控件。</para>
        /// </summary>
        /// <param name="position">该标签在屏幕上的矩形区域。</param>
        /// <param name="text">在该标签上显示的文本。</param>
        public static void Label(Rect position, string text) { }
        /// <summary>
        /// 在屏幕创建文本标签或者纹理标签。
        /// <para>Label 没有用户交互，它不捕获鼠标点击，并且总是以常规样式进行渲染。如果你想要让一个控件可见地对用户输入做出响应，那么请使用 Box 控件。</para>
        /// </summary>
        /// <param name="position">该标签在屏幕上的矩形区域。</param>
        /// <param name="image">在该标签上显示的纹理</param>
        public static void Label(Rect position, Texture image) { }
        /// <summary>
        /// 在屏幕创建文本标签或者纹理标签。
        /// <para>Label 没有用户交互，它不捕获鼠标点击，并且总是以常规样式进行渲染。如果你想要让一个控件可见地对用户输入做出响应，那么请使用 Box 控件。</para>
        /// </summary>
        /// <param name="position">该标签在屏幕上的矩形区域。</param>
        /// <param name="content">用于该标签的文本、图像以及工具提示信息。</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 label 样式。</param>
        public static void Label(Rect position, GUIContent content, GUIStyle style) { }
        /// <summary>
        /// 在屏幕创建文本标签或者纹理标签。
        /// <para>Label 没有用户交互，它不捕获鼠标点击，并且总是以常规样式进行渲染。如果你想要让一个控件可见地对用户输入做出响应，那么请使用 Box 控件。</para>
        /// </summary>
        /// <param name="position">该标签在屏幕上的矩形区域。</param>
        /// <param name="text">在该标签上显示的文本。</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 label 样式。</param>
        public static void Label(Rect position, string text, GUIStyle style) { }
        /// <summary>
        /// 在屏幕创建文本标签或者纹理标签。
        /// <para>Label 没有用户交互，它不捕获鼠标点击，并且总是以常规样式进行渲染。如果你想要让一个控件可见地对用户输入做出响应，那么请使用 Box 控件。</para>
        /// </summary>
        /// <param name="position">该标签在屏幕上的矩形区域。</param>
        /// <param name="image">在该标签上显示的纹理</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 label 样式。</param>
        public static void Label(Rect position, Texture image, GUIStyle style) { }
        public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content) { return default(Rect); }
        public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text) { return default(Rect); }
        public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image) { return default(Rect); }
        public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content, GUIStyle style) { return default(Rect); }
        public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style) { return default(Rect); }
        public static Rect ModalWindow(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style) { return default(Rect); }
        public static string PasswordField(Rect position, string password, char maskChar) { return default(string); }
        public static string PasswordField(Rect position, string password, char maskChar, GUIStyle style) { return default(string); }
        public static string PasswordField(Rect position, string password, char maskChar, int maxLength) { return default(string); }
        public static string PasswordField(Rect position, string password, char maskChar, int maxLength, GUIStyle style) { return default(string); }
        /// <summary>
        /// 创建一个按钮。只要用户保持按下，那么这个按钮就会一直处于活动状态。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="content">用于该按钮的文本、图像以及工具提示信息</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool RepeatButton(Rect position, GUIContent content) { return default(bool); }
        /// <summary>
        /// 创建一个按钮。只要用户保持按下，那么这个按钮就会一直处于活动状态。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="text">在该按钮上显示的文本</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool RepeatButton(Rect position, string text) { return default(bool); }
        /// <summary>
        /// 创建一个按钮。只要用户保持按下，那么这个按钮就会一直处于活动状态。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="image">在该按钮上显示的纹理</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool RepeatButton(Rect position, Texture image) { return default(bool); }
        /// <summary>
        /// 创建一个按钮。只要用户保持按下，那么这个按钮就会一直处于活动状态。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="content">用于该按钮的文本、图像以及工具提示信息</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool RepeatButton(Rect position, GUIContent content, GUIStyle style) { return default(bool); }
        /// <summary>
        /// 创建一个按钮。只要用户保持按下，那么这个按钮就会一直处于活动状态。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="text">在该按钮上显示的文本</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool RepeatButton(Rect position, string text, GUIStyle style) { return default(bool); }
        /// <summary>
        /// 创建一个按钮。只要用户保持按下，那么这个按钮就会一直处于活动状态。
        /// </summary>
        /// <param name="position">该按钮在屏幕上的矩形区域</param>
        /// <param name="image">在该按钮上显示的纹理。</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>当用户按下按钮时返回 true</returns>
        public static bool RepeatButton(Rect position, Texture image, GUIStyle style) { return default(bool); }
        public static void ScrollTo(Rect position) { }
        public static bool ScrollTowards(Rect position, float maxDelta) { return default(bool); }
        /// <summary>
        /// 创建一张由按钮构成的网格。
        /// </summary>
        /// <param name="position">该网格在屏幕上的矩形区域。</param>
        /// <param name="selected">被选中的那个网格按钮的索引。</param>
        /// <param name="content">用于该网格的文本、图像以及工具提示信息数组。</param>
        /// <param name="xCount">在水平方向有多少个元素。控件将会被缩放以适应网格的宽度，除非样式里定义了一个 fixedWidth.</param>
        /// <returns>被选中的那个网格按钮的索引。</returns>
        public static int SelectionGrid(Rect position, int selected, GUIContent[] content, int xCount) { return default(int); }
        /// <summary>
        /// 创建一张由按钮构成的网格。
        /// </summary>
        /// <param name="position">该网格在屏幕上的矩形区域。</param>
        /// <param name="selected">被选中的那个网格按钮的索引。</param>
        /// <param name="texts">在该网格按钮上显示的字符串数组。</param>
        /// <param name="xCount">在水平方向有多少个元素。控件将会被缩放以适应网格的宽度，除非样式里定义了一个 fixedWidth.</param>
        /// <returns>被选中的那个网格按钮的索引。</returns>
        public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount) { return default(int); }
        /// <summary>
        /// 创建一张由按钮构成的网格。
        /// </summary>
        /// <param name="position">该网格在屏幕上的矩形区域。</param>
        /// <param name="selected">被选中的那个网格按钮的索引。</param>
        /// <param name="images">在𣃚网格按钮上显示的纹理数组。</param>
        /// <param name="xCount">在水平方向有多少个元素。控件将会被缩放以适应网格的宽度，除非样式里定义了一个 fixedWidth.</param>
        /// <returns>被选中的那个网格按钮的索引。</returns>
        public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount) { return default(int); }
        /// <summary>
        /// 创建一张由按钮构成的网格。
        /// </summary>
        /// <param name="position">该网格在屏幕上的矩形区域。</param>
        /// <param name="selected">被选中的那个网格按钮的索引。</param>
        /// <param name="contents">用于该网格的文本、图像以及工具提示信息数组。</param>
        /// <param name="xCount">在水平方向有多少个元素。控件将会被缩放以适应网格的宽度，除非样式里定义了一个 fixedWidth.</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>被选中的那个网格按钮的索引。</returns>
        public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style) { return default(int); }
        /// <summary>
        /// 创建一张由按钮构成的网格。
        /// </summary>
        /// <param name="position">该网格在屏幕上的矩形区域。</param>
        /// <param name="selected">被选中的那个网格按钮的索引。</param>
        /// <param name="texts">在该网格按钮上显示的字符串数组。</param>
        /// <param name="xCount">在水平方向有多少个元素。控件将会被缩放以适应网格的宽度，除非样式里定义了一个 fixedWidth.</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>被选中的那个网格按钮的索引。</returns>
        public static int SelectionGrid(Rect position, int selected, string[] texts, int xCount, GUIStyle style) { return default(int); }
        /// <summary>
        /// 创建一张由按钮构成的网格。
        /// </summary>
        /// <param name="position">该网格在屏幕上的矩形区域。</param>
        /// <param name="selected">被选中的那个网格按钮的索引。</param>
        /// <param name="images">在𣃚网格按钮上显示的纹理数组。</param>
        /// <param name="xCount">在水平方向有多少个元素。控件将会被缩放以适应网格的宽度，除非样式里定义了一个 fixedWidth.</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>被选中的那个网格按钮的索引。</returns>
        public static int SelectionGrid(Rect position, int selected, Texture[] images, int xCount, GUIStyle style) { return default(int); }
        [WrapperlessIcall]
        public static void SetNextControlName(string name) { }
        public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id) { return default(float); }
        /// <summary>
        /// 创建一个多行的文本区域，用户可以在此处编辑字符串。
        /// </summary>
        /// <param name="position">该文本域在屏幕上的矩形区域</param>
        /// <param name="text">要编辑的文本。本函数的返回值应该要赋值回此字符串变量，如例子所示。</param>
        /// <returns>编辑过的字符串</returns>
        public static string TextArea(Rect position, string text) { return default(string); }
        /// <summary>
        /// 创建一个多行的文本区域，用户可以在此处编辑字符串。
        /// </summary>
        /// <param name="position">该文本域在屏幕上的矩形区域</param>
        /// <param name="text">要编辑的文本。本函数的返回值应该要赋值回此字符串变量，如例子所示。</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 textArea 样式。</param>
        /// <returns>编辑过的字符串</returns>
        public static string TextArea(Rect position, string text, GUIStyle style) { return default(string); }
        /// <summary>
        /// 创建一个多行的文本区域，用户可以在此处编辑字符串。
        /// </summary>
        /// <param name="position">该文本域在屏幕上的矩形区域</param>
        /// <param name="text">要编辑的文本。本函数的返回值应该要赋值回此字符串变量，如例子所示。</param>
        /// <param name="maxLength">字符串的最大长度。如果留空，那么用户可以永远地输入下去。</param>
        /// <returns>编辑过的字符串</returns>
        public static string TextArea(Rect position, string text, int maxLength) { return default(string); }
        /// <summary>
        /// 创建一个多行的文本区域，用户可以在此处编辑字符串。
        /// </summary>
        /// <param name="position">该文本域在屏幕上的矩形区域</param>
        /// <param name="text">要编辑的文本。本函数的返回值应该要赋值回此字符串变量，如例子所示。</param>
        /// <param name="maxLength">字符串的最大长度。如果留空，那么用户可以永远地输入下去。</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 textArea 样式。</param>
        /// <returns>编辑过的字符串</returns>
        public static string TextArea(Rect position, string text, int maxLength, GUIStyle style) { return default(string); }
        /// <summary>
        /// 创建一个单行的文本区域，用户可以在此处编辑字符串。
        /// </summary>
        /// <param name="position">该文本域在屏幕上的矩形区域</param>
        /// <param name="text">要编辑的文本。本函数的返回值应该要赋值回此字符串变量，如例子所示。</param>
        /// <returns>编辑过的字符串</returns>
        public static string TextField(Rect position, string text) { return default(string); }
        /// <summary>
        /// 创建一个单行的文本区域，用户可以在此处编辑字符串。
        /// </summary>
        /// <param name="position">该文本域在屏幕上的矩形区域</param>
        /// <param name="text">要编辑的文本。本函数的返回值应该要赋值回此字符串变量，如例子所示。</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 textField 样式。</param>
        /// <returns>编辑过的字符串</returns>
        public static string TextField(Rect position, string text, GUIStyle style) { return default(string); }
        /// <summary>
        /// 创建一个单行的文本区域，用户可以在此处编辑字符串。
        /// </summary>
        /// <param name="position">该文本域在屏幕上的矩形区域</param>
        /// <param name="text">要编辑的文本。本函数的返回值应该要赋值回此字符串变量，如例子所示。</param>
        /// <param name="maxLength">字符串的最大长度。如果留空，那么用户可以永远地输入下去。</param>
        /// <returns>编辑过的字符串</returns>
        public static string TextField(Rect position, string text, int maxLength) { return default(string); }
        /// <summary>
        /// 创建一个单行的文本区域，用户可以在此处编辑字符串。
        /// </summary>
        /// <param name="position">该文本域在屏幕上的矩形区域</param>
        /// <param name="text">要编辑的文本。本函数的返回值应该要赋值回此字符串变量，如例子所示。</param>
        /// <param name="maxLength">字符串的最大长度。如果留空，那么用户可以永远地输入下去。</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 textField 样式。</param>
        /// <returns>编辑过的字符串</returns>
        public static string TextField(Rect position, string text, int maxLength, GUIStyle style) { return default(string); }
        /// <summary>
        /// 创建一个开关切换按钮。
        /// </summary>
        /// <param name="position">该按钮在屏幕的矩形区域</param>
        /// <param name="value">这个按钮是开还是关？</param>
        /// <param name="content">用于该按钮的文本、图像以及工具提示信息</param>
        /// <returns>该按钮的新开关状态值</returns>
        public static bool Toggle(Rect position, bool value, GUIContent content) { return default(bool); }
        /// <summary>
        /// 创建一个开关切换按钮。
        /// </summary>
        /// <param name="position">该按钮在屏幕的矩形区域</param>
        /// <param name="value">这个按钮是开还是关？</param>
        /// <param name="text">在该按钮上显示的文本</param>
        /// <returns>该按钮的新开关状态值</returns>
        public static bool Toggle(Rect position, bool value, string text) { return default(bool); }
        /// <summary>
        /// 创建一个开关切换按钮。
        /// </summary>
        /// <param name="position">该按钮在屏幕的矩形区域</param>
        /// <param name="value">这个按钮是开还是关？</param>
        /// <param name="image">在该按钮上显示的纹理</param>
        /// <returns>该按钮的新开关状态值</returns>
        public static bool Toggle(Rect position, bool value, Texture image) { return default(bool); }
        /// <summary>
        /// 创建一个开关切换按钮。
        /// </summary>
        /// <param name="position">该按钮在屏幕的矩形区域</param>
        /// <param name="value">这个按钮是开还是关？</param>
        /// <param name="content">用于该按钮的文本、图像以及工具提示信息</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 toggle 样式。</param>
        /// <returns>该按钮的新开关状态值</returns>
        public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style) { return default(bool); }
        /// <summary>
        /// 创建一个开关切换按钮。
        /// </summary>
        /// <param name="position">该按钮在屏幕的矩形区域</param>
        /// <param name="value">这个按钮是开还是关？</param>
        /// <param name="text">在该按钮上显示的文本</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 toggle 样式。</param>
        /// <returns>该按钮的新开关状态值</returns>
        public static bool Toggle(Rect position, bool value, string text, GUIStyle style) { return default(bool); }
        /// <summary>
        /// 创建一个开关切换按钮。
        /// </summary>
        /// <param name="position">该按钮在屏幕的矩形区域</param>
        /// <param name="value">这个按钮是开还是关？</param>
        /// <param name="image">在该按钮上显示的纹理</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 toggle 样式。</param>
        /// <returns>该按钮的新开关状态值</returns>
        public static bool Toggle(Rect position, bool value, Texture image, GUIStyle style) { return default(bool); }
        public static bool Toggle(Rect position, int id, bool value, GUIContent content, GUIStyle style) { return default(bool); }
        /// <summary>
        /// 创建一个工具条。
        /// </summary>
        /// <param name="position">该工具条在屏幕上的矩形区域</param>
        /// <param name="selected">被选中的按钮的索引</param>
        /// <param name="content">用于该工具条的文本、图像以及工具提示信息数组。</param>
        /// <returns>被选中的按钮的索引</returns>
        public static int Toolbar(Rect position, int selected, GUIContent[] content) { return default(int); }
        /// <summary>
        /// 创建一个工具条。
        /// </summary>
        /// <param name="position">该工具条在屏幕上的矩形区域</param>
        /// <param name="selected">被选中的按钮的索引</param>
        /// <param name="texts">在该工具条上显示的字符串数组</param>
        /// <returns>被选中的按钮的索引</returns>
        public static int Toolbar(Rect position, int selected, string[] texts) { return default(int); }
        /// <summary>
        /// 创建一个工具条。
        /// </summary>
        /// <param name="position">该工具条在屏幕上的矩形区域</param>
        /// <param name="selected">被选中的按钮的索引</param>
        /// <param name="images">在该工具条上显示的纹理数组</param>
        /// <returns>被选中的按钮的索引</returns>
        public static int Toolbar(Rect position, int selected, Texture[] images) { return default(int); }
        /// <summary>
        /// 创建一个工具条。
        /// </summary>
        /// <param name="position">该工具条在屏幕上的矩形区域</param>
        /// <param name="selected">被选中的按钮的索引</param>
        /// <param name="contents">用于该工具条的文本、图像以及工具提示信息数组。</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>被选中的按钮的索引</returns>
        public static int Toolbar(Rect position, int selected, GUIContent[] contents, GUIStyle style) { return default(int); }
        /// <summary>
        /// 创建一个工具条。
        /// </summary>
        /// <param name="position">该工具条在屏幕上的矩形区域</param>
        /// <param name="selected">被选中的按钮的索引</param>
        /// <param name="texts">在该工具条上显示的字符串数组</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>被选中的按钮的索引</returns>
        public static int Toolbar(Rect position, int selected, string[] texts, GUIStyle style) { return default(int); }
        /// <summary>
        /// 创建一个工具条。
        /// </summary>
        /// <param name="position">该工具条在屏幕上的矩形区域</param>
        /// <param name="selected">被选中的按钮的索引</param>
        /// <param name="images">在该工具条上显示的纹理数组</param>
        /// <param name="style">要使用的样式。如果留空，那么将会使用当前 GUISkin 的 button 样式。</param>
        /// <returns>被选中的按钮的索引</returns>
        public static int Toolbar(Rect position, int selected, Texture[] images, GUIStyle style) { return default(int); }
        [WrapperlessIcall]
        public static void UnfocusWindow() { }
        public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue) { return default(float); }
        public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { return default(float); }
        public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue) { return default(float); }
        public static float VerticalSlider(Rect position, float value, float topValue, float bottomValue, GUIStyle slider, GUIStyle thumb) { return default(float); }
        public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent content) { return default(Rect); }
        public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text) { return default(Rect); }
        public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image) { return default(Rect); }
        public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style) { return default(Rect); }
        public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, string text, GUIStyle style) { return default(Rect); }
        public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, Texture image, GUIStyle style) { return default(Rect); }

        public delegate void WindowFunction(int id);
    }
}
