using System;
using System.Collections;

namespace UnityEngine
{
    [Serializable]
    [ExecuteInEditMode]
    public sealed class GUISkin : ScriptableObject
    {
        public GUISkin() { }

        public GUIStyle box { get; set; }
        public GUIStyle button { get; set; }
        public GUIStyle[] customStyles { get; set; }
        public Font font { get; set; }
        public GUIStyle horizontalScrollbar { get; set; }
        public GUIStyle horizontalScrollbarLeftButton { get; set; }
        public GUIStyle horizontalScrollbarRightButton { get; set; }
        public GUIStyle horizontalScrollbarThumb { get; set; }
        public GUIStyle horizontalSlider { get; set; }
        public GUIStyle horizontalSliderThumb { get; set; }
        public GUIStyle label { get; set; }
        public GUIStyle scrollView { get; set; }
        public GUISettings settings { get { return default(GUISettings); } }
        public GUIStyle textArea { get; set; }
        public GUIStyle textField { get; set; }
        public GUIStyle toggle { get; set; }
        public GUIStyle verticalScrollbar { get; set; }
        public GUIStyle verticalScrollbarDownButton { get; set; }
        public GUIStyle verticalScrollbarThumb { get; set; }
        public GUIStyle verticalScrollbarUpButton { get; set; }
        public GUIStyle verticalSlider { get; set; }
        public GUIStyle verticalSliderThumb { get; set; }
        public GUIStyle window { get; set; }

        public GUIStyle FindStyle(string styleName) { return default(GUIStyle); }
        public IEnumerator GetEnumerator() { return default(IEnumerator); }
        public GUIStyle GetStyle(string styleName) { return default(GUIStyle); }
    }
}