using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
    /// <summary>
    /// 异步的操作协程。
    /// <para>你可以使用yield指令直接等待异步操作完成，也可以手动检查该异步操作是否已经完成（<see cref="isDone"/>属性）或者检查它的完成进度（<see cref="progress"/>属性）。</para>
    /// </summary>
    [RequiredByNativeCode]
    public class AsyncOperation : YieldInstruction
    {
        public AsyncOperation()
        {
        }

        ~AsyncOperation()
        {
        }

        public bool isDone
        {
            get
            {
                return default(bool);
            }
        }

        public float progress
        { 
            get
            {
                return default(float); 
            }
        }

        public int priority { get; set; }

        /// <summary>
        /// 允许场景一旦准备完毕就被激活。
        /// <para>当结合LoadLevelAsync和LoadLevelAdditiveAsync一起使用时，这个属性允许你延迟激活场景。（同样的前一个场景的卸载也会被延迟）</para>
        /// <para>当<see cref="allowSceneActivation"/>置为false时，<see cref="progress"/>会停止在0.9处。<see cref="isDone"/>保持为false。当<see cref="allowSceneActivation"/>置为true时，<see cref="isDone"/>能变为true。当<see cref="isDone"/>为false时，AsyncOperation队列会停止运转。举例来说，如果LoadSceneAsync方法返回的AsyncOperation对象的allowSceneActivation属性设置为false，同时另一个AsyncOperation已经初始化完成，那么后面的异步操作在第一个异步操作的allowSceneActivation设置为true之前都不会执行。</para>
        /// </summary>
        public bool allowSceneActivation { get; set; }

        public event Action<AsyncOperation> completed;
    }
}