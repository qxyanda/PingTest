
namespace PingTest
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
            this.btn_start = new System.Windows.Forms.Button();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.tb_error = new System.Windows.Forms.TextBox();
            this.btn_single = new System.Windows.Forms.Button();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 47);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "默认测试";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(12, 65);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_msg.Size = new System.Drawing.Size(376, 373);
            this.tb_msg.TabIndex = 1;
            // 
            // tb_error
            // 
            this.tb_error.Location = new System.Drawing.Point(412, 65);
            this.tb_error.Multiline = true;
            this.tb_error.Name = "tb_error";
            this.tb_error.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_error.Size = new System.Drawing.Size(376, 373);
            this.tb_error.TabIndex = 2;
            // 
            // btn_single
            // 
            this.btn_single.Location = new System.Drawing.Point(412, 12);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(120, 47);
            this.btn_single.TabIndex = 3;
            this.btn_single.Text = "单独测试";
            this.btn_single.UseVisualStyleBackColor = true;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(538, 12);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(250, 25);
            this.tb_ip.TabIndex = 4;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(138, 12);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(120, 47);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "停止测试";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.btn_single);
            this.Controls.Add(this.tb_error);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "摄像头Ping测试程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.TextBox tb_error;
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Button btn_stop;
    }
}

