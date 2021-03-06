﻿using System;
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
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName) { }
        [ExcludeFromDocs]
        public void BroadcastMessage(string methodName, object parameter) { }
        public void BroadcastMessage(string methodName, SendMessageOptions options) { }
        /// <summary>
        /// 在此游戏物体以及它的子物体的每个 MonoBehavior 上调用指定的名字的方法。
        /// <para>接收消息的方法可以通过定义零个参数来忽略 parameter. 如果 options 设置为 SendMessageOptions.RequireReceiver，那么一旦这条消息没被任何组件拾取，就会打印出错误信息。</para>
        /// </summary>
        /// <param name="methodName">要调用的方法的名字</param>
        /// <param name="parameter">传递的参数</param>
        /// <param name="options">如果目标物体上不存在指定的方法，是否要报告错误</param>
        public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }
        [ExcludeFromDocs]
        public void SendMessage(string methodName) { }
        [ExcludeFromDocs]
        public void SendMessage(string methodName, object value) { }
        public void SendMessage(string methodName, SendMessageOptions options) { }
        /// <summary>
        /// 在此游戏物体的每个 MonoBehavior 上调用指定的名字的方法。
        /// <para>接收消息的方法可以通过定义零个参数来忽略 parameter. 如果 options 设置为 SendMessageOptions.RequireReceiver，那么一旦这条消息没被任何组件拾取，就会打印出错误信息。</para>
        /// <para>请注意，消息不会发送到不活动的物体（例如那些在编辑器中设置为无效化的，或者那些通过 SetActive 函数设置为无效化的）。</para>
        /// </summary>
        /// <param name="methodName">要调用的方法的名字</param>
        /// <param name="value">传递的参数</param>
        /// <param name="options">如果目标物体上不存在指定的方法，是否要报告错误</param>
        public void SendMessage(string methodName, object value, SendMessageOptions options) { }
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName) { }
        [ExcludeFromDocs]
        public void SendMessageUpwards(string methodName, object value) { }
        public void SendMessageUpwards(string methodName, SendMessageOptions options) { }
        /// <summary>
        /// 在此游戏物体以及它的父级物体的每个 MonoBehavior 上调用指定的名字的方法。
        /// <para>接收消息的方法可以通过定义零个参数来忽略 parameter. 如果 options 设置为 SendMessageOptions.RequireReceiver，那么一旦这条消息没被任何组件拾取，就会打印出错误信息。</para>
        /// <para>请注意，消息不会发送到不活动的物体（例如那些在编辑器中设置为无效化的，或者那些通过 SetActive 函数设置为无效化的）。</para>
        /// </summary>
        /// <param name="methodName">要调用的方法的名字</param>
        /// <param name="value">传递的参数</param>
        /// <param name="options">如果目标物体上不存在指定的方法，是否要报告错误</param>
        public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }
    }
}

