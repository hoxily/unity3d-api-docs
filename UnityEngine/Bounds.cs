using System;

namespace UnityEngine
{
    public struct Bounds
    {
        public Bounds(Vector3 center, Vector3 size) : this() { }

        public static bool operator !=(Bounds lhs, Bounds rhs) { return default(bool); }
        public static bool operator ==(Bounds lhs, Bounds rhs) { return default(bool); }

        public Vector3 center { get; set; }
        public Vector3 extents { get; set; }
        public Vector3 max { get; set; }
        public Vector3 min { get; set; }
        public Vector3 size { get; set; }

        public Vector3 ClosestPoint(Vector3 point) { return default(Vector3); }
        public bool Contains(Vector3 point) { return default(bool); }
        public void Encapsulate(Bounds bounds) { }
        public void Encapsulate(Vector3 point) { }
        public override bool Equals(object other) { return default(bool); }
        public void Expand(float amount) { }
        public void Expand(Vector3 amount) { }
        public override int GetHashCode() { return default(int); }
        public bool IntersectRay(Ray ray) { return default(bool); }
        public bool IntersectRay(Ray ray, out float distance) { distance = default(float); return default(bool); }
        public bool Intersects(Bounds bounds) { return default(bool); }
        public void SetMinMax(Vector3 min, Vector3 max) { }
        public float SqrDistance(Vector3 point) { return default(float); }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
    }
}