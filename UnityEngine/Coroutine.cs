using System;

namespace UnityEngine
{
    /// <summary>
    /// MonoBehaviour.StartCoroutine 返回一个 Coroutine。这个类的实例仅仅用来引用这些协程，并不持有任何暴露出来的属性或者函数。
    /// <para>协程是一个函数，这个函数能暂停它的执行（yield）直到指定的 YieldInstruction 执行完毕才会继续。</para>
    /// </summary>
    public sealed class Coroutine : YieldInstruction
    {
    }
}
