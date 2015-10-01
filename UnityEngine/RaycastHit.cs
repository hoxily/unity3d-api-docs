using System;

namespace UnityEngine
{
    public struct RaycastHit
    {

        public Vector3 barycentricCoordinate { get; set; }
        public Collider collider { get { return default(Collider); } }
        public float distance { get; set; }
        public Vector2 lightmapCoord { get { return default(Vector2); } }
        public Vector3 normal { get; set; }
        public Vector3 point { get; set; }
        public Rigidbody rigidbody { get { return default(Rigidbody); } }
        public Vector2 textureCoord { get { return default(Vector2); } }
        [Obsolete("Use textureCoord2 instead")]
        public Vector2 textureCoord1 { get { return default(Vector2); } }
        public Vector2 textureCoord2 { get { return default(Vector2); } }
        public Transform transform { get { return default(Transform); } }
        public int triangleIndex { get { return default(int); } }
    }
}