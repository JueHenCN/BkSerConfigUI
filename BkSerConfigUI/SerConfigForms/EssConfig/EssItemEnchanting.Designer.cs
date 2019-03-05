namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    partial class EssItemEnchanting
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
            this.lbNowEnchanting = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbEnchantings = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tvEnchantings = new System.Windows.Forms.TreeView();
            this.tvNowEnchanting = new System.Windows.Forms.TreeView();
            this.nudEnchantingLevel = new System.Windows.Forms.NumericUpDown();
            this.lbEnchantingLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnchantingLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNowEnchanting
            // 
            this.lbNowEnchanting.AutoSize = true;
            this.lbNowEnchanting.Location = new System.Drawing.Point(36, 9);
            this.lbNowEnchanting.Name = "lbNowEnchanting";
            this.lbNowEnchanting.Size = new System.Drawing.Size(97, 15);
            this.lbNowEnchanting.TabIndex = 2;
            this.lbNowEnchanting.Text = "当前物品附魔";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "<=添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(161, 122);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 33);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "移除=>";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbEnchantings
            // 
            this.lbEnchantings.AutoSize = true;
            this.lbEnchantings.Location = new System.Drawing.Point(260, 13);
            this.lbEnchantings.Name = "lbEnchantings";
            this.lbEnchantings.Size = new System.Drawing.Size(97, 15);
            this.lbEnchantings.TabIndex = 5;
            this.lbEnchantings.Text = "原版附魔集合";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(161, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 33);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tvEnchantings
            // 
            this.tvEnchantings.Location = new System.Drawing.Point(236, 31);
            this.tvEnchantings.Name = "tvEnchantings";
            this.tvEnchantings.Size = new System.Drawing.Size(144, 231);
            this.tvEnchantings.TabIndex = 8;
            this.tvEnchantings.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEnchantings_AfterSelect);
            // 
            // tvNowEnchanting
            // 
            this.tvNowEnchanting.Location = new System.Drawing.Point(12, 30);
            this.tvNowEnchanting.Name = "tvNowEnchanting";
            this.tvNowEnchanting.Size = new System.Drawing.Size(144, 231);
            this.tvNowEnchanting.TabIndex = 9;
            this.tvNowEnchanting.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNowEnchanting_AfterSelect);
            // 
            // nudEnchantingLevel
            // 
            this.nudEnchantingLevel.Enabled = false;
            this.nudEnchantingLevel.Location = new System.Drawing.Point(163, 52);
            this.nudEnchantingLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnchantingLevel.Name = "nudEnchantingLevel";
            this.nudEnchantingLevel.Size = new System.Drawing.Size(66, 25);
            this.nudEnchantingLevel.TabIndex = 10;
            this.nudEnchantingLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnchantingLevel.ValueChanged += new System.EventHandler(this.nudEnchantingLevel_ValueChanged);
            // 
            // lbEnchantingLevel
            // 
            this.lbEnchantingLevel.AutoSize = true;
            this.lbEnchantingLevel.Location = new System.Drawing.Point(163, 30);
            this.lbEnchantingLevel.Name = "lbEnchantingLevel";
            this.lbEnchantingLevel.Size = new System.Drawing.Size(67, 15);
            this.lbEnchantingLevel.TabIndex = 11;
            this.lbEnchantingLevel.Text = "附魔等级";
            // 
            // EssItemEnchanting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 273);
            this.Controls.Add(this.lbEnchantingLevel);
            this.Controls.Add(this.nudEnchantingLevel);
            this.Controls.Add(this.tvNowEnchanting);
            this.Controls.Add(this.tvEnchantings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbEnchantings);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbNowEnchanting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EssItemEnchanting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物品附魔编辑";
            ((System.ComponentModel.ISupportInitialize)(this.nudEnchantingLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNowEnchanting;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lbEnchantings;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView tvEnchantings;
        private System.Windows.Forms.TreeView tvNowEnchanting;
        private System.Windows.Forms.NumericUpDown nudEnchantingLevel;
        private System.Windows.Forms.Label lbEnchantingLevel;
    }
}