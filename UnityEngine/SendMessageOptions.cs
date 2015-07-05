using System;

namespace UnityEngine
{
    /// <summary>
    /// 用于控制如何发送一条消息的选项。
    /// <para>本枚举用于 GameObject 与 Component 中的 SendMessage 与 BroadcastMessage 方法。</para>
    /// </summary>
    public enum SendMessageOptions
    {
        /// <summary>
        /// 至少有一个接收者接收来自 SendMessage 的消息。
        /// <para>如果没有找到接收者，那么将会在控制台打印一条错误信息。（这是默认配置。）参见：GameObject.SendMessage</para>
        /// </summary>
        RequireReceiver = 0,
        /// <summary>
        /// 不需要接收者接收来自 SendMessage 的消息。
        /// <para>即使在 GameObject 上不存在任何实现了指定消息的 Component（脚本），也不会产生错误信息。参见：GameObject.SendMessage</para>
        /// </summary>
        DontRequireReceiver = 1,
    }
}
