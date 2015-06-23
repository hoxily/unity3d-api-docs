using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    [Serializable]
    public sealed class GUIStyle
    {
        public GUIStyle() { }
        public GUIStyle(GUIStyle other) { }

        public static implicit operator GUIStyle(string str) { return default(GUIStyle); }

        public GUIStyleState active { get; set; }
        public TextAnchor alignment { get; set; }
        public RectOffset border { get; set; }
        [Obsolete("Don't use clipOffset - put things inside begingroup instead. This functionality will be removed in a later version.")]
        public Vector2 clipOffset { get; set; }
        public TextClipping clipping { get; set; }
        public Vector2 contentOffset { get; set; }
        public float fixedHeight { get; set; }
        public float fixedWidth { get; set; }
        public GUIStyleState focused { get; set; }
        public Font font { get; set; }
        public int fontSize { get; set; }
        public FontStyle fontStyle { get; set; }
        public GUIStyleState hover { get; set; }
        public ImagePosition imagePosition { get; set; }
        public bool isHeightDependantOnWidth { get { return default(bool); } }
        public float lineHeight { get { return default(float); } }
        public RectOffset margin { get; set; }
        public string name { get; set; }
        public static GUIStyle none { get { return default(GUIStyle); } }
        public GUIStyleState normal { get; set; }
        public GUIStyleState onActive { get; set; }
        public GUIStyleState onFocused { get; set; }
        public GUIStyleState onHover { get; set; }
        public GUIStyleState onNormal { get; set; }
        public RectOffset overflow { get; set; }
        public RectOffset padding { get; set; }
        public bool richText { get; set; }
        public bool stretchHeight { get; set; }
        public bool stretchWidth { get; set; }
        public bool wordWrap { get; set; }

        public float CalcHeight(GUIContent content, float width) { return default(float); }
        public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { minWidth = default(float); maxWidth = default(float); }
        public Vector2 CalcScreenSize(Vector2 contentSize) { return default(Vector2); }
        public Vector2 CalcSize(GUIContent content) { return default(Vector2); }
        [ExcludeFromDocs]
        public void Draw(Rect position, GUIContent content, int controlID) { }
        public void Draw(Rect position, GUIContent content, int controlID, bool on) { }
        public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }
        public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }
        public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }
        public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }
        public void DrawCursor(Rect position, GUIContent content, int controlID, int Character) { }
        public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter) { }
        public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { return default(Vector2); }
        public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition) { return default(int); }
        public override string ToString() { return default(string); }
    }
}