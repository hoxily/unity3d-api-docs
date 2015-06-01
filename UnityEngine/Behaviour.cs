using System;

namespace UnityEngine
{
    /// <summary>
    /// Behaviour 是一种可以控制 激活/失效 的 Component。
    /// <para>参见：MonoBehaviour 和 Component.</para>
    /// </summary>
    public class Behaviour : Component
    {
        /// <summary>
        /// 创建新实例
        /// </summary>
        public Behaviour() { }
        /// <summary>
        /// 激活的 Behaviour 被更新， 而失效的 Behaviour 则不会。
        /// <para>这个属性在 inspector 面板上呈现了一个小的复选框。</para>
        /// </summary>
        public bool enabled { get; set; }
    }
}
