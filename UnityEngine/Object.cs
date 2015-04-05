//using UnityEngine.Internal;
//using UnityEngineInternal;
namespace UnityEngine
{
    /// <summary>
    /// <para>所有能被 Unity 引用的对象的基类。</para>
    /// <para>你创建的任何从 Object 继承的变量都会在 inspector 里显示，成为拖放的目的地。允许你从 GUI 界面设置这些变量的值。</para>
    /// </summary>
    public class Object:object
    {
        /// <summary>
        /// 哈希函数。
        /// </summary>
        /// <returns>当前 UnityEngine.Object 的哈希代码。</returns>
        public override int GetHashCode()
        {
            return default(int);
        }
        /// <summary>
        /// 确定指定的 UnityEngine.Object 是否等于当前的 UnityEngine.Object。
        /// </summary>
        /// <param name="obj">要与当前对象进行比较的对象。</param>
        /// <returns>如果指定的对象等于当前对象，则为 true；否则为 false。</returns>
        public override bool Equals(object obj)
        {
            return default(bool);
        }
        /// <summary>
        /// 初始化 UnityEngine.Object 类的新实例
        /// </summary>
        public Object() { }
        /// <summary>
        /// 比较并判断这两个变量是不是引用了不同的对象。
        /// </summary>
        /// <param name="x">其中一个变量</param>
        /// <param name="y">另外一个变量</param>
        /// <returns>是不是引用了不同的对象</returns>
        public static bool operator !=(Object x, Object y) { return default(bool); }
        /// <summary>
        /// 比较并判断这两个变量是不是引用了同一个对象。
        /// </summary>
        /// <param name="x">第一个变量</param>
        /// <param name="y">与第一个变量进行比较的变量</param>
        /// <returns>是不是引用了同一个对象</returns>
        public static bool operator ==(Object x, Object y) { return default(bool); }
        /// <summary>
        /// 这个物体存在吗？（也就是判定它是否为 null）
        /// </summary>
        /// <param name="exists">这个物体</param>
        /// <returns>这个物体存不存在</returns>
        public static implicit operator bool(Object exists) { return default(bool); }
        /// <summary>
        /// 这个物体的名字
        /// <para>所有附着在 GameObject 上的 Component 们，与这个 GameObject 共享这同一个名字。</para>
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 返回这个游戏物体的名字
        /// </summary>
        /// <returns>这个物体的名字</returns>
        public override string ToString()
        {
            return default(string);
        }
    }
}
