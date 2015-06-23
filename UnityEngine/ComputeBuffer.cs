using System;
using System.Security;

namespace UnityEngine
{
    public sealed class ComputeBuffer : IDisposable
    {
        public ComputeBuffer(int count, int stride) { }
        public ComputeBuffer(int count, int stride, ComputeBufferType type) { }

        public int count { get { return default(int); } }
        public int stride { get { return default(int); } }

        public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffset) { }
        public void Dispose() { }
        [SecuritySafeCritical]
        public void GetData(Array data) { }
        public void Release() { }
        [SecuritySafeCritical]
        public void SetData(Array data) { }
    }
}