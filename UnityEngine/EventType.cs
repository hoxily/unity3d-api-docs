using System;

namespace UnityEngine
{
    /// <summary>
    /// <para>UnityGUI的输入和处理事件的类型。</para>
    /// <para>参见：Event.type、Event、GUI Scripting Guide。</para>
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// <para>鼠标按钮被按下。</para>
        /// <para>当任何鼠标按钮被按下时，此事件被发送。使用Event.button来判断哪个按钮被按下。</para>
        /// </summary>
        mouseDown = 0,
        /// <summary>
        /// <para>鼠标按钮被按下。</para>
        /// <para>当任何鼠标按钮被按下时，此事件被发送。使用Event.button来判断哪个按钮被按下。</para>
        /// </summary>
        MouseDown = 0,
        /// <summary>
        /// <para>鼠标按钮被松开。</para>
        /// <para>当任何鼠标按钮被松开时，此事件被发送。使用Event.button来判断哪个按钮被松开。</para>
        /// </summary>
        MouseUp = 1,
        /// <summary>
        /// <para>鼠标按钮被松开。</para>
        /// <para>当任何鼠标按钮被松开时，此事件被发送。使用Event.button来判断哪个按钮被松开。</para>
        /// </summary>
        mouseUp = 1,
        /// <summary>
        /// <para>鼠标移动（仅用于编辑器视图）。</para>
        /// <para>在没按住任何按钮的情况下移动鼠标。使用Event.mousePosition和Event.delta来判断鼠标运动。</para>
        /// <para>请注意，此类事件仅在编辑器里才发送，对于EditorWindow窗口，它必须将EditorWindow.wantsMouseMove设置为true。鼠标移动事件绝对不会在游戏里发送。</para>
        /// </summary>
        MouseMove = 2,
        /// <summary>
        /// <para>鼠标移动（仅用于编辑器视图）。</para>
        /// <para>在没按住任何按钮的情况下移动鼠标。使用Event.mousePosition和Event.delta来判断鼠标运动。</para>
        /// <para>请注意，此类事件仅在编辑器里才发送，对于EditorWindow窗口，它必须将EditorWindow.wantsMouseMove设置为true。鼠标移动事件绝对不会在游戏里发送。</para>
        /// </summary>
        mouseMove = 2,
        /// <summary>
        /// <para>鼠标拖动。</para>
        /// <para>鼠标拖动是指在按住某个按钮的情况下移动鼠标。使用Event.mousePosition和Event.delta来判断鼠标运动。</para>
        /// </summary>
        mouseDrag = 3,
        /// <summary>
        /// <para>鼠标拖动。</para>
        /// <para>鼠标拖动是指在按住某个按钮的情况下移动鼠标。使用Event.mousePosition和Event.delta来判断鼠标运动。</para>
        /// </summary>
        MouseDrag = 3,
        /// <summary>
        /// <para>某个键盘按键被按下。</para>
        /// <para>使用Event.character来找出键入了什么。使用Event.keyCode来处理方向键、Home、End以及其他功能键，或找出哪个物理按键被按下。依据终端用户设置的键盘的重复频率，此事件会被重复地发送。</para>
        /// <para>请注意，键盘击键可以是分离的事件，一个带着有效的Event.keyCode，另一个带着有效的Event.character。在拥有Dead Key按键的键盘布局下，多个Event.keyCode事件能产生单个Event.character事件。</para>
        /// </summary>
        KeyDown = 4,
        /// <summary>
        /// <para>某个键盘按键被按下。</para>
        /// <para>使用Event.character来找出键入了什么。使用Event.keyCode来处理方向键、Home、End以及其他功能键，或找出哪个物理按键被按下。依据终端用户设置的键盘的重复频率，此事件会被重复地发送。</para>
        /// <para>请注意，键盘击键可以是分离的事件，一个带着有效的Event.keyCode，另一个带着有效的Event.character。在拥有Dead Key按键的键盘布局下，多个Event.keyCode事件能产生单个Event.character事件。</para>
        /// </summary>
        keyDown = 4,
        /// <summary>
        /// <para>某个键盘按键被松开。</para>
        /// <para>使用Event.keyCode来找出哪个物理按键被松开。请注意，依据系统和键盘布局，对于一个按键松开事件，Event.character可能不包含任何字符。</para>
        /// </summary>
        KeyUp = 5,
        /// <summary>
        /// <para>某个键盘按键被松开。</para>
        /// <para>使用Event.keyCode来找出哪个物理按键被松开。请注意，依据系统和键盘布局，对于一个按键松开事件，Event.character可能不包含任何字符。</para>
        /// </summary>
        keyUp = 5,
        /// <summary>
        /// <para>滚轮移动。</para>
        /// <para>使用Event.delta来判断X和Y方向的滚动量。</para>
        /// </summary>
        scrollWheel = 6,
        /// <summary>
        /// <para>滚轮移动。</para>
        /// <para>使用Event.delta来判断X和Y方向的滚动量。</para>
        /// </summary>
        ScrollWheel = 6,
        /// <summary>
        /// <para>重绘事件。每帧发送一个。</para>
        /// <para>所有其他类型的事件先被处理掉，然后发送重绘事件。</para>
        /// </summary>
        repaint = 7,
        /// <summary>
        /// <para>重绘事件。每帧发送一个。</para>
        /// <para>所有其他类型的事件先被处理掉，然后发送重绘事件。</para>
        /// </summary>
        Repaint = 7,
        /// <summary>
        /// <para>布局事件。</para>
        /// <para>此事件比别的事件优先发送——这是一个执行初始化的机会。它被用于自动布局系统。</para>
        /// </summary>
        layout = 8,
        /// <summary>
        /// <para>布局事件。</para>
        /// <para>此事件比别的事件优先发送——这是一个执行初始化的机会。它被用于自动布局系统。</para>
        /// </summary>
        Layout = 8,
        /// <summary>
        /// <para>仅限编辑器：拖放操作更新了。</para>
        /// <para>参见：DragAndDrop类。</para>
        /// </summary>
        DragUpdated = 9,
        /// <summary>
        /// <para>仅限编辑器：拖放操作更新了。</para>
        /// <para>参见：DragAndDrop类。</para>
        /// </summary>
        dragUpdated = 9,
        /// <summary>
        /// <para>仅限编辑器：拖放操作执行了。</para>
        /// <para>参见：DragAndDrop类。</para>
        /// </summary>
        dragPerform = 10,
        /// <summary>
        /// <para>仅限编辑器：拖放操作执行了。</para>
        /// <para>参见：DragAndDrop类。</para>
        /// </summary>
        DragPerform = 10,
        /// <summary>
        /// <para>应该忽略此事件。</para>
        /// <para>此事件暂时失效了，应该忽略它。</para>
        /// </summary>
        ignore = 11,
        /// <summary>
        /// <para>应该忽略此事件。</para>
        /// <para>此事件暂时失效了，应该忽略它。</para>
        /// </summary>
        Ignore = 11,
        /// <summary>
        /// <para>已经处理过的事件。</para>
        /// <para>此事件已经被其他某个控件用过了，应该忽略它。</para>
        /// </summary>
        used = 12,
        /// <summary>
        /// <para>已经处理过的事件。</para>
        /// <para>此事件已经被其他某个控件用过了，应该忽略它。</para>
        /// </summary>
        Used = 12,
        /// <summary>
        /// <para>验证一个特殊的命令（例如复制与粘贴）。</para>
        /// <para>“Copy”、“Cut”、“Paste”、“Delete”、“FrameSelected”、“Duplicate”、“SelectAll”等。仅在编辑器中才发送。</para>
        /// </summary>
        ValidateCommand = 13,
        /// <summary>
        /// <para>执行一个特殊的命令（例如复制与粘贴）。</para>
        /// <para>“Copy”、“Cut”、“Paste”、“Delete”、“FrameSelected”、“Duplicate”、“SelectAll”等。仅在编辑器中才发送。</para>
        /// </summary>
        ExecuteCommand = 14,
        /// <summary>
        /// <para>仅限编辑器：拖放操作退出了。</para>
        /// <para>参见：DragAndDrop类。</para>
        /// </summary>
        DragExited = 15,
        /// <summary>
        /// <para>用户击点了右键（或者在Mac上按住Ctrl后点击）。</para>
        /// <para>如果可用的话，窗口应该展示一个上下文菜单。仅在编辑器中才发送。</para>
        /// </summary>
        ContextClick = 16,
    }
}