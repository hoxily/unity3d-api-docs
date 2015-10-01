using System;

namespace UnityEngine
{
    /// <summary>
    /// <para>使用这些标志位来限制刚体的运动。</para>
    /// <para>参见：Rigidbody.constraints。</para>
    /// </summary>
    public enum RigidbodyConstraints
    {
        /// <summary>
        /// 无约束。
        /// </summary>
        None = 0,
        /// <summary>
        /// 冻结沿着X轴的运动。
        /// </summary>
        FreezePositionX = 2,
        /// <summary>
        /// 冻结沿着Y轴的运动。
        /// </summary>
        FreezePositionY = 4,
        /// <summary>
        /// 冻结沿着Z轴的运动。
        /// </summary>
        FreezePositionZ = 8,
        /// <summary>
        /// 冻结沿着所有轴的运动。
        /// </summary>
        FreezePosition = 14,
        /// <summary>
        /// 冻结绕着X轴的旋转。
        /// </summary>
        FreezeRotationX = 16,
        /// <summary>
        /// 冻结绕着Y轴的旋转。
        /// </summary>
        FreezeRotationY = 32,
        /// <summary>
        /// 冻结绕着Z轴的旋转。
        /// </summary>
        FreezeRotationZ = 64,
        /// <summary>
        /// 冻结绕着所有轴的旋转。
        /// </summary>
        FreezeRotation = 112,
        /// <summary>
        /// 冻结沿着所有轴的移动和绕着所有轴的旋转。
        /// </summary>
        FreezeAll = 126,
    }
}