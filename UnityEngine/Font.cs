using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    public sealed class Font : Object
    {
        public Font() { }
        public Font(string name) { }

        public CharacterInfo[] characterInfo { get; set; }
        public bool dynamic { get { return default(bool); } }
        public string[] fontNames { get; set; }
        public Material material { get; set; }
        public Font.FontTextureRebuildCallback textureRebuildCallback { get; set; }

        [ExcludeFromDocs]
        public bool GetCharacterInfo(char ch, out CharacterInfo info) { info = default(CharacterInfo); return default(bool); }
        [ExcludeFromDocs]
        public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { info = default(CharacterInfo); return default(bool); }
        public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { info = default(CharacterInfo); return default(bool); }
        public static int GetMaxVertsForString(string str) { return default(int); }
        public bool HasCharacter(char c) { return default(bool); }
        [ExcludeFromDocs]
        public void RequestCharactersInTexture(string characters) { }
        [ExcludeFromDocs]
        public void RequestCharactersInTexture(string characters, int size) { }
        public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

        public delegate void FontTextureRebuildCallback();
    }
}
