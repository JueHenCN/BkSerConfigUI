using BkSerConfigUI.SerConfigHelp.Constant;
using BkSerConfigUI.SerConfigHelp.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms.ResidenceConfig
{
    public partial class ResidenceConfig : Form
    {
        public ResidenceConfig()
        {
            InitializeComponent();
        }
        private YamlUtil Yaml {
            get => Yaml; 
            set
            {
                Yaml = value;
            }
        }
        
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.CheckFileExists = file.CheckPathExists = true;
            file.Filter = "yaml文件|*.yml";
            if (file.ShowDialog().Equals(DialogResult.Cancel))
                return;
            plAllSetting.Enabled =  false;
            CurrencyConst.yaml = Yaml = new YamlUtil(file.FileName);
            plAllSetting.Enabled = true;
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (Yaml == null)
            {
                MessageBox.Show("请选择文件!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenToolStripButton_Click(sender, e);
                return;
            }
            if (Yaml.Save())
                MessageBox.Show("保存成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("保存失败", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tsMenu.Focus();
        }

        
    }
}
