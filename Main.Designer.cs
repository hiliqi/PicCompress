namespace PicCompress
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWaterMark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.coX = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quality = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.compressRate = new System.Windows.Forms.NumericUpDown();
            this.lbSrc = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.Label();
            this.btnSrc = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWaterImg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.opacity = new System.Windows.Forms.NumericUpDown();
            this.fontColor = new System.Windows.Forms.ListBox();
            this.lable11 = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.NumericUpDown();
            this.lbWaterMark = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scale);
            this.groupBox1.Controls.Add(this.lable11);
            this.groupBox1.Controls.Add(this.fontColor);
            this.groupBox1.Controls.Add(this.opacity);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.fontSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnWaterImg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtWaterMark);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.coY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.coX);
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水印设置";
            // 
            // txtWaterMark
            // 
            this.txtWaterMark.Location = new System.Drawing.Point(91, 111);
            this.txtWaterMark.Name = "txtWaterMark";
            this.txtWaterMark.Size = new System.Drawing.Size(376, 21);
            this.txtWaterMark.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "水印文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "水印坐标Y";
            // 
            // coY
            // 
            this.coY.Location = new System.Drawing.Point(91, 72);
            this.coY.Name = "coY";
            this.coY.Size = new System.Drawing.Size(164, 21);
            this.coY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "水印坐标X";
            // 
            // coX
            // 
            this.coX.Location = new System.Drawing.Point(91, 33);
            this.coX.Name = "coX";
            this.coX.Size = new System.Drawing.Size(164, 21);
            this.coX.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.quality);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.compressRate);
            this.groupBox2.Location = new System.Drawing.Point(609, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "缩放设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "图片质量";
            // 
            // quality
            // 
            this.quality.Location = new System.Drawing.Point(329, 44);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(92, 21);
            this.quality.TabIndex = 5;
            this.quality.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "缩放倍数";
            // 
            // compressRate
            // 
            this.compressRate.Location = new System.Drawing.Point(140, 44);
            this.compressRate.Name = "compressRate";
            this.compressRate.Size = new System.Drawing.Size(92, 21);
            this.compressRate.TabIndex = 3;
            // 
            // lbSrc
            // 
            this.lbSrc.AutoSize = true;
            this.lbSrc.Location = new System.Drawing.Point(607, 289);
            this.lbSrc.Name = "lbSrc";
            this.lbSrc.Size = new System.Drawing.Size(41, 12);
            this.lbSrc.TabIndex = 6;
            this.lbSrc.Text = "原目录";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(607, 323);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(53, 12);
            this.lbOutput.TabIndex = 7;
            this.lbOutput.Text = "输出目录";
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Location = new System.Drawing.Point(607, 357);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(53, 12);
            this.lbLog.TabIndex = 8;
            this.lbLog.Text = "操作记录";
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(668, 153);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(94, 23);
            this.btnSrc.TabIndex = 0;
            this.btnSrc.Text = "选择原目录";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(768, 153);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(104, 23);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "选择输出目录";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(972, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "水印图片";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnWaterImg
            // 
            this.btnWaterImg.Location = new System.Drawing.Point(91, 377);
            this.btnWaterImg.Name = "btnWaterImg";
            this.btnWaterImg.Size = new System.Drawing.Size(91, 23);
            this.btnWaterImg.TabIndex = 8;
            this.btnWaterImg.Text = "选择水印图片";
            this.btnWaterImg.UseVisualStyleBackColor = true;
            this.btnWaterImg.Click += new System.EventHandler(this.btnWaterImg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "文字大小";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(91, 150);
            this.fontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(164, 21);
            this.fontSize.TabIndex = 10;
            this.fontSize.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "文字颜色";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "水印透明度";
            // 
            // opacity
            // 
            this.opacity.Location = new System.Drawing.Point(91, 338);
            this.opacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.opacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(164, 21);
            this.opacity.TabIndex = 18;
            this.opacity.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // fontColor
            // 
            this.fontColor.FormattingEnabled = true;
            this.fontColor.ItemHeight = 12;
            this.fontColor.Items.AddRange(new object[] {
            "红色",
            "白色",
            "黑色"});
            this.fontColor.Location = new System.Drawing.Point(91, 195);
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(120, 88);
            this.fontColor.TabIndex = 19;
            // 
            // lable11
            // 
            this.lable11.AutoSize = true;
            this.lable11.Location = new System.Drawing.Point(39, 301);
            this.lable11.Name = "lable11";
            this.lable11.Size = new System.Drawing.Size(41, 12);
            this.lable11.TabIndex = 20;
            this.lable11.Text = "放大率";
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(91, 299);
            this.scale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(164, 21);
            this.scale.TabIndex = 21;
            this.scale.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lbWaterMark
            // 
            this.lbWaterMark.AutoSize = true;
            this.lbWaterMark.Location = new System.Drawing.Point(607, 253);
            this.lbWaterMark.Name = "lbWaterMark";
            this.lbWaterMark.Size = new System.Drawing.Size(53, 12);
            this.lbWaterMark.TabIndex = 9;
            this.lbWaterMark.Text = "水印图片";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 781);
            this.Controls.Add(this.lbWaterMark);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btnSrc);
            this.Controls.Add(this.lbSrc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超级图片压缩带水印功能";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown coY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown coX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown compressRate;
        private System.Windows.Forms.Label lbSrc;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtWaterMark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWaterImg;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown opacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox fontColor;
        private System.Windows.Forms.NumericUpDown scale;
        private System.Windows.Forms.Label lable11;
        private System.Windows.Forms.Label lbWaterMark;
    }
}