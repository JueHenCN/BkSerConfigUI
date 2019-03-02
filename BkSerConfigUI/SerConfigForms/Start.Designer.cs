namespace BkSerConfigUI.SerConfigForms
{
    partial class Start
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
            this.btnLoadSerConfig = new System.Windows.Forms.Button();
            this.btnScanningSerConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadSerConfig
            // 
            this.btnLoadSerConfig.Location = new System.Drawing.Point(37, 11);
            this.btnLoadSerConfig.Name = "btnLoadSerConfig";
            this.btnLoadSerConfig.Size = new System.Drawing.Size(192, 46);
            this.btnLoadSerConfig.TabIndex = 0;
            this.btnLoadSerConfig.Text = "直接选择配置文件编辑";
            this.btnLoadSerConfig.UseVisualStyleBackColor = true;
            this.btnLoadSerConfig.Click += new System.EventHandler(this.btnLoadSerConfig_Click);
            // 
            // btnScanningSerConfig
            // 
            this.btnScanningSerConfig.Enabled = false;
            this.btnScanningSerConfig.Location = new System.Drawing.Point(37, 63);
            this.btnScanningSerConfig.Name = "btnScanningSerConfig";
            this.btnScanningSerConfig.Size = new System.Drawing.Size(192, 46);
            this.btnScanningSerConfig.TabIndex = 1;
            this.btnScanningSerConfig.Text = "扫描服务器文件夹";
            this.btnScanningSerConfig.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 121);
            this.Controls.Add(this.btnScanningSerConfig);
            this.Controls.Add(this.btnLoadSerConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器配置文件编辑-0.0.3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSerConfig;
        private System.Windows.Forms.Button btnScanningSerConfig;
    }
}