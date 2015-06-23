using System;

namespace UnityEngine
{
    public class Texture : Object
    {
        public Texture() { }

        public int anisoLevel { get; set; }
        public static AnisotropicFiltering anisotropicFiltering { get; set; }
        public FilterMode filterMode { get; set; }
        public virtual int height { get; set; }
        public static int masterTextureLimit { get; set; }
        public float mipMapBias { get; set; }
        public Vector2 texelSize { get { return default(Vector2); } }
        public virtual int width { get; set; }
        public TextureWrapMode wrapMode { get; set; }

        public int GetNativeTextureID() { return default(int); }
        public IntPtr GetNativeTexturePtr() { return default(IntPtr); }
        public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }
    }
}