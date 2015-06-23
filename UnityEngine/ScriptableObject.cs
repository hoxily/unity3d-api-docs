using System;

namespace UnityEngine
{
    public class ScriptableObject : Object
    {
        public ScriptableObject() { }

        public static T CreateInstance<T>() where T : ScriptableObject { return default(T); }
        public static ScriptableObject CreateInstance(string className) { return default(ScriptableObject); }
        public static ScriptableObject CreateInstance(Type type) { return default(ScriptableObject); }
        [Obsolete("Use EditorUtility.SetDirty instead")]
        public void SetDirty() { }
    }
}