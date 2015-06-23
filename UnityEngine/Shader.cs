using System;

namespace UnityEngine
{
    public sealed class Shader : Object
    {
        public Shader() { }

        public static int globalMaximumLOD { get; set; }
        public bool isSupported { get { return default(bool); } }
        public int maximumLOD { get; set; }
        public int renderQueue { get { return default(int); } }

        public static void DisableKeyword(string keyword) { }
        public static void EnableKeyword(string keyword) { }
        public static Shader Find(string name) { return default(Shader); }
        public static int PropertyToID(string name) { return default(int); }
        public static void SetGlobalBuffer(string propertyName, ComputeBuffer buffer) { }
        public static void SetGlobalColor(int nameID, Color color) { }
        public static void SetGlobalColor(string propertyName, Color color) { }
        public static void SetGlobalFloat(int nameID, float value) { }
        public static void SetGlobalFloat(string propertyName, float value) { }
        public static void SetGlobalInt(int nameID, int value) { }
        public static void SetGlobalInt(string propertyName, int value) { }
        public static void SetGlobalMatrix(int nameID, Matrix4x4 mat) { }
        public static void SetGlobalMatrix(string propertyName, Matrix4x4 mat) { }
        public static void SetGlobalTexGenMode(string propertyName, TexGenMode mode) { }
        public static void SetGlobalTexture(int nameID, Texture tex) { }
        public static void SetGlobalTexture(string propertyName, Texture tex) { }
        public static void SetGlobalTextureMatrixName(string propertyName, string matrixName) { }
        public static void SetGlobalVector(int nameID, Vector4 vec) { }
        public static void SetGlobalVector(string propertyName, Vector4 vec) { }
        public static void WarmupAllShaders() { }
    }
}