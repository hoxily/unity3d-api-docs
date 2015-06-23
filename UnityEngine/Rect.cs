using System;

namespace UnityEngine
{
    public struct Rect
    {
        public Rect(Rect source):this() { }
        public Rect(float left, float top, float width, float height):this() { }

        public static bool operator !=(Rect lhs, Rect rhs) { return default(bool); }
        public static bool operator ==(Rect lhs, Rect rhs) { return default(bool); }

        [Obsolete("use yMax")]
        public float bottom { get { return default(float); } }
        public Vector2 center { get; set; }
        public float height { get; set; }
        [Obsolete("use xMin")]
        public float left { get { return default(float); } }
        public Vector2 max { get; set; }
        public Vector2 min { get; set; }
        public Vector2 position { get; set; }
        [Obsolete("use xMax")]
        public float right { get { return default(float); } }
        public Vector2 size { get; set; }
        [Obsolete("use yMin")]
        public float top { get { return default(float); } }
        public float width { get; set; }
        public float x { get; set; }
        public float xMax { get; set; }
        public float xMin { get; set; }
        public float y { get; set; }
        public float yMax { get; set; }
        public float yMin { get; set; }

        public bool Contains(Vector2 point) { return default(bool); }
        public bool Contains(Vector3 point) { return default(bool); }
        public bool Contains(Vector3 point, bool allowInverse) { return default(bool); }
        public override bool Equals(object other) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static Rect MinMaxRect(float left, float top, float right, float bottom) { return default(Rect); }
        public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates) { return default(Vector2); }
        public bool Overlaps(Rect other) { return default(bool); }
        public bool Overlaps(Rect other, bool allowInverse) { return default(bool); }
        public static Vector2 PointToNormalized(Rect rectangle, Vector2 point) { return default(Vector2); }
        public void Set(float left, float top, float width, float height) { }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
    }
}