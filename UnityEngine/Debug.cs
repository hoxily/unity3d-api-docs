using System;

namespace UnityEngine
{
    /// <summary>
	/// 一个包含了许多调试方法的类，方便游戏开发过程中的调试。
    /// </summary>
    public sealed class Debug
    {
        /// <summary>
        /// 在Build Settings对话框有个Debug Build复选框。
        /// <para>如果复选框被选择，isDebugBuild将是关闭的。在编辑器isDebugBuild总是返回true。建议发布游戏的时候移除所有Debug.Log调用。这样，你就可以很容易的发布带有调试输出的测试版，并且最终版没有。</para>
        /// </summary>
        public static bool isDebugBuild { get { return default(bool); } }
        /// <summary>
        /// <para>暂停编辑器。</para>
        /// <para>当你想要检查inspector面板的某些值，并且你不可能手动暂停它时，这个函数非常有用的。</para>
        /// </summary>
        public static void Break() { }
        /// <summary>
        /// 记录message日志到Unity Console。
        /// </summary>
        /// <param name="message">字符串或者需要转成字符串表达方式用于显示的object</param>
        public static void Log(object message) { }
        /// <summary>
        /// 记录message日志到Unity Console。
        /// </summary>
        /// <param name="message">字符串或者需要转成字符串表达方式用于显示的object</param>
        /// <param name="context">这条message所处的上下文环境</param>
        public static void Log(object message, Object context) { }
    }
}
