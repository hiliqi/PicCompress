using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PicCompress
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Control.CheckForIllegalCrossThreadCalls = false;

            var key = File.ReadAllText("key.ini");
            if( key == Util.GetKey())
            {
                Application.Run(new Main());
            } 
            else
            {
                if (setUseTime())
                {
                    Application.Run(new Main());
                }
                else
                {
                    var init = new Init();
                    init.ShowDialog();
                    if (init.DialogResult == DialogResult.OK)
                    {
                        Application.Run(new Main());
                    }
                }
            }          
        }

        private static bool setUseTime()
        {
            RegistryKey RootKey, RegKey;
            //项名为：HKEY_CURRENT_USER/Software
            RootKey = Registry.CurrentUser.OpenSubKey("Software", true);

            //打开子项：HKEY_CURRENT_USER/Software/MyRegDataApp
            if ((RegKey = RootKey.OpenSubKey("MyRegDataApp", true)) == null)
            {
                RootKey.CreateSubKey("MyRegDataApp");//不存在，则创建子项
                RegKey = RootKey.OpenSubKey("MyRegDataApp", true);
                RegKey.SetValue("UseTime", (object)2);    //创建键值，存储可使用次数
                MessageBox.Show("您可以免费使用本软件3次！", "感谢您首次使用");
                return true;
            }

            try
            {
                object usetime = RegKey.GetValue("UseTime");//读取键值，可使用次数
                MessageBox.Show("你还可以使用本软件 :" + usetime.ToString() + "次！", "确认", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int newtime = Int32.Parse(usetime.ToString()) - 1;

                if (newtime < 0)
                {
                    MessageBox.Show("继续使用，请联系QQ2354687725购买本软件！", "提示");
                    return false;
                }
                else
                {
                    RegKey.SetValue("UseTime", (object)newtime);//更新键值，可使用次数减1
                    return true;
                }
            }
            catch
            {
                RegKey.SetValue("UseTime", (object)3);    //创建键值，存储可使用次数
                MessageBox.Show("您可以免费使用本软件3次！", "感谢您首次使用");
                return true;
            }
        }
    }
}
