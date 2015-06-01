using System;
using System.Reflection;
using UnityEngine.Internal;

namespace UnityEngine
{
    /// <summary>
    /// Quaternion 用来表达旋转。
    /// <para>四元数是紧凑的，不受万向节锁之苦的，能很容易地被插值的。Unity内部使用四元数表达所有的旋转。</para>
    /// <para>四元数基于复数，且不是那么容易直观地理解。你几乎不会访问或者修改四元数的独立分量（x,y,z,w）；大部分时候你仅仅拿到一个已存在的旋转（例如来自 Transform），然后用它构造一个新的旋转（例如平滑地在两个旋转之间进行插值）。在 Quaternion 里，你 99% 时间使用的函数是：Quaternion.LookRotation、Quaternion.Angle、Quaternion.Euler、Quaternion.Slerp、Quaternion.FromToRotation 以及 Quaternion.identity 。（其他函数仅仅用于特别使用。）</para>
    /// <para>你可以使用重载过的 * 运算符来旋转一个旋转，或者旋转一个向量。</para>
    /// </summary>
    public struct Quaternion
    {
        public const float kEpsilon = 1e-006f;

        public float w;
        public float x;
        public float y;
        public float z;

        public Quaternion(float x, float y, float z, float w) : this() { this.x = x; this.y = y; this.z = z; this.w = w; }

        public static bool operator !=(Quaternion lhs, Quaternion rhs) { return default(bool); }
        public static Quaternion operator *(Quaternion lhs, Quaternion rhs) { return default(Quaternion); }
        public static Vector3 operator *(Quaternion rotation, Vector3 point) { return default(Vector3); }
        public static bool operator ==(Quaternion lhs, Quaternion rhs) { return default(bool); }

        public Vector3 eulerAngles { get; set; }
        public static Quaternion identity { get { return default(Quaternion); } }

        public float this[int index] { get { return default(float); } set { } }

        public static float Angle(Quaternion a, Quaternion b) { return default(float); }
        public static Quaternion AngleAxis(float angle, Vector3 axis) { return default(Quaternion); }
        [Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion AxisAngle(Vector3 axis, float angle) { return default(Quaternion); }
        public static float Dot(Quaternion a, Quaternion b) { return default(float); }
        public override bool Equals(object other) { return default(bool); }
        public static Quaternion Euler(Vector3 euler) { return default(Quaternion); }
        public static Quaternion Euler(float x, float y, float z) { return default(Quaternion); }
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion EulerAngles(Vector3 euler) { return default(Quaternion); }
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion EulerAngles(float x, float y, float z) { return default(Quaternion); }
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion EulerRotation(Vector3 euler) { return default(Quaternion); }
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion EulerRotation(float x, float y, float z) { return default(Quaternion); }
        public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { return default(Quaternion); }
        public override int GetHashCode() { return default(int); }
        public static Quaternion Inverse(Quaternion rotation) { return default(Quaternion); }
        public static Quaternion Lerp(Quaternion from, Quaternion to, float t) { return default(Quaternion); }
        [ExcludeFromDocs]
        public static Quaternion LookRotation(Vector3 forward) { return default(Quaternion); }
        public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { return default(Quaternion); }
        public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { return default(Quaternion); }
        public void Set(float new_x, float new_y, float new_z, float new_w) { }
        [Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetAxisAngle(Vector3 axis, float angle) { }
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetEulerAngles(Vector3 euler) { }
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetEulerAngles(float x, float y, float z) { }
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetEulerRotation(Vector3 euler) { }
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetEulerRotation(float x, float y, float z) { }
        public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection) { }
        [ExcludeFromDocs]
        public void SetLookRotation(Vector3 view) { }
        public void SetLookRotation(Vector3 view, Vector3 up) { }
        public static Quaternion Slerp(Quaternion from, Quaternion to, float t) { return default(Quaternion); }
        public void ToAngleAxis(out float angle, out Vector3 axis) { angle = default(float); axis = default(Vector3); }
        [Obsolete("Use Quaternion.ToAngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
        public void ToAxisAngle(out Vector3 axis, out float angle) { axis = default(Vector3); angle = default(float); }
        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
        public Vector3 ToEuler() { return default(Vector3); }
        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
        public Vector3 ToEulerAngles() { return default(Vector3); }
        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
        public static Vector3 ToEulerAngles(Quaternion rotation) { return default(Vector3); }
        public override string ToString() { { return default(string); } }
        public string ToString(string format) { return default(string); }
    }
}
