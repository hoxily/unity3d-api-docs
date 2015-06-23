using System;
using System.Reflection;

namespace UnityEngine
{
    public struct Vector4
    {
        public const float kEpsilon = 1e-005f;

        public float w;
        public float x;
        public float y;
        public float z;

        public Vector4(float x, float y):this() { }
        public Vector4(float x, float y, float z):this() { }
        public Vector4(float x, float y, float z, float w):this() { }

        public static Vector4 operator -(Vector4 a) { return default(Vector4); }
        public static Vector4 operator -(Vector4 a, Vector4 b) { return default(Vector4); }
        public static bool operator !=(Vector4 lhs, Vector4 rhs) { return default(bool); }
        public static Vector4 operator *(float d, Vector4 a) { return default(Vector4); }
        public static Vector4 operator *(Vector4 a, float d) { return default(Vector4); }
        public static Vector4 operator /(Vector4 a, float d) { return default(Vector4); }
        public static Vector4 operator +(Vector4 a, Vector4 b) { return default(Vector4); }
        public static bool operator ==(Vector4 lhs, Vector4 rhs) { return default(bool); }
        public static implicit operator Vector4(Vector2 v) { return default(Vector4); }
        public static implicit operator Vector4(Vector3 v) { return default(Vector4); }
        public static implicit operator Vector3(Vector4 v) { return default(Vector3); }
        public static implicit operator Vector2(Vector4 v) { return default(Vector2); }

        public float magnitude { get { return default(float); } }
        public Vector4 normalized { get { return default(Vector4); } }
        public static Vector4 one { get { return default(Vector4); } }
        public float sqrMagnitude { get { return default(float); } }
        public static Vector4 zero { get { return default(Vector4); } }

        public float this[int index] { get { return default(float); } set { } }

        public static float Distance(Vector4 a, Vector4 b) { return default(float); }
        public static float Dot(Vector4 a, Vector4 b) { return default(float); }
        public override bool Equals(object other) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static Vector4 Lerp(Vector4 from, Vector4 to, float t) { return default(Vector4); }
        public static float Magnitude(Vector4 a) { return default(float); }
        public static Vector4 Max(Vector4 lhs, Vector4 rhs) { return default(Vector4); }
        public static Vector4 Min(Vector4 lhs, Vector4 rhs) { return default(Vector4); }
        public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta) { return default(Vector4); }
        public void Normalize() { }
        public static Vector4 Normalize(Vector4 a) { return default(Vector4); }
        public static Vector4 Project(Vector4 a, Vector4 b) { return default(Vector4); }
        public void Scale(Vector4 scale) { }
        public static Vector4 Scale(Vector4 a, Vector4 b) { return default(Vector4); }
        public void Set(float new_x, float new_y, float new_z, float new_w) { }
        public float SqrMagnitude() { return default(float); }
        public static float SqrMagnitude(Vector4 a) { return default(float); }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
    }
}