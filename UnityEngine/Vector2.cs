using System;
using System.Reflection;

namespace UnityEngine
{
    /// <summary>
    /// 表达二维的向量和坐标点。
    /// <para>这个结构被用在表达二维位置以及向量的地方（例如 Mesh 中的纹理坐标、Material 中的的纹理偏移量）。在大多数的其他情况下，使用 Vector3 。</para>
    /// </summary>
    public struct Vector2
    {
        public const float kEpsilon = 1e-005f;

        public float x;
        public float y;

        public Vector2(float x, float y) : this() { }

        public static Vector2 operator -(Vector2 a) { return default(Vector2); }
        public static Vector2 operator -(Vector2 a, Vector2 b) { return default(Vector2); }
        public static bool operator !=(Vector2 lhs, Vector2 rhs) { return default(bool); }
        public static Vector2 operator *(float d, Vector2 a) { return default(Vector2); }
        public static Vector2 operator *(Vector2 a, float d) { return default(Vector2); }
        public static Vector2 operator /(Vector2 a, float d) { return default(Vector2); }
        public static Vector2 operator +(Vector2 a, Vector2 b) { return default(Vector2); }
        public static bool operator ==(Vector2 lhs, Vector2 rhs) { return default(bool); }
        public static implicit operator Vector3(Vector2 v) { return default(Vector3); }
        public static implicit operator Vector2(Vector3 v) { return default(Vector2); }
        /// <summary>
        /// 返回这个向量的长度（只读）。
        /// <para>向量的长度被定义为（x*x+y*y）的平方根。</para>
        /// <para>如果你仅仅需要比较一些向量的大小，你可以使用它们长度的平方来代替，即 sqrMagnitude （计算长度的平方比计算长度要快一些）。</para>
        /// <para><seealso cref="sqrMagnitude"/></para>
        /// </summary>
        public float magnitude { get { return default(float); } }
        /// <summary>
        /// 返回这个向量的单位化向量（只读）。
        /// <para>当被正规化后，向量保持它原有的方向，但长度变为 1.0.</para>
        /// <para>请注意，当前向量并没有发生改变，而是一个新的正规化后的向量被返回。如果你想要正规化当前向量，请使用 Normalize 函数。</para>
        /// <para>如果向量太小而不能被正规化，那么将会返回一个零向量。</para>
        /// <para><seealso cref="Normalize"/></para>
        /// </summary>
        public Vector2 normalized { get { return default(Vector2); } }
        /// <summary>
        /// Vector2(1, 1) 的简便写法。
        /// </summary>
        public static Vector2 one { get { return default(Vector2); } }
        /// <summary>
        /// Vector2(1, 0) 的简便写法。
        /// </summary>
        public static Vector2 right { get { return default(Vector2); } }
        public float sqrMagnitude { get { return default(float); } }
        /// <summary>
        /// Vector2(0, 1) 的简便写法。
        /// </summary>
        public static Vector2 up { get { return default(Vector2); } }
        /// <summary>
        /// Vector2(0, 0) 的简便写法。
        /// </summary>
        public static Vector2 zero { get { return default(Vector2); } }

        public float this[int index] { get { return default(float); } set { } }

        public static float Angle(Vector2 from, Vector2 to) { return default(float); }
        public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { return default(Vector2); }
        public static float Distance(Vector2 a, Vector2 b) { return default(float); }
        public static float Dot(Vector2 lhs, Vector2 rhs) { return default(float); }
        public override bool Equals(object other) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static Vector2 Lerp(Vector2 from, Vector2 to, float t) { return default(Vector2); }
        public static Vector2 Max(Vector2 lhs, Vector2 rhs) { return default(Vector2); }
        public static Vector2 Min(Vector2 lhs, Vector2 rhs) { return default(Vector2); }
        public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) { return default(Vector2); }
        public void Normalize() { }
        public void Scale(Vector2 scale) { }
        public static Vector2 Scale(Vector2 a, Vector2 b) { return default(Vector2); }
        public void Set(float new_x, float new_y) { }
        public float SqrMagnitude() { return default(float); }
        public static float SqrMagnitude(Vector2 a) { return default(float); }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
    }
}
