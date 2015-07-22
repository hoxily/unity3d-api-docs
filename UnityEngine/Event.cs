using System;

namespace UnityEngine
{
    /// <summary>
    /// <para>一个UnityGUI事件。</para>
    /// <para>事件相当于用户输入（按键按下、鼠标动作），或者UnityGUI布局或渲染事件。</para>
    /// <para>脚本里的OnGUI会因为每个事件而被调用。所以OnGUI有可能每帧被调用多次。Event.current相当于OnGUI回调里面的“当前”事件。</para>
    /// <para>参见：GUI Scripting Guide、EventType。</para>
    /// </summary>
    public sealed class Event
    {
        public Event() { }
        public Event(Event other) { }

        public bool alt { get; set; }
        /// <summary>
        /// <para>指示鼠标的哪一个按钮被按下。</para>
        /// <para>0代表鼠标左键，1代表鼠标右键，2代表鼠标中键。用于EventType.MouseDown、EventType.MouseUp类型的事件。</para>
        /// </summary>
        public int button { get; set; }
        public bool capsLock { get; set; }
        public char character { get; set; }
        /// <summary>
        /// <para>我们收到了多少个连续不断的鼠标点击。</para>
        /// <para>用于EventType.MouseDown类型的事件。使用此值来区分单击与双击。</para>
        /// </summary>
        public int clickCount { get; set; }
        public bool command { get; set; }
        public string commandName { get; set; }
        public bool control { get; set; }
        /// <summary>
        /// 正在被处理的当前事件。
        /// </summary>
        public static Event current { get; set; }
        public Vector2 delta { get; set; }
        public bool functionKey { get { return default(bool); } }
        public bool isKey { get { return default(bool); } }
        /// <summary>
        /// 此事件是不是一个鼠标事件？（只读）
        /// </summary>
        public bool isMouse { get { return default(bool); } }
        public KeyCode keyCode { get; set; }
        public EventModifiers modifiers { get; set; }
        public Vector2 mousePosition { get; set; }
        [Obsolete("Use HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);", true)]
        public Ray mouseRay { get; set; }
        public bool numeric { get; set; }
        public float pressure { get; set; }
        public EventType rawType { get { return default(EventType); } }
        public bool shift { get; set; }
        public EventType type { get; set; }

        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        [WrapperlessIcall]
        public EventType GetTypeForControl(int controlID) { return default(EventType); }
        public static Event KeyboardEvent(string key) { return default(Event); }
        [WrapperlessIcall]
        public static bool PopEvent(Event outEvent) { return default(bool); }
        public override string ToString() { return default(string); }
        [WrapperlessIcall]
        public void Use() { }
    }
}