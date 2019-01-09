namespace Cpu_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCPU = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbMemorySum = new System.Windows.Forms.ProgressBar();
            this.lblSum = new System.Windows.Forms.Label();
            this.pbMemoryUse = new System.Windows.Forms.ProgressBar();
            this.lblMuse = new System.Windows.Forms.Label();
            this.pbVmemorysum = new System.Windows.Forms.ProgressBar();
            this.pbVmemoryuse = new System.Windows.Forms.ProgressBar();
            this.lblVinfo = new System.Windows.Forms.Label();
            this.lblVuse = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssluse = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.ForeColor = System.Drawing.Color.Lime;
            this.lblCPU.Location = new System.Drawing.Point(20, 242);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(41, 12);
            this.lblCPU.TabIndex = 1;
            this.lblCPU.Text = "lblCPU";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(22, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 214);
            this.panel3.TabIndex = 2;
            // 
            // pbMemorySum
            // 
            this.pbMemorySum.ForeColor = System.Drawing.Color.Lime;
            this.pbMemorySum.Location = new System.Drawing.Point(65, 33);
            this.pbMemorySum.Name = "pbMemorySum";
            this.pbMemorySum.Size = new System.Drawing.Size(239, 23);
            this.pbMemorySum.TabIndex = 3;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(310, 44);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(41, 12);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "lblSum";
            // 
            // pbMemoryUse
            // 
            this.pbMemoryUse.ForeColor = System.Drawing.Color.Lime;
            this.pbMemoryUse.Location = new System.Drawing.Point(65, 71);
            this.pbMemoryUse.Name = "pbMemoryUse";
            this.pbMemoryUse.Size = new System.Drawing.Size(239, 23);
            this.pbMemoryUse.TabIndex = 5;
            // 
            // lblMuse
            // 
            this.lblMuse.AutoSize = true;
            this.lblMuse.Location = new System.Drawing.Point(310, 82);
            this.lblMuse.Name = "lblMuse";
            this.lblMuse.Size = new System.Drawing.Size(47, 12);
            this.lblMuse.TabIndex = 6;
            this.lblMuse.Text = "lblMuse";
            // 
            // pbVmemorysum
            // 
            this.pbVmemorysum.ForeColor = System.Drawing.Color.Lime;
            this.pbVmemorysum.Location = new System.Drawing.Point(65, 38);
            this.pbVmemorysum.Name = "pbVmemorysum";
            this.pbVmemorysum.Size = new System.Drawing.Size(239, 23);
            this.pbVmemorysum.TabIndex = 7;
            // 
            // pbVmemoryuse
            // 
            this.pbVmemoryuse.ForeColor = System.Drawing.Color.Lime;
            this.pbVmemoryuse.Location = new System.Drawing.Point(65, 79);
            this.pbVmemoryuse.Name = "pbVmemoryuse";
            this.pbVmemoryuse.Size = new System.Drawing.Size(239, 23);
            this.pbVmemoryuse.TabIndex = 8;
            // 
            // lblVinfo
            // 
            this.lblVinfo.AutoSize = true;
            this.lblVinfo.Location = new System.Drawing.Point(310, 49);
            this.lblVinfo.Name = "lblVinfo";
            this.lblVinfo.Size = new System.Drawing.Size(53, 12);
            this.lblVinfo.TabIndex = 9;
            this.lblVinfo.Text = "lblVinfo";
            // 
            // lblVuse
            // 
            this.lblVuse.AutoSize = true;
            this.lblVuse.Location = new System.Drawing.Point(310, 90);
            this.lblVuse.Name = "lblVuse";
            this.lblVuse.Size = new System.Drawing.Size(47, 12);
            this.lblVuse.TabIndex = 10;
            this.lblVuse.Text = "lblVuse";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.lblCPU);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(79, 264);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU 使用";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "总数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "可用数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "总数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "可用数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbMemorySum);
            this.groupBox2.Controls.Add(this.lblSum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pbMemoryUse);
            this.groupBox2.Controls.Add(this.lblMuse);
            this.groupBox2.Location = new System.Drawing.Point(97, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 130);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "物理内存（K）";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblVuse);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblVinfo);
            this.groupBox3.Controls.Add(this.pbVmemorysum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pbVmemoryuse);
            this.groupBox3.Location = new System.Drawing.Point(97, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 128);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "虚拟内存（K）";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNum,
            this.tssluse});
            this.statusStrip1.Location = new System.Drawing.Point(0, 283);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(472, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslNum
            // 
            this.tsslNum.Name = "tsslNum";
            this.tsslNum.Size = new System.Drawing.Size(131, 17);
            this.tsslNum.Text = "toolStripStatusLabel1";
            // 
            // tssluse
            // 
            this.tssluse.Name = "tssluse";
            this.tssluse.Size = new System.Drawing.Size(131, 17);
            this.tssluse.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 305);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CPU使用率";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar pbMemorySum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.ProgressBar pbMemoryUse;
        private System.Windows.Forms.Label lblMuse;
        private System.Windows.Forms.ProgressBar pbVmemorysum;
        private System.Windows.Forms.ProgressBar pbVmemoryuse;
        private System.Windows.Forms.Label lblVinfo;
        private System.Windows.Forms.Label lblVuse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslNum;
        private System.Windows.Forms.ToolStripStatusLabel tssluse;
    }
}

