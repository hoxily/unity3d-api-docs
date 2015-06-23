using System;

namespace UnityEngine
{
    [Serializable]
    public sealed class GUISettings
    {
        public GUISettings() { }

        public Color cursorColor { get; set; }
        public float cursorFlashSpeed { get; set; }
        public bool doubleClickSelectsWord { get; set; }
        public Color selectionColor { get; set; }
        public bool tripleClickSelectsLine { get; set; }
    }
}