using System;

namespace UnityEngine
{
    /// <summary>
    /// 挂起执行中的协程指定的秒数。
    /// <para>WaitForSeconds 只能用在协程中的 yield 语句里。</para>
    /// </summary>
    public sealed class WaitForSeconds : YieldInstruction
    {
        /// <summary>
        /// 创建一个 yield 指令，用来等待指定的秒数。
        /// </summary>
        /// <param name="seconds">等待的秒数</param>
        public WaitForSeconds(float seconds) { }
    }
}
