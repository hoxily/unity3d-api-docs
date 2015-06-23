using System;

namespace UnityEngine
{
    public struct Color32
    {
        public byte a;
        public byte b;
        public byte g;
        public byte r;

        public Color32(byte r, byte g, byte b, byte a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public static implicit operator Color32(Color c) { return default(Color32); }
        public static implicit operator Color(Color32 c) { return default(Color); }

        public static Color32 Lerp(Color32 a, Color32 b, float t) { return default(Color32); }
        public override string ToString() { return default(string); }
        public string ToString(string format) { return default(string); }
    }
}