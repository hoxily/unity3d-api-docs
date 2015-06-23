using System;

namespace UnityEngine
{
    [Serializable]
    public sealed class RectOffset
    {
        public RectOffset() { }
        public RectOffset(int left, int right, int top, int bottom) { }

        public int bottom { get; set; }
        public int horizontal { get { return default(int); } }
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
        public int vertical { get { return default(int); } }

        public Rect Add(Rect rect) { return default(Rect); }
        public Rect Remove(Rect rect) { return default(Rect); }
        public override string ToString() { return default(string); }
    }
}
