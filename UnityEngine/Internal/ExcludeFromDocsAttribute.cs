using System;

namespace UnityEngine.Internal
{
    /// <summary>
    /// 从文档中排除的属性
    /// </summary>
    [Serializable]
    [AttributeUsage(AttributeTargets.Method)]
    public class ExcludeFromDocsAttribute : Attribute
    {
        /// <summary>
        /// 新实例
        /// </summary>
        public ExcludeFromDocsAttribute() { }
    }
}
