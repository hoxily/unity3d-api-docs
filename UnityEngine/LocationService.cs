using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    public sealed class LocationService
    {
        public LocationService() { }

        public bool isEnabledByUser { get { return default(bool); } }
        public LocationInfo lastData { get { return default(LocationInfo); } }
        public LocationServiceStatus status { get { return default(LocationServiceStatus); } }

        [ExcludeFromDocs]
        public void Start() { }
        [ExcludeFromDocs]
        public void Start(float desiredAccuracyInMeters) { }
        public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters) { }
        public void Stop() { }
    }
}