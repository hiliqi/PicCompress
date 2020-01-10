using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicCompress
{
    public partial class Main : Form
    {
        private string source;
        private string output;
        private string filePath;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbLog.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(source))
            {
                lbLog.ForeColor = Color.Red;
                lbLog.Text = "请选择原文件夹";
                return;
            }
            if (string.IsNullOrEmpty(output))
            {
                lbLog.ForeColor = Color.Red;
                lbLog.Text = "请选择输出文件夹";
                return;
            }
            Task.Factory.StartNew(() =>
            {
                var srcInfo = new DirectoryInfo(source);
                var outputInfo = new DirectoryInfo(output);
                CompressFilesRecursively(srcInfo, outputInfo);
            });
        }

        private void CompressFilesRecursively(DirectoryInfo srcInfo, DirectoryInfo outputInfo)
        {
            foreach (var dir in srcInfo.GetDirectories())
            {
                CompressFilesRecursively(dir, outputInfo.CreateSubdirectory(dir.Name));
                Console.WriteLine("创建目录" + dir.Name);
            }
            foreach (var file in srcInfo.GetFiles())
            {
                ApplyWaterMark(file.FullName, outputInfo.FullName);
                lbLog.Text = "正在修改" + file.Name;
            }
            lbLog.ForeColor = Color.Red;
            lbLog.Text = "完成";
            source = string.Empty;
            output = string.Empty;
        }
   
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            foreach (ImageCodecInfo imageCodecInfo in ImageCodecInfo.GetImageDecoders())
            {
                if (imageCodecInfo.FormatID == format.Guid)
                {
                    return imageCodecInfo;
                }
            }
            return null;
        }

        private void ApplyWaterMark(string file, string dir)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(file);
                string name = fileInfo.Name;
                Image image = Image.FromFile(file);
                int num = ((int)compressRate.Value == 0) ? 1 : ((int)compressRate.Value);
                Bitmap bitmap = new Bitmap(image, image.Width / num, image.Height / num);
                Graphics graphics = Graphics.FromImage(bitmap);
                Brush brush = new SolidBrush(Color.FromArgb(1, Color.LightSteelBlue));
                Font font = new Font(FontFamily.GenericSerif, 1f);
                int x = (int)coX.Value;
                int y = (int)coY.Value;
                graphics.DrawString(".", font, brush, new Point(x, y));
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
                EncoderParameters encoderParameters = new EncoderParameters(1);
                decimal value = quality.Value;
                EncoderParameter encoderParameter = new EncoderParameter(encoder, (long)value);
                encoderParameters.Param[0] = encoderParameter;
                ImageCodecInfo encoder2 = GetEncoder(ImageFormat.Jpeg);
                bitmap.Save(Path.Combine(dir, name.Replace(fileInfo.Extension, ".jpg")), encoder2, encoderParameters);
                image.Dispose();
                bitmap.Dispose();
                graphics.Dispose();
                brush.Dispose();
            }
            catch (Exception ex)
            {
                File.AppendAllText("error.txt", dir + "," + ex.Message + Environment.NewLine);
            }
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择图片所在文件夹";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                {
                    lbLog.Text = "文件夹路径不能为空";
                    return;
                }
                lbSrc.Text = folderBrowserDialog.SelectedPath;
                source = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择输出文件夹";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                {
                    lbLog.Text = "文件夹路径不能为空";
                    return;
                }
                lbOutput.Text = folderBrowserDialog.SelectedPath;
                output = folderBrowserDialog.SelectedPath;
            }
        }
      
    }
}
