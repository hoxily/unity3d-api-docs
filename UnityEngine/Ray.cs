using System;

namespace UnityEngine
{
    public struct Ray
    {
        public Ray(Vector3 origin, Vector3 direction):this() { }

        public Vector3 direction { get; set; }
        public Vector3 origin { get; set; }

        public Vector3 GetPoint(float distance) { return default(Vector3); }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
    }
}