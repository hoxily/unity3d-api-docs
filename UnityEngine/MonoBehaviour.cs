using System;
using System.Collections;
using UnityEngine.Internal;

namespace UnityEngine
{
    /// <summary>
    /// MonoBehaviour 是所有脚本的基类。
    /// <para>当使用 JavaScript 时，每个脚本自动地派生自 MonoBehaviour。当使用 C# 或者 Boo 时你需要明确地从 MonoBehaviour 派生。</para>
    /// <para>请注意：在 inspector 面板上，用于使一个 MonoBehaviour 失效的复选框仅能阻止 Start()、Awake()、Update()、FixedUpdate() 以及 OnGUI() 的执行。如果这些函数中的任意一个都不存在，那么复选框不会显示。</para>
    /// </summary>
    public class MonoBehaviour : Behaviour
    {
        /// <summary>
        /// 创建新实例。
        /// </summary>
        public MonoBehaviour() { }
        /// <summary>
        /// 记录日志 message 到 Unity Console（与 Debug.Log 等价）。
        /// </summary>
        /// <param name="message">字符串或者需要转成字符串表达方式用于显示的object</param>
        public static void print(object message) { }
        /// <summary>
        /// 开始一个协程。
        /// <para>使用 yield 语句，可以在协程执行过程的任意一个 yield 语句点处暂停执行。 yield return value 规定了协程在何处恢复执行。当为跨跃多个帧的行为建模时，协程是非常棒的。协程几乎没有性能开销。 StartCoroutine 函数总是立即返回，但是你可以继续 yield 本函数的返回结果。这将导致等待协程执行完毕。</para>
        /// <para>当使用JavaScript时，你不需要使用 StartCoroutine 函数，编译器会为你做这些。当编写 C# 代码时， 你必须主动调用 StartCoroutine。</para>
        /// </summary>
        /// <param name="routine">迭代器方式实现的协程的迭代器</param>
        /// <returns>Coroutine 对象</returns>
        public Coroutine StartCoroutine(IEnumerator routine) { return default(Coroutine); }
        /// <summary>
        /// 开始一个指定的方法名的协程。
        /// <para>在大部分情况下，你需要使用的是 StartCoroutine(IEnumerator routine) 变种。然而接受字符串描述方法名的 StartCoroutine 允许你使用 StopCoroutine 配合方法名字来停止指定的协程。其坏处是字符串版本为了执行协程会拥有较高的运行时开销，而且你只能传递一个参数。</para>
        /// </summary>
        /// <param name="methodName">方法名</param>
        /// <param name="value">该方法接收的参数</param>
        /// <returns>Coroutine 对象</returns>
        public Coroutine StartCoroutine(string methodName, object value = null) { return default(Coroutine); }
    }
}