namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    partial class EssKitItemEdit
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.nudItemNumber = new System.Windows.Forms.NumericUpDown();
            this.tbCustomizeRemarks = new System.Windows.Forms.TextBox();
            this.btnItemColor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbEnchantingLevel = new System.Windows.Forms.Label();
            this.nudEnchantingLevel = new System.Windows.Forms.NumericUpDown();
            this.tvNowEnchanting = new System.Windows.Forms.TreeView();
            this.tvEnchantings = new System.Windows.Forms.TreeView();
            this.lbEnchantings = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbNowEnchanting = new System.Windows.Forms.Label();
            this.lbCustomizeRemarks = new BkSerConfigUI.SerConfigTool.SerConfigLabel();
            this.lblItemColor = new BkSerConfigUI.SerConfigTool.SerConfigLabel();
            this.lbItemName = new BkSerConfigUI.SerConfigTool.SerConfigLabel();
            this.lbItemNumber = new BkSerConfigUI.SerConfigTool.SerConfigLabel();
            this.lbItemId = new BkSerConfigUI.SerConfigTool.SerConfigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnchantingLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(84, 4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(82, 25);
            this.tbId.TabIndex = 1;
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(84, 64);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(82, 25);
            this.tbItemName.TabIndex = 3;
            // 
            // nudItemNumber
            // 
            this.nudItemNumber.Location = new System.Drawing.Point(84, 34);
            this.nudItemNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudItemNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemNumber.Name = "nudItemNumber";
            this.nudItemNumber.Size = new System.Drawing.Size(82, 25);
            this.nudItemNumber.TabIndex = 4;
            this.nudItemNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbCustomizeRemarks
            // 
            this.tbCustomizeRemarks.Location = new System.Drawing.Point(84, 129);
            this.tbCustomizeRemarks.Multiline = true;
            this.tbCustomizeRemarks.Name = "tbCustomizeRemarks";
            this.tbCustomizeRemarks.Size = new System.Drawing.Size(82, 132);
            this.tbCustomizeRemarks.TabIndex = 8;
            // 
            // btnItemColor
            // 
            this.btnItemColor.Location = new System.Drawing.Point(84, 94);
            this.btnItemColor.Name = "btnItemColor";
            this.btnItemColor.Size = new System.Drawing.Size(82, 30);
            this.btnItemColor.TabIndex = 10;
            this.btnItemColor.Text = "编辑";
            this.btnItemColor.UseVisualStyleBackColor = true;
            this.btnItemColor.Click += new System.EventHandler(this.btnItemColor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbEnchantingLevel
            // 
            this.lbEnchantingLevel.AutoSize = true;
            this.lbEnchantingLevel.Location = new System.Drawing.Point(335, 47);
            this.lbEnchantingLevel.Name = "lbEnchantingLevel";
            this.lbEnchantingLevel.Size = new System.Drawing.Size(67, 15);
            this.lbEnchantingLevel.TabIndex = 24;
            this.lbEnchantingLevel.Text = "附魔等级";
            // 
            // nudEnchantingLevel
            // 
            this.nudEnchantingLevel.Location = new System.Drawing.Point(335, 69);
            this.nudEnchantingLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnchantingLevel.Name = "nudEnchantingLevel";
            this.nudEnchantingLevel.ReadOnly = true;
            this.nudEnchantingLevel.Size = new System.Drawing.Size(66, 25);
            this.nudEnchantingLevel.TabIndex = 23;
            this.nudEnchantingLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnchantingLevel.ValueChanged += new System.EventHandler(this.nudEnchantingLevel_ValueChanged);
            // 
            // tvNowEnchanting
            // 
            this.tvNowEnchanting.Location = new System.Drawing.Point(183, 30);
            this.tvNowEnchanting.Name = "tvNowEnchanting";
            this.tvNowEnchanting.Size = new System.Drawing.Size(144, 231);
            this.tvNowEnchanting.TabIndex = 22;
            this.tvNowEnchanting.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNowEnchanting_AfterSelect);
            // 
            // tvEnchantings
            // 
            this.tvEnchantings.Location = new System.Drawing.Point(407, 31);
            this.tvEnchantings.Name = "tvEnchantings";
            this.tvEnchantings.Size = new System.Drawing.Size(144, 231);
            this.tvEnchantings.TabIndex = 21;
            this.tvEnchantings.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEnchantings_AfterSelect);
            // 
            // lbEnchantings
            // 
            this.lbEnchantings.AutoSize = true;
            this.lbEnchantings.Location = new System.Drawing.Point(431, 9);
            this.lbEnchantings.Name = "lbEnchantings";
            this.lbEnchantings.Size = new System.Drawing.Size(97, 15);
            this.lbEnchantings.TabIndex = 18;
            this.lbEnchantings.Text = "原版附魔集合";
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(333, 139);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 33);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "移除=>";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(333, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 33);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "<=添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            // 
            // lbNowEnchanting
            // 
            this.lbNowEnchanting.AutoSize = true;
            this.lbNowEnchanting.Location = new System.Drawing.Point(207, 9);
            this.lbNowEnchanting.Name = "lbNowEnchanting";
            this.lbNowEnchanting.Size = new System.Drawing.Size(97, 15);
            this.lbNowEnchanting.TabIndex = 15;
            this.lbNowEnchanting.Text = "当前物品附魔";
            // 
            // lbCustomizeRemarks
            // 
            this.lbCustomizeRemarks.AutoSize = true;
            this.lbCustomizeRemarks.ConfigDescription = null;
            this.lbCustomizeRemarks.Location = new System.Drawing.Point(3, 140);
            this.lbCustomizeRemarks.Name = "lbCustomizeRemarks";
            this.lbCustomizeRemarks.Size = new System.Drawing.Size(75, 15);
            this.lbCustomizeRemarks.TabIndex = 9;
            this.lbCustomizeRemarks.Text = "物品描述:";
            // 
            // lblItemColor
            // 
            this.lblItemColor.AutoSize = true;
            this.lblItemColor.ConfigDescription = null;
            this.lblItemColor.Location = new System.Drawing.Point(3, 102);
            this.lblItemColor.Name = "lblItemColor";
            this.lblItemColor.Size = new System.Drawing.Size(75, 15);
            this.lblItemColor.TabIndex = 7;
            this.lblItemColor.Text = "物品颜色:";
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.ConfigDescription = "不输入则使用默认";
            this.lbItemName.Location = new System.Drawing.Point(3, 69);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(75, 15);
            this.lbItemName.TabIndex = 5;
            this.lbItemName.Text = "物品名称:";
            // 
            // lbItemNumber
            // 
            this.lbItemNumber.AutoSize = true;
            this.lbItemNumber.ConfigDescription = null;
            this.lbItemNumber.Location = new System.Drawing.Point(3, 39);
            this.lbItemNumber.Name = "lbItemNumber";
            this.lbItemNumber.Size = new System.Drawing.Size(75, 15);
            this.lbItemNumber.TabIndex = 2;
            this.lbItemNumber.Text = "物品数量:";
            // 
            // lbItemId
            // 
            this.lbItemId.AutoSize = true;
            this.lbItemId.ConfigDescription = null;
            this.lbItemId.Location = new System.Drawing.Point(3, 9);
            this.lbItemId.Name = "lbItemId";
            this.lbItemId.Size = new System.Drawing.Size(61, 15);
            this.lbItemId.TabIndex = 0;
            this.lbItemId.Text = "物品Id:";
            // 
            // EssKitItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 269);
            this.Controls.Add(this.lbEnchantingLevel);
            this.Controls.Add(this.nudEnchantingLevel);
            this.Controls.Add(this.tvNowEnchanting);
            this.Controls.Add(this.tvEnchantings);
            this.Controls.Add(this.lbEnchantings);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbNowEnchanting);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnItemColor);
            this.Controls.Add(this.lbCustomizeRemarks);
            this.Controls.Add(this.tbCustomizeRemarks);
            this.Controls.Add(this.lblItemColor);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.nudItemNumber);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lbItemNumber);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbItemId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EssKitItemEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物品编辑";
            ((System.ComponentModel.ISupportInitialize)(this.nudItemNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnchantingLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SerConfigTool.SerConfigLabel lbItemId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbItemName;
        private SerConfigTool.SerConfigLabel lbItemNumber;
        private System.Windows.Forms.NumericUpDown nudItemNumber;
        private SerConfigTool.SerConfigLabel lbItemName;
        private SerConfigTool.SerConfigLabel lblItemColor;
        private SerConfigTool.SerConfigLabel lbCustomizeRemarks;
        private System.Windows.Forms.TextBox tbCustomizeRemarks;
        private System.Windows.Forms.Button btnItemColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbEnchantingLevel;
        private System.Windows.Forms.NumericUpDown nudEnchantingLevel;
        private System.Windows.Forms.TreeView tvNowEnchanting;
        private System.Windows.Forms.TreeView tvEnchantings;
        private System.Windows.Forms.Label lbEnchantings;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbNowEnchanting;
    }
}