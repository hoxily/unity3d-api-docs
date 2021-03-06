﻿using System;

namespace UnityEngine
{
    /// <summary>
    /// 获取Unity的时间相关信息的接口。
    /// </summary>
    public sealed class Time
    {
        /// <summary>
        /// 创建新实例。
        /// </summary>
        public Time() { }
        /// <summary>
        /// 降低游戏播放的时间流速，使得能够在各帧之间顺利保存屏幕截图。
        /// <para>如果该属性的值非零，那么每帧更新操作会以（1.0 / captureFramerate）的时间间隔进行，不管实际时间以及渲染一帧所需的时间。这在你需要录制一段视频时很有用。因为你需要一个恒定的帧率以及在各帧之间留有足以保存屏截图的时间。</para>
        /// </summary>
        public static int captureFramerate { get; set; }
        /// <summary>
        /// 完成上一帧所花费的时间，单位秒（只读）。
        /// <para>使用这个函数让你的游戏与帧率无关。</para>
        /// <para>如果你在每一帧增加或者减少某个变量，那么你最好乘上 Time.deltaTime. 当你乘上 Time.deltaTime 时，你所表达的意思是：我想要每秒移动这个物体10米，而不是每帧移动10米。</para>
        /// <para>如果是在 MonoBehaviour 的 FixedUpdate 内调用， 那么返回的是固定帧率的时间差。</para>
        /// <para>请注意：你不应该在 OnGUI 里面依赖 Time.deltaTime，因为在同一帧里可能多次调用 OnGUI，这时 Time.deltaTime 都是同一个值，直到下一帧才会被更新。</para>
        /// </summary>
        public static float deltaTime { get { return default(float); } }
        /// <summary>
        /// 物理系统以及其他固定帧率的更新（例如 MonoBehaviour 的 FixedUpdate）的时间间隔，单位秒。
        /// <para>为了读取增量时间建议使用 Time.deltaTime，因为如果你是在 FixedUpdate 函数或 Update 函数里，那么它自动返回正确的增量时间。</para>
        /// <para>请注意，考虑到游戏内时间，fixedDeltaTime 时间间隔是受 timeScale 的影响。</para>
        /// </summary>
        public static float fixedDeltaTime { get; set; }
        /// <summary>
        /// 最近一次开始 FixedUpdate 的时间（只读）。这是从游戏开始以来的时间，单位为秒。
        /// <para>固定时间以固定的时间间隔更新（相当于 fixedDeltaTime），直到达到 time 属性。</para>
        /// </summary>
        public static float fixedTime { get { return default(float); } }
        /// <summary>
        /// 流逝的帧数的累计值（只读）。
        /// </summary>
        public static int frameCount { get { return default(int); } }
        /// <summary>
        /// 每帧所能占用的最大时间。物理以及其他固定帧率更新（例如 MonoBehaviour 的 FixedUpdate），每帧最多执行此时间之久。
        /// <para>使用此函数来避免因为垃圾回收器和昂贵的物理以及其他固定帧率更新的组合所带来的低帧率高峰。</para>
        /// <para>当某帧占用了超过此值的时间时，物理和其他固定帧率更新的执行将会减少。这会临时性地降低游戏速度，但是却能让帧率跟上节奏，避免恶心的结巴。</para>
        /// <para>推荐每帧的最大占用时间在 1/10 秒到 1/3 秒之间。</para>
        /// </summary>
        public static float maximumDeltaTime { get; set; }
        /// <summary>
        /// 从游戏开始到现在的实际的时间，单位为秒（只读）。
        /// <para>在几乎所有的情况下，你都能用且应该用 Time.time 代替。</para>
        /// <para>realtimeSinceStartup 返回不受 Time.timeScale 影响的从开始起计算的时间。即使是玩家暂停住了（丢在后台），realtimeSinceStartup 依然保持增长。当你通过设置 Time.timeScale 为零来使游戏暂停，却仍然想要度量时间时，此时 realtimeSinceStartup 将会很有用。</para>
        /// <para>请注意，realtimeSinceStartup 返回系统定时器报告的时间。具体取决于平台和硬件，它甚至有可能在多个连续的帧里报告同一个值。如果你想用时间差除别的东西，小心这个问题（时间差可能为零！）。</para>
        /// </summary>
        public static float realtimeSinceStartup { get { return default(float); } }
        public static int renderedFrameCount { get { return default(int); } }
        /// <summary>
        /// Time.deltaTime 平滑处理后的结果（只读）。
        /// </summary>
        public static float smoothDeltaTime { get { return default(float); } }
        /// <summary>
        /// 此帧开始的时间。这是从游戏开始起计算的时间，单位为秒。也就是说，从游戏开始到到现在所用的时间。
        /// <para>如果在同一帧内调用多次，返回相同的值。当在 MonoBehaviour 的 FixedUpdate 里调用的时候，返回的是 fixedTime 属性。</para>
        /// </summary>
        public static float time { get { return default(float); } }
        /// <summary>
        /// 时间流逝速度的缩放比例。该属性可以被用来制作慢镜头特效。
        /// <para>当 timeScale 为 1.0 时，时间的流逝速度是正常的时间流速。当 timeScale 是 0.5 时，时间的流速是正常时间流速的 1/2.</para>
        /// <para>当 timeScale 被设置为零时，游戏基本上就暂停了，只要你所有的函数都是帧率无关的。</para>
        /// <para>timeScale 影响 Time 类的所有 time 和 deltaTime 属性变量，除了 realtimeSinceStartup 。</para>
        /// <para>如果你降低 timeScale，那么建议你也降低 Time.fixedDeltaTime 同样的数量。</para>
        /// <para>当 timeScale 被设为零时， 函数 FixedUpdate 将不会被调用</para>
        /// </summary>
        public static float timeScale { get; set; }
        /// <summary>
        /// 此帧开始的时间（只读）。这是从最后一个等级（场景？）加载开始计算的秒数。
        /// </summary>
        public static float timeSinceLevelLoad { get { return default(float); } }
        /// <summary>
        /// 不受 timeScale 影响的完成上一帧所花费的时间，单位秒（只读）。
        /// </summary>
        public static float unscaledDeltaTime { get { return default(float); } }
        /// <summary>
        /// 不受 timeScale 影响的此帧开始的时间。这是从游戏开始起计算的时间，单位为秒。
        /// <para>如果在同一帧内调用多次，返回相同的值。与 time 不同的是该值不受 timeScale 影响。</para>
        /// </summary>
        public static float unscaledTime { get { return default(float); } }
    }
}
