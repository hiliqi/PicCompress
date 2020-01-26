using RuPeng.Common.NetCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicCompress
{
    public partial class Init : Form
    {      
        public Init()
        {         
            InitializeComponent();
            richTextBox1.Text = Util.GetMachineCodeString();
        }          

        private void button1_Click(object sender, EventArgs e)
        {
            var key = richTextBox2.Text.Trim();
            if (key == Util.GetKey())
            {
                File.WriteAllText("key.ini", key);
                MessageBox.Show("授权成功！");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("授权失败！");
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
