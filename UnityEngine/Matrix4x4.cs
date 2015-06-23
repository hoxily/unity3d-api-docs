using System;
using System.Reflection;

namespace UnityEngine
{
    public struct Matrix4x4
    {
        public float m00;
        public float m01;
        public float m02;
        public float m03;
        public float m10;
        public float m11;
        public float m12;
        public float m13;
        public float m20;
        public float m21;
        public float m22;
        public float m23;
        public float m30;
        public float m31;
        public float m32;
        public float m33;

        public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs) { return default(bool); }
        public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs) { return default(Matrix4x4); }
        public static Vector4 operator *(Matrix4x4 lhs, Vector4 v) { return default(Vector4); }
        public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs) { return default(bool); }

        public static Matrix4x4 identity { get { return default(Matrix4x4); } }
        public Matrix4x4 inverse { get { return default(Matrix4x4); } }
        public bool isIdentity { get { return default(bool); } }
        public Matrix4x4 transpose { get { return default(Matrix4x4); } }
        public static Matrix4x4 zero { get { return default(Matrix4x4); } }

        public float this[int index] { get { return default(float); } set { } }
        public float this[int row, int column] { get { return default(float); } set { } }

        public override bool Equals(object other) { return default(bool); }
        public Vector4 GetColumn(int i) { return default(Vector4); }
        public override int GetHashCode() { return default(int); }
        public Vector4 GetRow(int i) { return default(Vector4); }
        public static Matrix4x4 Inverse(Matrix4x4 m) { return default(Matrix4x4); }
        public Vector3 MultiplyPoint(Vector3 v) { return default(Vector3); }
        public Vector3 MultiplyPoint3x4(Vector3 v) { return default(Vector3); }
        public Vector3 MultiplyVector(Vector3 v) { return default(Vector3); }
        public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { return default(Matrix4x4); }
        public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { return default(Matrix4x4); }
        public static Matrix4x4 Scale(Vector3 v) { return default(Matrix4x4); }
        public void SetColumn(int i, Vector4 v) { }
        public void SetRow(int i, Vector4 v) { }
        public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
        public static Matrix4x4 Transpose(Matrix4x4 m) { return default(Matrix4x4); }
        public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { return default(Matrix4x4); }
    }
}
