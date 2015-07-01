using System;
using UnityEngine.Internal;

namespace UnityEngine
{
    /// <summary>
    /// 字体资源的脚本接口。
    /// <para>你可以通过使用此类来动态地切换GUI文本或者文本网格的字体。</para>
    /// <para>参见：<see cref="GUIText"/>和<seealso cref="TextMesh"/></para>
    /// </summary>
    public sealed class Font : Object
    {
        /// <summary>
        /// 创建一个新字体。
        /// <para>如果你需要以编程的方式创建Font对象并通过赋值Font.characterInfo属性来设定你自己的字体，那么你也许想要使用此构造方法。</para>
        /// </summary>
        public Font() { }
        /// <summary>
        /// 创建一个新字体。
        /// <para>如果你需要以编程的方式创建Font对象并通过赋值Font.characterInfo属性来设定你自己的字体，那么你也许想要使用此构造方法。</para>
        /// </summary>
        /// <param name="name">所创建的Font对象的名字</param>
        public Font(string name) { }
        /// <summary>
        /// 访问字体纹理中那个包含所有字符的数组。
        /// </summary>
        public CharacterInfo[] characterInfo { get; set; }
        /// <summary>
        /// 该字体是否是动态字体。
        /// </summary>
        public bool dynamic { get { return default(bool); } }
        public string[] fontNames { get; set; }
        /// <summary>
        /// 用于字体显示的材质。
        /// </summary>
        public Material material { get; set; }
        public Font.FontTextureRebuildCallback textureRebuildCallback { get; set; }

        [ExcludeFromDocs]
        public bool GetCharacterInfo(char ch, out CharacterInfo info) { info = default(CharacterInfo); return default(bool); }
        [ExcludeFromDocs]
        public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { info = default(CharacterInfo); return default(bool); }
        /// <summary>
        /// 获取指定字符的渲染信息。
        /// <para>请注意：只有当你想自己实现文本渲染时才有必要使用此方法。如果拥有指定的size大小并且指定的样式style并且指定的字符ch在字体纹理中存在，那么此方法会返回true，并且info将会包此字符的纹理布局信息。如果此字符不存在，那么此方法返回false。如果size为0，那么将会使用默认的大小。</para>
        /// <para>参见：characterInfo. 例子在 RequestCharactersInTexture.</para>
        /// </summary>
        /// <param name="ch">你所需要的渲染信息的字符</param>
        /// <param name="info">如果可用，返回含有用于渲染该字符的信息的CharacterInfo结构。</param>
        /// <param name="size">字符的大小（默认值0将会导致使用字体的默认大小）</param>
        /// <param name="style">该字符的样式</param>
        /// <returns></returns>
        public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { info = default(CharacterInfo); return default(bool); }
        public static int GetMaxVertsForString(string str) { return default(int); }
        /// <summary>
        /// 该字体是否含有指定的字符。
        /// </summary>
        /// <param name="c">查询的字符</param>
        /// <returns>是否含有</returns>
        public bool HasCharacter(char c) { return default(bool); }
        [ExcludeFromDocs]
        public void RequestCharactersInTexture(string characters) { }
        [ExcludeFromDocs]
        public void RequestCharactersInTexture(string characters, int size) { }
        public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

        public delegate void FontTextureRebuildCallback();
    }
}
