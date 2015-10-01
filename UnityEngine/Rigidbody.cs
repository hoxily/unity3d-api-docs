using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    /// <summary>
    /// <para>通过物理模拟来控制物体的位置。</para>
    /// <para>给物体添加 Rigidbody 组件，将会使它的运动受到 Unity 的物理引擎的控制。即使不添加任何代码，一个 Rigidbody 物体也会被重力向下拉扯，并且对与即将靠近的物体的碰撞作出反应，如果正确的放置了 Collider 组件的话。</para>
    /// <para>Rigidbody 也有脚本接口，能够让你对物体施加力，以物理地真实的方式控制它。举例来说，一辆车的行为可以由轮子施加的力所决定。给定这些信息，物理引擎可以处理汽车运动的大部分方面，所以它会真实地加速并能正确地对碰撞作出反应。</para>
    /// <para>在脚本里面，建议 FixedUpdate 作为施加力和改变 Rigidbody 设置的地方（与 Update 相反，Update 用于大部分的帧更新任务）。这样做的原因是，物理更新是以精确测量的步调执行的，与帧更新不一样。在每次物理更新之前，FixedUpdate 会被立即调用，因此在 FixedUpdate 里做的任何改变将会被立即处理。</para>
    /// <para>刚刚开始使用 Rigidbody 遇到的常见问题就是，游戏物理看起来似乎以“慢动作”方式运转。这实际上是因为你的模型的缩放比例不对。默认的重力设置假定，一个世界单位对应于一米距离。对于非物理的游戏，如果你的模型都是100个单位长度并没有什么不同，但是如果使用物理引擎，这些模型将会被当作非常巨大的物体。如果在一个应该是小的物体上使用大的缩放比例，那么这个物体将会看起来坠落得非常缓慢——物理引擎认为它们是非常巨大的物体在非常长的距离上坠落。牢记这一点，确保让你的物体大约正好是现实生活中的缩放比例（因此一辆汽车应该是大约4个单位，等于4米，比如说。）。</para>
    /// </summary>
    public sealed class Rigidbody : Component
    {
        public Rigidbody() { }
        /// <summary>
        /// <para>物体的角阻力。</para>
        /// <para>角阻力用于使物体的旋转慢下来。角阻力越大，旋转变慢得越快。</para>
        /// </summary>
        public float angularDrag { get; set; }
        /// <summary>
        /// <para>刚体的角速度</para>
        /// <para>大部分情况下你不应该直接修改此属性，因为这会导致不真实的行为。</para>
        /// </summary>
        public Vector3 angularVelocity { get; set; }
        /// <summary>
        /// <para>相对于 transform 的原点的质量中心。</para>
        /// <para>如果你不在脚本里设置质量中心，那么它将会根据所有附加到刚体上的碰撞器自动地计算出来。设置质量中心通常是在模拟汽车时让汽车更稳定的时候很有用。一辆拥有较低的质量中心的汽车不太可能翻车。</para>
        /// <para>注意：centerOfMass 是相对于 transform 的位置和旋转的，但是不会影响 transform 的缩放。</para>
        /// </summary>
        public Vector3 centerOfMass { get; set; }
        /// <summary>
        /// <para>Rigidbody 的碰撞检测模式。</para>
        /// <para>设置 Rigidbody 的碰撞检测模式为连续碰撞检测，可以防止快速移动的物体穿透其他物体而未检测出碰撞。想要最好的效果，为高速移动的物体设置此属性成 CollisionDetectionMode.ContinuousDynamic，为预计相碰撞的其他物体设置 CollisionDetectionMode.Continuous。此属性对物理引擎性能具有重大影响，因此如果你没有遇到高速移动物体碰撞出问题，那么就设置成默认值，CollisionDetectionMode.Discrete。连续碰撞检测仅仅支持 SphereCollider、CapsuleCollider以及BoxCollider 碰撞器的刚体。参见：CollisionDetectionMode。</para>
        /// </summary>
        public CollisionDetectionMode collisionDetectionMode { get; set; }
        /// <summary>
        /// <para>控制此刚体模拟的自由度。</para>
        /// <para>默认是 RigidbodyConstraints.None，允许沿着所有轴的旋转和平移。在某些情况下，你可能想要约束刚体仅沿着某些轴做旋转和平移，比如开发 2D 游戏的时候。你可以使用按位或运算符来组合多个约束。</para>
        /// <para>注意，约束是作用于刚体的局部座标系。</para>
        /// </summary>
        public RigidbodyConstraints constraints { get; set; }
        /// <summary>
        /// <para>是否开启碰撞检测？（默认总是开启。）</para>
        /// <para>当你有一个设置成运动学的布娃娃，并且你想要避免此刚体的过多的碰撞检测计算的时候，关闭碰撞检测是很有有用的。detectCollisions 不会被序列化。这意味着它不会显示在 Inspector 上，当实例化一个刚体或者保存场景中的刚体时此属性不会被保存。</para>
        /// </summary>
        public bool detectCollisions { get; set; }
        /// <summary>
        /// <para>物体的阻力。</para>
        /// <para>阻力用于使物体慢下来。阻力越大，物体越快得停下来。</para>
        /// </summary>
        public float drag { get; set; }
        /// <summary>
        /// <para>控制物理引擎是否会改变物体的旋转。</para>
        /// <para>如果 freezeRotation 被启用，那么物理模拟不会改变旋转。对于第一人称射击游戏，这很有用。因为玩家需要使用鼠标完全掌控旋转。参见：Rigidbody.constraints。</para>
        /// </summary>
        public bool freezeRotation { get; set; }
        /// <summary>
        /// <para>相对于质量中心的斜对角惯性张量。</para>
        /// <para>惯性张量依据 intertiaTensorRotation 旋转。如果你没有在脚本里面设置惯性张量，那么它会自动根据所有的附加到刚体上的碰撞器计算出来。</para>
        /// </summary>
        public Vector3 inertiaTensor { get; set; }
        /// <summary>
        /// <para>惯性张量的旋转。</para>
        /// <para>如果你没有在脚本里面设置惯性张量的旋转，那么它会自动根据所有的附加到刚体上的碰撞器计算出来。</para>
        /// </summary>
        public Quaternion inertiaTensorRotation { get; set; }
        /// <summary>
        /// <para>插值允许你以固定帧率平滑运行物理引擎的效果</para>
        /// <para>插值默认是关闭的。一般地，刚体插值用在玩家角色上。物理引擎以离散的时间步数运行，而图像是以变动的帧率进行渲染。这可能导致抖动的物体，因为物理引擎与图像没有完全同步。影响是微妙的，但是在玩家角色上通常可以看出来，特别是如果一个摄像机跟随着主角。建议为主角打开插值，而对别的任何东西关闭插值。</para>
        /// </summary>
        public RigidbodyInterpolation interpolation { get; set; }
        /// <summary>
        /// <para>控制物理是否影响刚体。</para>
        /// <para>如果 isKinematic 启用，那么力、碰撞、关节将不再影响刚体。刚体将会完全受动画或者脚本的 transform.position 所控制。通过碰撞和关节，运动学的身体同样可以影响其他刚体的运动。例如，用关节将一个运动学刚体与常规的刚体相连，那么此常规刚体将会受到运动学刚体的运动的约束。运动学刚体也非常适用于那种通常被动画驱动，而在特定事件下通过设置 isKinematic 为 false 转变成一个布娃娃的角色。</para>
        /// </summary>
        public bool isKinematic { get; set; }
        /// <summary>
        /// <para>刚体的质量。</para>
        /// <para>你应该努力保持质量靠近 0.1，并且绝对不要超过 10.大的质量会导致物理模拟不稳定。</para>
        /// <para>发生碰撞时，较大质量的物体推动较小质量的物体更多。设想一辆大卡车撞到了一辆小汽车。</para>
        /// <para>一个常见的错误就是假设重的物体比轻的物体下落的更快。这是不正确的，因为下落速度与重力和阻力有关。</para>
        /// </summary>
        public float mass { get; set; }
        /// <summary>
        /// <para>刚体的最大角速度。（默认是7.） 有效范围：0 到无穷大。</para>
        /// <para>刚体的角速度被限制到 maxAngularVelocity 以避免高速旋转的刚体数值不稳定。因为此属性可能会阻止本该高速旋转的物体，比如车轮，你可以逐个刚体覆盖此默认值。</para>
        /// </summary>
        public float maxAngularVelocity { get; set; }
        /// <summary>
        /// <para>当离开贯穿状态时，刚体的最大速度。</para>
        /// <para>当你想要让你的刚体比默认的更平滑地离开碰撞状态，使用此属性。</para>
        /// </summary>
        public float maxDepenetrationVelocity { get; set; }
        /// <summary>
        /// <para>刚体的位置。</para>
        /// <para>Rigidbody.position 允许你读取和写入一个正使用着物理引擎的刚体的位置。如果你通过 Rigidbody.position 改变了刚体的位置，transform 将会在下一次物理模拟步骤时更新。这比利用 Transform.position 更新位置要快，因为后者会引起所有附加的碰撞器重新计算它们相对于刚体的位置。</para>
        /// <para>如果你想要连续地移动一个刚体，请使用 MovePosition 代替。 MovePosition 考虑到了插值。</para>
        /// </summary>
        public Vector3 position { get; set; }
        public Quaternion rotation { get; set; }
        [Obsolete("The sleepAngularVelocity is no longer supported. Set Use sleepThreshold to specify energy.")]
        public float sleepAngularVelocity { get; set; }
        public float sleepThreshold { get; set; }
        [Obsolete("The sleepVelocity is no longer supported. Use sleepThreshold. Note that sleepThreshold is energy but not velocity.")]
        public float sleepVelocity { get; set; }
        public int solverIterationCount { get; set; }
        public bool useConeFriction { get; set; }
        public bool useGravity { get; set; }
        public Vector3 velocity { get; set; }
        public Vector3 worldCenterOfMass { get { return default(Vector3); } }

        [ExcludeFromDocs]
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius) { }
        [ExcludeFromDocs]
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }
        public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddForce(Vector3 force) { }
        public void AddForce(Vector3 force, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddForce(float x, float y, float z) { }
        public void AddForce(float x, float y, float z, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddForceAtPosition(Vector3 force, Vector3 position) { }
        public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddRelativeForce(Vector3 force) { }
        public void AddRelativeForce(Vector3 force, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddRelativeForce(float x, float y, float z) { }
        public void AddRelativeForce(float x, float y, float z, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddRelativeTorque(Vector3 torque) { }
        public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddRelativeTorque(float x, float y, float z) { }
        public void AddRelativeTorque(float x, float y, float z, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddTorque(Vector3 torque) { }
        public void AddTorque(Vector3 torque, ForceMode mode) { }
        [ExcludeFromDocs]
        public void AddTorque(float x, float y, float z) { }
        public void AddTorque(float x, float y, float z, ForceMode mode) { }
        public Vector3 ClosestPointOnBounds(Vector3 position) { return default(Vector3); }
        public Vector3 GetPointVelocity(Vector3 worldPoint) { return default(Vector3); }
        public Vector3 GetRelativePointVelocity(Vector3 relativePoint) { return default(Vector3); }
        public bool IsSleeping() { return default(bool); }
        public void MovePosition(Vector3 position) { }
        public void MoveRotation(Quaternion rot) { }
        public void SetDensity(float density) { }
        [Obsolete("use Rigidbody.maxAngularVelocity instead.")]
        public void SetMaxAngularVelocity(float a) { }
        public void Sleep() { }
        [ExcludeFromDocs]
        public bool SweepTest(Vector3 direction, out RaycastHit hitInfo) { hitInfo = default(RaycastHit); return default(bool); }
        public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance) { hitInfo = default(RaycastHit); return default(bool); }
        [ExcludeFromDocs]
        public RaycastHit[] SweepTestAll(Vector3 direction) { return default(RaycastHit[]); }
        public RaycastHit[] SweepTestAll(Vector3 direction, float maxDistance) { return default(RaycastHit[]); }
        public void WakeUp() { }
    }
}