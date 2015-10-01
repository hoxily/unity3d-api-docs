using System;

namespace UnityEngine
{
    public sealed class PhysicMaterial : Object
    {
        public PhysicMaterial() { }
        public PhysicMaterial(string name) { }

        public PhysicMaterialCombine bounceCombine { get; set; }
        public float bounciness { get; set; }
        [Obsolete("Use PhysicMaterial.bounciness instead", true)]
        public float bouncyness { get; set; }
        public float dynamicFriction { get; set; }
        public float dynamicFriction2 { get; set; }
        public PhysicMaterialCombine frictionCombine { get; set; }
        [Obsolete("use PhysicMaterial.frictionDirection2 instead.")]
        public Vector3 frictionDirection { get; set; }
        public Vector3 frictionDirection2 { get; set; }
        public float staticFriction { get; set; }
        public float staticFriction2 { get; set; }
    }
}