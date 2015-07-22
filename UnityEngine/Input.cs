using System;

namespace UnityEngine
{
    /// <summary>
    /// <para>输入系统的接口。</para>
    /// <para>使用此类读取在Input Manager中设置好的轴，以及访问移动设备上的多点触控、加速计的数据。</para>
    /// <para>要想读取某个轴，使用Input.GetAxis读取下列默认的轴：“Horizontal”和“Vertical”映射到操纵杆、AWSD以及方向键。“Mouse X”和“Mouse Y”映射到鼠标移动量。“Fire1”、“Fire2”、“Fire3”分别映射到Ctrl、Alt、Cmd键，以及三个鼠标或操纵杆的按钮。还可以在Input Manager里添加新的输入轴。</para>
    /// <para>如果你为了任何种类的移动行为而使用输入系统，那么请使用Input.GetAxis。它会给你一个平滑了的并且可配置的输入，这个输入可以映射到键盘、操纵杆和鼠标。使用Input.GetButton以应对仅有动作类的事件。不要将它用于移动，Input.GetAxis能使脚本代码量更小更简单。</para>
    /// <para>另外请注意，输入标志直到“Update()”才被重置，因此建议将所有输入调用放到Update循环里。</para>
    /// <para>iOS与Android设备能够跟踪多根手指同时触摸屏幕。你可以访问Input.touches属性数组，以访问每根手指在最后一帧期间触摸屏幕的状态的数据。</para>
    /// <para>随着设备的移动，它的加速计硬件报告在空间中沿着三个基本轴的线性加速变化量。你可以使用此数据来检测当前设备的朝向（相对地面）以及该朝向的即时变化。</para>
    /// <para>沿着各个轴的加速度是直接由硬件以重力值的方式加以报告。值1.0表示沿着该指定轴+1g的负荷，而值-1.0则表示-1g。如果你将设备面朝自己竖直地拿着（home键在底下），那么朝右就是x轴正方向，朝上就是y轴正方向，而指向你自己的方向就是z轴正方向。</para>
    /// <para>你可以读取Input.acceleration属性来获取加速计的读数。你也可以通过Input.deviceOrientation属性来获取设备在三维空间中的朝向的离散的估计。检测朝向的改变有时会很有用，当你想要创建随用户旋转设备而来的游戏行为时。</para>
    /// <para>请注意，加速计硬件可以每帧轮询多于一次。要想访问自从上一帧开始的所有加速计采样，你可以读取Input.accelerationEvents属性数组。当你重建玩家动作、拿加速度数据喂给预测器以及实现其他精细的动作分析时将会很有用。</para>
    /// </summary>
    public sealed class Input
    {
        public Input() { }

        public static Vector3 acceleration { get { return default(Vector3); } }
        public static int accelerationEventCount { get { return default(int); } }
        public static AccelerationEvent[] accelerationEvents { get { return default(AccelerationEvent[]); } }
        public static bool anyKey { get { return default(bool); } }
        public static bool anyKeyDown { get { return default(bool); } }
        public static Compass compass { get { return default(Compass); } }
        public static bool compensateSensors { get; set; }
        public static Vector2 compositionCursorPos { get; set; }
        public static string compositionString { get { return default(string); } }
        public static DeviceOrientation deviceOrientation { get { return default(DeviceOrientation); } }
        [Obsolete("eatKeyPressOnTextFieldFocus property is deprecated, and only provided to support legacy behavior.")]
        public static bool eatKeyPressOnTextFieldFocus { get; set; }
        public static Gyroscope gyro { get { return default(Gyroscope); } }
        public static IMECompositionMode imeCompositionMode { get; set; }
        public static bool imeIsSelected { get { return default(bool); } }
        public static string inputString { get { return default(string); } }
        [Obsolete("isGyroAvailable property is deprecated. Please use SystemInfo.supportsGyroscope instead.")]
        public static bool isGyroAvailable { get { return default(bool); } }
        public static LocationService location { get { return default(LocationService); } }
        public static Vector3 mousePosition { get { return default(Vector3); } }
        public static bool mousePresent { get { return default(bool); } }
        public static bool multiTouchEnabled { get; set; }
        public static bool simulateMouseWithTouches { get; set; }
        public static int touchCount { get { return default(int); } }
        public static Touch[] touches { get { return default(Touch[]); } }

        [WrapperlessIcall]
        public static AccelerationEvent GetAccelerationEvent(int index) { return default(AccelerationEvent); }
        /// <summary>
        /// <para>返回由axisName辨别的虚拟轴的值。</para>
        /// <para>对于键盘和操纵杆输入，这个值的范围是-1到1.如果轴被设置为鼠标移动变化量，那么鼠标变化量将会乘上该轴的灵敏度，因此返回值的范围不再是-1到1.</para>
        /// <para>此方法是帧率无关的。你不需要在使用此值时操心变化的帧率。</para>
        /// </summary>
        /// <param name="axisName">虚拟轴的名字</param>
        /// <returns>该轴的值。</returns>
        [WrapperlessIcall]
        public static float GetAxis(string axisName) { return default(float); }
        /// <summary>
        /// <para>返回由axisName辨别的未应用平滑过滤的虚拟轴的值。</para>
        /// <para>对于键盘和操纵杆输入，这个值的范围是-1到1.由于输入没有平滑处理，键盘输入不是-1、0就是1.这在你想自己处理所有的键盘输入平滑化时很有用。</para>
        /// </summary>
        /// <param name="axisName">虚拟轴的名字</param>
        /// <returns>该轴的值</returns>
        [WrapperlessIcall]
        public static float GetAxisRaw(string axisName) { return default(float); }
        /// <summary>
        /// <para>当由buttonName所辨别的虚拟按钮处于按下状态时返回true。</para>
        /// <para>考虑连发——它会返回true，只要该按钮处于按下状态。</para>
        /// <para>仅在实现触发动作的事件时使用此函数，例如武器射击。使用GetAxis来控制连续的运动。</para>
        /// </summary>
        /// <param name="buttonName">虚拟按钮的名字</param>
        /// <returns>该虚拟按钮是否处于按下状态</returns>
        [WrapperlessIcall]
        public static bool GetButton(string buttonName) { return default(bool); }
        /// <summary>
        /// <para>如果用户在本帧内按下了由buttonName所辨别的虚拟按钮，那么返回true。</para>
        /// <para>你需要在Update函数内调用此函数，因为每一帧都会重置输入状态。此函数不会返回true，直到用户松开按钮并再次按下。</para>
        /// <para>仅在实现动作类的事件时使用此函数，例如武器射击。对于任何种类的运动行为，使用Input.GetAxis。</para>
        /// </summary>
        /// <param name="buttonName">虚拟按钮的名字</param>
        /// <returns>用户是否在本帧内按下了由buttonName所辨别的虚拟按钮</returns>
        [WrapperlessIcall]
        public static bool GetButtonDown(string buttonName) { return default(bool); }
        /// <summary>
        /// <para>如果处于用户松开由buttonName所辨别的虚拟按钮的第一帧，那么返回true。</para>
        /// <para>你需要在Update函数内调用此函数，因为每一帧都会重置输入状态。此函数不会返回true，直到用户再一次按下按钮并松开。</para>
        /// <para>仅在实现动作类的事件时使用此函数，例如武器射击。对于任何种类的运动行为，使用Input.GetAxis。</para>
        /// </summary>
        /// <param name="buttonName">虚拟按钮的名字</param>
        /// <returns>是否处于用户松开由buttonName所辨别的虚拟按钮的第一帧</returns>
        [WrapperlessIcall]
        public static bool GetButtonUp(string buttonName) { return default(bool); }
        [WrapperlessIcall]
        public static string[] GetJoystickNames() { return default(string[]); }
        /// <summary>
        /// <para>当由参数key所辨别的按键处于被用户按下状态时返回true。考虑连发。</para>
        /// <para>当你处理输入时，建议使用Input.GetAxis和Input.GetButton代替，因为它允许终端用户配置按键。</para>
        /// </summary>
        /// <param name="key">所按下的键</param>
        /// <returns>用户是否按下该键</returns>
        public static bool GetKey(KeyCode key) { return default(bool); }
        /// <summary>
        /// <para>当由参数key所辨别的按键处于被用户按下状态时返回true。考虑连发。</para>
        /// <para>按键标识符的清单参见手册中的Input Manager章节。当你处理输入时，建议使用Input.GetAxis和Input.GetButton代替，因为它允许终端用户配置按键。</para>
        /// </summary>
        /// <param name="name">所按下的键的标识符</param>
        /// <returns>用户是否按下该键</returns>
        public static bool GetKey(string name) { return default(bool); }
        /// <summary>
        /// <para>如果用户在本帧内按下了由key所辨别的按键，那么返回true。</para>
        /// <para>你需要在Update函数内调用此函数，因为每一帧都会重置输入状态。此函数不会返回true，直到用户松开按键并再次按下。</para>
        /// <para>当你处理输入时，建议使用Input.GetAxis和Input.GetButton代替，因为它允许终端用户配置按键。</para>
        /// </summary>
        /// <param name="key">所按下的键</param>
        /// <returns>用户是否按下该键</returns>
        public static bool GetKeyDown(KeyCode key) { return default(bool); }
        /// <summary>
        /// <para>如果用户在本帧内按下了由name所辨别的按键，那么返回true。</para>
        /// <para>你需要在Update函数内调用此函数，因为每一帧都会重置输入状态。此函数不会返回true，直到用户松开按键并再次按下。</para>
        /// <para>按键标识符的清单参见手册中的Input Manager章节。当你处理输入时，建议使用Input.GetAxis和Input.GetButton代替，因为它允许终端用户配置按键。</para>
        /// </summary>
        /// <param name="name">所按下的键的标识符</param>
        /// <returns>用户是否按下该键</returns>
        public static bool GetKeyDown(string name) { return default(bool); }
        /// <summary>
        /// <para>如果用户在本帧内松开了由key所辨别的按键，那么返回true。</para>
        /// <para>你需要在Update函数内调用此函数，因为每一帧都会重置输入状态。此函数不会返回true，直到用户再次按下按键并松开。</para>
        /// <para>当你处理输入时，建议使用Input.GetAxis和Input.GetButton代替，因为它允许终端用户配置按键。</para>
        /// </summary>
        /// <param name="key">所松开的键</param>
        /// <returns>用户是否松开该键</returns>
        public static bool GetKeyUp(KeyCode key) { return default(bool); }
        /// <summary>
        /// <para>如果用户在本帧内松开了由name所辨别的按键，那么返回true。</para>
        /// <para>你需要在Update函数内调用此函数，因为每一帧都会重置输入状态。此函数不会返回true，直到用户再次按下按键并松开。</para>
        /// <para>按键标识符的清单参见手册中的Input Manager章节。当你处理输入时，建议使用Input.GetAxis和Input.GetButton代替，因为它允许终端用户配置按键。</para>
        /// </summary>
        /// <param name="name">所松开的键的标识符</param>
        /// <returns>用户是否松开该键</returns>
        public static bool GetKeyUp(string name) { return default(bool); }
        /// <summary>
        /// <para>返回指定的鼠标按钮是否被按住。</para>
        /// </summary>
        /// <param name="button">0代表左键，1代表右键，2代表中键。</param>
        /// <returns>指定的鼠标按钮是否被按住</returns>
        [WrapperlessIcall]
        public static bool GetMouseButton(int button) { return default(bool); }
        /// <summary>
        /// <para>如果用户在本帧内按下了指定的鼠标按钮，那么返回true。</para>
        /// <para>你需要在Update函数内调用此函数，因为每一帧都会重置输入状态。此函数不会返回true，直到用户松开按键并再次按下。</para>
        /// </summary>
        /// <param name="button">0代表左键，1代表右键，2代表中键。</param>
        /// <returns>是否按下指定的鼠标按钮</returns>
        [WrapperlessIcall]
        public static bool GetMouseButtonDown(int button) { return default(bool); }
        /// <summary>
        /// <para>如果用户在本帧内松开了指定的鼠标按钮，那么返回true。</para>
        /// <para>你需要在Update函数内调用此函数，因为每一帧都会重置输入状态。此函数不会返回true，直到用户再一次按下按键并松开。</para>
        /// </summary>
        /// <param name="button">0代表左键，1代表右键，2代表中键。</param>
        /// <returns>是否松开指定的鼠标按钮</returns>
        [WrapperlessIcall]
        public static bool GetMouseButtonUp(int button) { return default(bool); }
        [Obsolete("Use ps3 move API instead", true)]
        public static Vector3 GetPosition(int deviceID) { return default(Vector3); }
        [Obsolete("Use ps3 move API instead", true)]
        public static Quaternion GetRotation(int deviceID) { return default(Quaternion); }
        [WrapperlessIcall]
        public static Touch GetTouch(int index) { return default(Touch); }
        [WrapperlessIcall]
        public static void ResetInputAxes() { }
    }
}
