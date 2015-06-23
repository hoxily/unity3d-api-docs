using System;

namespace UnityEngine
{
    /// <summary>
    /// 用于产生随机数据的类。
    /// </summary>
    public sealed class Random
    {
        /// <summary>
        /// 创建新实例。
        /// </summary>
        public Random() { }
        /// <summary>
        /// 返回一个位于单位圆里面的随机位置点（只读）。
        /// </summary>
        public static Vector2 insideUnitCircle { get { return default(Vector2); } }
        /// <summary>
        /// 返回一个位于单位球体里面的随机位置点（只读）。
        /// </summary>
        public static Vector3 insideUnitSphere { get { return default(Vector3); } }
        /// <summary>
        /// 返回一个位于单位球体表面的随机位置点（只读）。
        /// </summary>
        public static Vector3 onUnitSphere { get { return default(Vector3); } }
        /// <summary>
        /// 返回一个随机的旋转。
        /// </summary>
        public static Quaternion rotation { get { return default(Quaternion); } }
        /// <summary>
        /// 返回一个均匀分布的随机旋转。
        /// </summary>
        public static Quaternion rotationUniform { get { return default(Quaternion); } }
        /// <summary>
        /// 设置随机数发生器的种子。
        /// <para>随机数发生器不是真正的随机，而是依照预设的序列产生数值（序列中的值在某个范围内“跳动”，这样一来对于大多数目的而言，它们是显得随机的）。</para>
        /// <para>在一个特定的伪随机数发生器运转的最开始，选用的那个整数被称之为种子值。在随机数函数调用之前，种子值一般被设置为一些任意值，例如系统时钟。这避免了每次游戏运行时，总是同样的随机数序列的出现，因而避免了可预测的游戏。然而，有时候需要产生一模一样的伪随机数序列值，这时你可以手动设置随机数种子。</para>
        /// <para>你可以设置你自己的种子。例如当你程序化地产生游戏级别时。在产生它们之前，你可以设置一个预设种子值，使用随机选择的元素来让场景看起来是任意的且自然的。这样做可以保证在每次玩游戏时产生的都是相同的“随机的”模式。这是一个经常被用来减少游戏存储空间的有效方法——你可以程序化地产生想要多少就有多少的等级（关卡？），却仅仅只需存储一个整型的种子值。</para>
        /// </summary>
        public static int seed { get; set; }
        /// <summary>
        /// 返回一个 位于 0.0（含）到 1.0（含）之间的随机数（只读）。
        /// <para>此属性有可能返回 0.0 或者 1.0. 此行为与许多别的随机数发生器不同，它们只产生一个小于但永远不会完全等于 1.0 的值。</para>
        /// </summary>
        public static float value { get { return default(float); } }

        [Obsolete("Use Random.Range instead")]
        public static float RandomRange(float min, float max) { return default(float); }
        [Obsolete("Use Random.Range instead")]
        public static int RandomRange(int min, int max) { return default(int); }
        [WrapperlessIcall]
        /// <summary>
        /// 返回一个位于 min（含）到 max（不含）之间的随机浮点数（只读）。
        /// </summary>
        /// <param name="min">所需随机浮点数的下界（含）</param>
        /// <param name="max">所需随机浮点数的上界（不含）</param>
        /// <returns>一个位于 min（含）到 max（不含）之间的随机浮点数。</returns>
        public static float Range(float min, float max) { return default(float); }
        /// <summary>
        /// 返回一个位于 min（含）到 max（不含）之间的随机整数（只读）。
        /// <para>如果 max 与 min 相等，将会返回 min。返回值永远不会是 max，除非 min 等于 max。</para>
        /// </summary>
        /// <param name="min">所需随机整数的下界（含）</param>
        /// <param name="max">所需随机整数的上界（不含）</param>
        /// <returns>一个位于 min（含）到 max（不含）之间的随机整数。</returns>
        public static int Range(int min, int max) { return default(int); }
    }
}
