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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressRate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.coY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.coX);
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水印坐标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // coY
            // 
            this.coY.Location = new System.Drawing.Point(295, 40);
            this.coY.Name = "coY";
            this.coY.Size = new System.Drawing.Size(164, 21);
            this.coY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // coX
            // 
            this.coX.Location = new System.Drawing.Point(68, 40);
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
            this.groupBox2.Location = new System.Drawing.Point(36, 152);
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
            this.lbSrc.Location = new System.Drawing.Point(34, 371);
            this.lbSrc.Name = "lbSrc";
            this.lbSrc.Size = new System.Drawing.Size(41, 12);
            this.lbSrc.TabIndex = 6;
            this.lbSrc.Text = "原目录";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(34, 405);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(53, 12);
            this.lbOutput.TabIndex = 7;
            this.lbOutput.Text = "输出目录";
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Location = new System.Drawing.Point(34, 439);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(53, 12);
            this.lbLog.TabIndex = 8;
            this.lbLog.Text = "操作记录";
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(95, 282);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(94, 23);
            this.btnSrc.TabIndex = 0;
            this.btnSrc.Text = "选择原目录";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(195, 282);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(104, 23);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "选择输出目录";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 562);
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
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressRate)).EndInit();
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
    }
}