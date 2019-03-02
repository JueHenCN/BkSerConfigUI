namespace BkSerConfigUI.SerConfigForms
{
    partial class InputBox
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
            this.tbInputBox = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnancel = new System.Windows.Forms.Button();
            this.lbInputBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInputBox
            // 
            this.tbInputBox.Location = new System.Drawing.Point(12, 32);
            this.tbInputBox.Name = "tbInputBox";
            this.tbInputBox.Size = new System.Drawing.Size(296, 21);
            this.tbInputBox.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(183, 59);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(60, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnancel
            // 
            this.btnancel.Location = new System.Drawing.Point(248, 59);
            this.btnancel.Name = "btnancel";
            this.btnancel.Size = new System.Drawing.Size(60, 23);
            this.btnancel.TabIndex = 2;
            this.btnancel.Text = "取消";
            this.btnancel.UseVisualStyleBackColor = true;
            this.btnancel.Click += new System.EventHandler(this.btnancel_Click);
            // 
            // lbInputBox
            // 
            this.lbInputBox.AutoSize = true;
            this.lbInputBox.Location = new System.Drawing.Point(12, 9);
            this.lbInputBox.Name = "lbInputBox";
            this.lbInputBox.Size = new System.Drawing.Size(41, 12);
            this.lbInputBox.TabIndex = 3;
            this.lbInputBox.Text = "label1";
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(314, 88);
            this.ControlBox = false;
            this.Controls.Add(this.lbInputBox);
            this.Controls.Add(this.btnancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbInputBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入提示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputBox;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnancel;
        private System.Windows.Forms.Label lbInputBox;
    }
}