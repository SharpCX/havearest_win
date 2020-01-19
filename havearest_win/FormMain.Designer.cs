namespace havearest_win
{
    partial class FormMain
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
            this.lab_release = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.timer_release = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_release
            // 
            this.lab_release.AutoSize = true;
            this.lab_release.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_release.ForeColor = System.Drawing.Color.Coral;
            this.lab_release.Location = new System.Drawing.Point(76, 19);
            this.lab_release.Name = "lab_release";
            this.lab_release.Size = new System.Drawing.Size(299, 124);
            this.lab_release.TabIndex = 0;
            this.lab_release.Text = "00:00";
            // 
            // txt_time
            // 
            this.txt_time.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_time.Location = new System.Drawing.Point(25, 190);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(195, 44);
            this.txt_time.TabIndex = 1;
            this.txt_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_time_KeyPress);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ok.Location = new System.Drawing.Point(301, 190);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(119, 44);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // timer_release
            // 
            this.timer_release.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(226, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min";
            // 
            // btn_pause
            // 
            this.btn_pause.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_pause.Location = new System.Drawing.Point(25, 260);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(195, 44);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "暂停";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.Location = new System.Drawing.Point(233, 260);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(187, 44);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 351);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lab_release);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "have a rest for lynn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_release;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Timer timer_release;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_start;
    }
}

