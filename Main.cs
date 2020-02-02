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
using Watermark;

namespace PicCompress
{
    public partial class Main : Form
    {
        private string source;
        private string output;
        private string filePath;
        private string waterImgPath;
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


        //private void ApplyWaterMark(string file, string dir)
        //{
        //    try
        //    {
        //        FileInfo fileInfo = new FileInfo(file);
        //        string name = fileInfo.Name;
        //        Image image = Image.FromFile(file);
        //        int num = ((int)compressRate.Value == 0) ? 1 : ((int)compressRate.Value);
        //        Bitmap bitmap = new Bitmap(image, image.Width / num, image.Height / num);
        //        Graphics graphics = Graphics.FromImage(bitmap);
        //        Brush brush = new SolidBrush(Color.FromArgb(1, Color.Black));
        //        Font font = new Font(FontFamily.GenericSansSerif, 28);
        //        int x = (int)coX.Value;
        //        int y = (int)coY.Value;
        //        string waterMark = txtWaterMark.Text.Trim();
        //        if (string.IsNullOrEmpty(waterMark))
        //        {
        //            waterMark = ".";
        //        }
        //        graphics.DrawString(waterMark, font, brush, new Point(x, y));
        //        if (!Directory.Exists(dir))
        //        {
        //            Directory.CreateDirectory(dir);
        //        }
        //        System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
        //        EncoderParameters encoderParameters = new EncoderParameters(1);
        //        decimal value = quality.Value;
        //        EncoderParameter encoderParameter = new EncoderParameter(encoder, (long)value);
        //        encoderParameters.Param[0] = encoderParameter;
        //        ImageCodecInfo encoder2 = GetEncoder(ImageFormat.Jpeg);
        //        bitmap.Save(Path.Combine(dir, name.Replace(fileInfo.Extension, ".jpg")), encoder2, encoderParameters);
        //        image.Dispose();
        //        bitmap.Dispose();
        //        graphics.Dispose();
        //        brush.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        File.AppendAllText("error.txt", dir + "," + ex.Message + Environment.NewLine);
        //    }
        //}

        private void ApplyWaterMark(string file, string dir)
        {
            FileInfo fileInfo = new FileInfo(file);
            string name = fileInfo.Name;
            Image image = Image.FromFile(file);
            string text = txtWaterMark.Text.Trim();
            Watermarker objWatermarker = new Watermarker(image);
            // Set the properties for the logo
            objWatermarker.Position = WatermarkPosition.Absolute;
            objWatermarker.PositionX = (int)coX.Value;
            objWatermarker.PositionY = (int)coY.Value;
            //objWatermarker.Margin = new Padding(20);
            objWatermarker.Opacity = (float)opacity.Value/10;
            objWatermarker.Font = new Font(FontFamily.GenericMonospace, (float)fontSize.Value);
            switch (fontColor.SelectedIndex)
            {
                case 0:
                    objWatermarker.FontColor = Color.DarkRed; break;
                case 1:
                    objWatermarker.FontColor = Color.White; break;
                default:
                    objWatermarker.FontColor = Color.Black; break;
            }

            objWatermarker.TransparentColor = Color.White;
            objWatermarker.ScaleRatio = (float)scale.Value;
            // Draw the logo
            if (!string.IsNullOrEmpty(waterImgPath))
            {
                objWatermarker.DrawImage(waterImgPath);
            }
            
            //Draw the Text
            if (!string.IsNullOrEmpty(text))
            {
                objWatermarker.DrawText(text);
            }


            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters encoderParameters = new EncoderParameters(1);
            decimal value = quality.Value;
            EncoderParameter encoderParameter = new EncoderParameter(encoder, (long)value);
            encoderParameters.Param[0] = encoderParameter;
            ImageCodecInfo encoder2 = GetEncoder(ImageFormat.Jpeg);
            objWatermarker.Image.Save(Path.Combine(dir, name.Replace(fileInfo.Extension, ".jpg")), encoder2, encoderParameters);
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {

                folderBrowserDialog.Description = "请选择图片所在文件夹";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                    {
                        lbLog.Text = "文件夹路径不能为空";
                        return;
                    }
                    lbSrc.Text = lbSrc.Text + folderBrowserDialog.SelectedPath;
                    source = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "请选择输出文件夹";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                    {
                        lbLog.Text = "文件夹路径不能为空";
                        return;
                    }
                    lbOutput.Text = lbOutput.Text + folderBrowserDialog.SelectedPath;
                    output = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnWaterImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "jpg文件|*.jpg|png文件|*.png|gif文件|*.gif"; //设置要选择的文件的类型
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    waterImgPath = fileDialog.FileName;//返回文件的完整路径  
                    lbWaterMark.Text = lbWaterMark.Text + waterImgPath;
                }
            }
        }
    }
}
