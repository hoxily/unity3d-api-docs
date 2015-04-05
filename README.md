# unity3d-api-docs

C# XML Documentation Project for UnityEngine.dll and other libraries.

针对UnityEngine.dll等Unity3d标准库的 C# 版 XML 文档注释工程。

因为这工程量太大，所以目前是接触到、学到某一块时，抽取出这一块的文档注释来。

欢迎大家的加入！

## 使用方法
执行生成解决方案，将会在bin\Debug或者bin\Release目录成生成UnityEngine.xml等xml文件，将这些xml文件放置于Unity3d安装目录的Editor\Data\Managed目录下，即可实现在Visual Studio、MonoDevelop编写代码时，出现代码提示，提示脚本开发人员。

例如：
    D:\Program Files\Unity\Editor\Data\Managed

## 效果展示

UnityEngine.Debug类的提示：

![UnityEngine.Debug类的提示](http://img.blog.csdn.net/20150330141742083)

UnityEngine.Vector3类的提示：

![UnityEngine.Vector3类的提示](http://img.blog.csdn.net/20150330141923889)

UnityEngine.Vector3的构造函数的提示：

![UnityEngine.Vector3的构造函数的提示](http://img.blog.csdn.net/20150330142007990)

UnityEngine.Vector3的构造函数的各个参数的提示：

![UnityEngine.Vector3的构造函数的各个参数的提示](http://img.blog.csdn.net/20150330142056319)

## 代码规范

因为不需要实现UnityEngine这个库，而只是想仿照UnityEngine的命名空间、类名组织结构，生成一个对应的XML文档注释输出文件，用于代码智能提示。
所以工程中类的方法实现相当于是个傀儡（dummy, fake）。但是如果改成abstract则又改变了类的属性，与原始类库中的类不相匹配。因此制定此代码规范。

访问修饰符、命名空间、Attribute、方法原型（签名）等参考自Visual Studio对UnityEngine.dll等库的反编译（从元数据）。

### 返回类型为 void 的方法

方法体为空，什么也不做，具体写法为：
    { }

### 返回类型不为 void 的方法

方法体返回该值类型的默认值，具体的写法为：

    { return default(returntype); }
