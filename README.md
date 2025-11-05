# MyDemoService
## 20251105
### 学习创建一个简单的Windows服务 [ref](https://zhuanlan.zhihu.com/p/651144005)
1. 打开Visual Studio, 创建一个新的项目, 选择"Windows 服务 (.NET Framework)"模板;
2. 命名项目并选择保存位置, 然后点击"创建";
3. program.cs: 包含Main方法, 是服务的入口点;
4. Service1.cs: 包含服务的主要逻辑, 继承自ServiceBase类;
5. 在Service1.cs中, 重写OnStart和OnStop等方法, 以定义服务在不同节点上的动作;
6. 在项目下创建LogConfig文件夹, 并创建log4net.config文件, 用于配置日志记录;
7. 右键"引用", 选择"管理NuGet程序包", 搜索并安装"log4net"包;
8. 在Service1.cs中, 配置log4net以使用log4net.config文件;
9. 配置Properties/AssemblyInfo.cs文件, 添加以下代码, 否则输出不了日志:
	> [assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "config", ConfigFile = "LogConfig/log4net.config", Watch = true)]
10. 在服务中获取log4net日志记录器实例, 即可记录日志;
	> private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
11. 双击"服务.cs"文件, 打开设计视图, 然后右键点击设计视图中的空白区域, 选择"属性", 设置服务的属性, 如服务名称、启动类型等;
12. 添加安装程序: 在设计视图中, 右键点击空白区域, 选择"添加安装程序", 这将创建一个新的ProjectInstaller类(在项目目录中), 用于安装和卸载服务; 
13. 在ProjectInstaller.cs中右键, 可以修改类/组件属性, 注意修改自己可找到的服务名字;
14. 直接运行项目会报错, 因为Windows服务不能像普通应用程序那样直接运行. 需要使用命令行工具安装和启动服务;
15. 配置InstallUtil;
16. 右键项目 - 属性 - 生成, 设置打包相关内容;
17. 右键项目 - 生成, 生成exe文件在设置的目录下;
18. 找到exe文件位置, 用管理员权限打开命令提示符, 使用InstallUtil.exe安装服务:
	> InstallUtil.exe "路径\MyDemoService.exe"
	> 安装成功后, 可以在服务管理器中看到新安装的服务(注意名字);
	> 可以启动和停止服务;
	> 日志文件夹内也可以看到日志输出;
19. 用管理员权限打开命令提示符, 使用InstallUtil.exe卸载服务:
	> InstallUtil.exe /u "路径\MyDemoService.exe";
