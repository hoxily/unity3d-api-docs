using System;

namespace UnityEngine
{
    [Serializable]
    public sealed class GUIStyleState
    {
        public GUIStyleState() { }

        public Texture2D background { get; set; }
        public Color textColor { get; set; }
    }
}