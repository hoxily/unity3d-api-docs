using System;

namespace UnityEngine
{
    public sealed class Gyroscope
    {
        public Quaternion attitude { get { return default(Quaternion); } }
        public bool enabled { get; set; }
        public Vector3 gravity { get { return default(Vector3); } }
        public Vector3 rotationRate { get { return default(Vector3); } }
        public Vector3 rotationRateUnbiased { get { return default(Vector3); } }
        public float updateInterval { get; set; }
        public Vector3 userAcceleration { get { return default(Vector3); } }
    }
}