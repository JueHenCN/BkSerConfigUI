namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    partial class EssKitEdit
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
            this.txtKitName = new System.Windows.Forms.TextBox();
            this.nudKitDelay = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbKitDelay = new BkSerConfigUI.SerConfigTool.SerConfigLabel();
            this.lbKitName = new BkSerConfigUI.SerConfigTool.SerConfigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKitName
            // 
            this.txtKitName.Location = new System.Drawing.Point(155, 8);
            this.txtKitName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKitName.Name = "txtKitName";
            this.txtKitName.Size = new System.Drawing.Size(89, 25);
            this.txtKitName.TabIndex = 3;
            // 
            // nudKitDelay
            // 
            this.nudKitDelay.Location = new System.Drawing.Point(155, 38);
            this.nudKitDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudKitDelay.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nudKitDelay.Name = "nudKitDelay";
            this.nudKitDelay.Size = new System.Drawing.Size(91, 25);
            this.nudKitDelay.TabIndex = 175;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 36);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 28);
            this.btnCancel.TabIndex = 258;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(251, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 28);
            this.btnOK.TabIndex = 259;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbKitDelay
            // 
            this.lbKitDelay.AutoSize = true;
            this.lbKitDelay.ConfigDescription = "";
            this.lbKitDelay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbKitDelay.Location = new System.Drawing.Point(13, 40);
            this.lbKitDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKitDelay.Name = "lbKitDelay";
            this.lbKitDelay.Size = new System.Drawing.Size(133, 20);
            this.lbKitDelay.TabIndex = 174;
            this.lbKitDelay.Text = "礼包领取时间间隔:";
            // 
            // lbKitName
            // 
            this.lbKitName.AutoSize = true;
            this.lbKitName.ConfigDescription = "";
            this.lbKitName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbKitName.Location = new System.Drawing.Point(13, 9);
            this.lbKitName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKitName.Name = "lbKitName";
            this.lbKitName.Size = new System.Drawing.Size(103, 20);
            this.lbKitName.TabIndex = 173;
            this.lbKitName.Text = "赠送礼包名称:";
            // 
            // EssKitEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 71);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudKitDelay);
            this.Controls.Add(this.lbKitDelay);
            this.Controls.Add(this.lbKitName);
            this.Controls.Add(this.txtKitName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EssKitEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新手礼包编辑";
            ((System.ComponentModel.ISupportInitialize)(this.nudKitDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKitName;
        private SerConfigTool.SerConfigLabel lbKitName;
        private System.Windows.Forms.NumericUpDown nudKitDelay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private SerConfigTool.SerConfigLabel lbKitDelay;
    }
}