using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MqttServerTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //程序的样式，由工具自行生成
            Application.SetCompatibleTextRenderingDefault(false);// 属性设置
            Application.Run(new FormClient());  //跑一个新的窗口
        }
    }
}
