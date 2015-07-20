using System;

namespace UnityEngine
{
    public sealed class Compass
    {
        public Compass() { }

        public bool enabled { get; set; }
        public float headingAccuracy { get { return default(float); } }
        public float magneticHeading { get { return default(float); } }
        public Vector3 rawVector { get { return default(Vector3); } }
        public double timestamp { get { return default(double); } }
        public float trueHeading { get { return default(float); } }
    }
}
