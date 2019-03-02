using System;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    public partial class EssBuildSettingEdit : Form
    {
        public EssBuildSettingEdit(string editData)
        {
            InitializeComponent();
            tbData.Text = EditData = editData;
            if (string.IsNullOrEmpty(editData))
                cbCheck.Visible = true;
        }

        public string EditData { get; set; }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbData.Text))
                EditData = tbData.Text;
            Close();
        }

        private void cbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheck.Checked)
            {
                MessageBox.Show("批量添加请使用(英文逗号',')隔开，如果集合中已存在的项将会被覆盖!", "操作提示");
                Size = new System.Drawing.Size(220, 170);
                tbData.Multiline = true;
                tbData.Size = new System.Drawing.Size(125, 95);
            }
            else
            {
                Size = new System.Drawing.Size(220, 90);
                tbData.Multiline = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
