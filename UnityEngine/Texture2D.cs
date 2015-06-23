using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    public sealed class Texture2D : Texture
    {
        public Texture2D(int width, int height) { }
        public Texture2D(int width, int height, TextureFormat format, bool mipmap) { }
        public Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear) { }

        public bool alphaIsTransparency { get; set; }
        public TextureFormat format { get { return default(TextureFormat); } }
        public int mipmapCount { get { return default(int); } }

        [ExcludeFromDocs]
        public void Apply() { }
        [ExcludeFromDocs]
        public void Apply(bool updateMipmaps) { }
        public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }
        public void Compress(bool highQuality) { }
        public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex) { return default(Texture2D); }
        public byte[] EncodeToJPG() { return default(byte[]); }
        public byte[] EncodeToPNG() { return default(byte[]); }
        public Color GetPixel(int x, int y) { return default(Color); }
        public Color GetPixelBilinear(float u, float v) { return default(Color); }
        [ExcludeFromDocs]
        public Color[] GetPixels() { return default(Color[]); }
        public Color[] GetPixels(int miplevel) { return default(Color[]); }
        [ExcludeFromDocs]
        public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { return default(Color[]); }
        public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { return default(Color[]); }
        [ExcludeFromDocs]
        public Color32[] GetPixels32() { return default(Color32[]); }
        public Color32[] GetPixels32(int miplevel) { return default(Color32[]); }
        public bool LoadImage(byte[] data) { return default(bool); }
        public void LoadRawTextureData(byte[] data) { }
        [ExcludeFromDocs]
        public Rect[] PackTextures(Texture2D[] textures, int padding) { return default(Rect[]); }
        [ExcludeFromDocs]
        public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { return default(Rect[]); }
        public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { return default(Rect[]); }
        [ExcludeFromDocs]
        public void ReadPixels(Rect source, int destX, int destY) { }
        public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }
        public bool Resize(int width, int height) { return default(bool); }
        public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { return default(bool); }
        public void SetPixel(int x, int y, Color color) { }
        [ExcludeFromDocs]
        public void SetPixels(Color[] colors) { }
        public void SetPixels(Color[] colors, int miplevel) { }
        [ExcludeFromDocs]
        public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }
        public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }
        [ExcludeFromDocs]
        public void SetPixels32(Color32[] colors) { }
        public void SetPixels32(Color32[] colors, int miplevel) { }
        public void UpdateExternalTexture(IntPtr nativeTex) { }
    }
}