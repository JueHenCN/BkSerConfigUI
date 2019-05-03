using BkSerConfigUI.SerConfigHelp.Constant;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms
{
    public partial class InputBox : Form
    {
        string ConfigName { get; set; }

        string DefaultValue { get; set; }

        public InputBox(string configName,string prompt = "", string defaultValue = "")
        {
            InitializeComponent();
            ConfigName = configName;
            tbInputBox.Text = CurrencyConst.yaml.GetValue(configName);
            lbInputBox.Text = prompt;
            if(lbInputBox.Size.Width > tbInputBox.Size.Width)
                tbInputBox.Size = new System.Drawing.Size(lbInputBox.Size.Width,tbInputBox.Size.Height);
        }

        private void btnancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbInputBox.Text))
                tbInputBox.Text = DefaultValue;
            CurrencyConst.yaml.Edit(ConfigName, tbInputBox.Text);
            Close();
        }
    }
}
