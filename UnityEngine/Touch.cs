using System;

namespace UnityEngine
{
    public struct Touch
    {

        public Vector2 deltaPosition { get { return default(Vector2); } }
        public float deltaTime { get { return default(float); } }
        public int fingerId { get { return default(int); } }
        public TouchPhase phase { get { return default(TouchPhase); } }
        public Vector2 position { get { return default(Vector2); } }
        public Vector2 rawPosition { get { return default(Vector2); } }
        public int tapCount { get { return default(int); } }
    }
}