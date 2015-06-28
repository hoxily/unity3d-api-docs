namespace UnityEngine
{
    /// <summary>
    /// <para>表达三维向量和坐标点。</para>
    ///	<para>这个结构在整个Unity中用于传递三维位置以及方向。同时它也包含了一些用于常规向量运算的函数。</para>
    ///	<para>除了类内的这些函数，还有其他的类也可以用来操纵向量与坐标点。比如 Quaternion 以及 Matrix4x4 类，在旋转或者变换向量与坐标点时很有用。</para>
    /// </summary>
    public struct Vector3
    {
        /// <summary>
        /// 当两个向量距离小于此值时被认为是相同的。
        /// </summary>
        public const float kEpsilon = 1e-005f;
        /// <summary>
        /// 这个向量的 X 分量。
        /// </summary>
        public float x;
        /// <summary>
        /// 这个向量的 Y 分量。
        /// </summary>
        public float y;
        /// <summary>
        /// 这个向量的 Z 分量。
        /// </summary>
        public float z;
        /// <summary>
        /// 使用指定的 x, y 分量创建一个新向量，设置 z 为零。
        /// </summary>
        /// <param name="x">x 分量</param>
        /// <param name="y">y 分量</param>
        public Vector3(float x, float y) : this() { }
        /// <summary>
        /// 使用指定的 x, y, z 分量创建一个新向量
        /// </summary>
        /// <param name="x">x 分量</param>
        /// <param name="y">y 分量</param>
        /// <param name="z">z 分量</param>
        public Vector3(float x, float y, float z) : this() { }

    }
}
