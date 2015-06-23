using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    public class Material : Object
    {
        public Material(Material source) { }
        public Material(Shader shader) { }
        public Material(string contents) { }

        public Color color { get; set; }
        public Texture mainTexture { get; set; }
        public Vector2 mainTextureOffset { get; set; }
        public Vector2 mainTextureScale { get; set; }
        public int passCount { get { return default(int); } }
        public int renderQueue { get; set; }
        public Shader shader { get; set; }
        public string[] shaderKeywords { get; set; }

        public void CopyPropertiesFromMaterial(Material mat) { }
        [Obsolete("Use the Material constructor instead.")]
        public static Material Create(string scriptContents) { return default(Material); }
        public void DisableKeyword(string keyword) { }
        public void EnableKeyword(string keyword) { }
        public Color GetColor(int nameID) { return default(Color); }
        public Color GetColor(string propertyName) { return default(Color); }
        public float GetFloat(int nameID) { return default(float); }
        public float GetFloat(string propertyName) { return default(float); }
        public int GetInt(int nameID) { return default(int); }
        public int GetInt(string propertyName) { return default(int); }
        public Matrix4x4 GetMatrix(int nameID) { return default(Matrix4x4); }
        public Matrix4x4 GetMatrix(string propertyName) { return default(Matrix4x4); }
        [ExcludeFromDocs]
        public string GetTag(string tag, bool searchFallbacks) { return default(string); }
        public string GetTag(string tag, bool searchFallbacks, string defaultValue) { return default(string); }
        public Texture GetTexture(int nameID) { return default(Texture); }
        public Texture GetTexture(string propertyName) { return default(Texture); }
        public Vector2 GetTextureOffset(string propertyName) { return default(Vector2); }
        public Vector2 GetTextureScale(string propertyName) { return default(Vector2); }
        public Vector4 GetVector(int nameID) { return default(Vector4); }
        public Vector4 GetVector(string propertyName) { return default(Vector4); }
        public bool HasProperty(int nameID) { return default(bool); }
        public bool HasProperty(string propertyName) { return default(bool); }
        public void Lerp(Material start, Material end, float t) { }
        public void SetBuffer(string propertyName, ComputeBuffer buffer) { }
        public void SetColor(int nameID, Color color) { }
        public void SetColor(string propertyName, Color color) { }
        public void SetFloat(int nameID, float value) { }
        public void SetFloat(string propertyName, float value) { }
        public void SetInt(int nameID, int value) { }
        public void SetInt(string propertyName, int value) { }
        public void SetMatrix(int nameID, Matrix4x4 matrix) { }
        public void SetMatrix(string propertyName, Matrix4x4 matrix) { }
        public bool SetPass(int pass) { return default(bool); }
        public void SetTexture(int nameID, Texture texture) { }
        public void SetTexture(string propertyName, Texture texture) { }
        public void SetTextureOffset(string propertyName, Vector2 offset) { }
        public void SetTextureScale(string propertyName, Vector2 scale) { }
        public void SetVector(int nameID, Vector4 vector) { }
        public void SetVector(string propertyName, Vector4 vector) { }
    }
}