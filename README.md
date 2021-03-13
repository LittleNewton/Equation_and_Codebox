# 关于本插件

![软件效果](img/效果图.jpg)

GitHub 链接：https://github.com/LittleNewton/Equation_and_Codebox

这是一个 Word VSTO 插件，用来进行以下操作：

- 插入带编号的公式
- 插入代码表格

需要有以下支持：

- Iosevka 字体 (必须，该字体是默认字体)
- 安装 Latin Modern Mono 10 字体
- 安装 Latin Modern Math 字体 (必须)
- Office 2013 及之后的更新的版本

## 1. 编译方法

本插件基于 Visual Studio 2019 开发。

用 Visual Studio 2019 打开 `src/Equation and Code.sln` 即可对本项目进行更改、编译。

使用 VSTO Word 开发 SDK，需要用 Visual Studio Installer 获取相应 SDK。

## 2. 使用方法

详细使用方法，请参考哔哩哔哩的[视频](https://www.bilibili.com/video/BV1f5411p7pN/)。

上述视频可能不是有关本插件的最新教程，但是可以帮助新手快速上手。

### 2.1 插入公式

在节标题的后面插入【域代码】，是公式编号的**必要条件**。

![插入公式](img/Demo_Insert_Equations.gif)

### 2.2 插入代码

插入代码，需要首先将要插入的代码的【纯文本】复制到剪贴板。

> 最后必须有个**空行**。

#### 2.2.1 插入普通代码

行号的步长默认为 1

![插入代码](img/Demo_Insert_Codes.gif)

> 比较推荐使用这个方式。该方式不会限制行的字符数，面对超长的行时，软件会自动换行。

#### 2.2.2 自主设置行号的步长

当每行代码不超过 `101` 个**半角字符**时，可以自主设置行号步长。如下图所示。

![自主设置步长](img/Demo_Set_LineNum_Step.gif)

## 3. 开源许可

本软件遵循 MIT 开源许可。
