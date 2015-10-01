using System;

namespace UnityEngine
{
    public class Collider : Component
    {
        public Collider() { }

        public Rigidbody attachedRigidbody { get { return default(Rigidbody); } }
        public Bounds bounds { get { return default(Bounds); } }
        public float contactOffset { get; set; }
        public bool enabled { get; set; }
        public bool isTrigger { get; set; }
        public PhysicMaterial material { get; set; }
        public PhysicMaterial sharedMaterial { get; set; }

        public Vector3 ClosestPointOnBounds(Vector3 position) { return default(Vector3); }
        public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { hitInfo = default(RaycastHit); return default(bool); }
    }
}