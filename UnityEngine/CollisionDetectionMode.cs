using System;

namespace UnityEngine
{
    /// <summary>
    /// 用于 Rigidbody.collisionDetectionMode 的碰撞检测模式枚举。
    /// </summary>
    public enum CollisionDetectionMode
    {
        /// <summary>
        /// <para>关闭此刚体的连续碰撞检测。</para>
        /// <para>这是默认的碰撞检测模式，这是最快的模式。此碰撞器的碰撞仅在内容的 Time.fixedDeltaTime 检测。</para>
        /// </summary>
        Discrete = 0,
        /// <summary>
        /// <para>为静态网格几何体打开连续碰撞检测。</para>
        /// <para>此 Rigidbody 的路径上的任何静态网格几何体的碰撞都会被检测到，即使碰撞发生在两个 FixedUpdate 步骤之间。静态网格几何体是指任何没有附加 Rigidbody 的 MeshCollider。这也阻止了设置了 ContinuousDynamic 模式的刚体们穿过此刚体。</para>
        /// </summary>
        Continuous = 1,
        /// <summary>
        /// <para>为静态和动态的几何体打开连续碰撞检测。</para>
        /// <para>当刚体移动得很快时，阻止此刚体穿过静态网格几何体以及其他设置了连续碰撞检测的刚体。这是速度最慢的碰撞检测模式，理应仅在挑选出来的快速移动物体上使用。</para>
        /// </summary>
        ContinuousDynamic = 2,
    }
}