using System;

namespace UnityEngine
{
    [Serializable]
    public sealed class GUIContent
    {
        public static GUIContent none;

        public GUIContent() { }
        public GUIContent(GUIContent src) { }
        public GUIContent(string text) { }
        public GUIContent(Texture image) { }
        public GUIContent(string text, string tooltip) { }
        public GUIContent(string text, Texture image) { }
        public GUIContent(Texture image, string tooltip) { }
        public GUIContent(string text, Texture image, string tooltip) { }

        public Texture image { get; set; }
        public string text { get; set; }
        public string tooltip { get; set; }
    }
}