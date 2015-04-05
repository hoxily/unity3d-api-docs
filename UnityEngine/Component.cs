using System;
using UnityEngine.Internal;
//using UnityEngineInternal;

namespace UnityEngine
{
    /// <summary>
    /// Component 是所有附加到 GameObject 上的东西的基类。
    /// <para>请注意，你的代码绝对不会直接创建一个 Component。取而代之的是，编写脚本代码，然后附加脚本到一个 GameObject 上。另请参见：使用 ScriptableObject 作为一种创建脚本但不附着在任何 GameObject 上的方法。</para>
    /// </summary>
    public class Component : Object
    {
        /// <summary>
        /// 创建新实例。
        /// </summary>
        public Component() { }
    }
}

