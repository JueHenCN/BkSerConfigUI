using BkSerConfigUI.SerConfigHelp.Constant;
using BkSerConfigUI.SerConfigHelp.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    public partial class EssConfigUI : Form
    {
        public EssConfigUI()
        {
            InitializeComponent();
        }

        private YamlUtil yaml;

        

        private YamlUtil Yaml
        {
            get { return yaml; }
            set
            {
                yaml = value;
                //onchange_playerlist.Paint += new PaintEventHandler(onchange_playerlist_Paint);
                //onbtchange_displayname.Paint += new PaintEventHandler(onbtchange_displayname_Paint);
                cbnewbies_kit.EnabledChanged += new System.EventHandler(this.cbnewbies_kit_EnabledChanged);
                cbOps_name_color.DataSource= CurrencyConst.OPS_NAME_COLOR;
            }
        }
        
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.CheckFileExists = file.CheckPathExists = true;
            file.Filter = "yaml文件|*.yml";
            if (file.ShowDialog().Equals(DialogResult.Cancel))
                return;
            CurrencyConst.yaml = Yaml = new YamlUtil(file.FileName);
            //plSigns.Enabled = false;
            tcConfig.Enabled = false;
            clbPhysical.LoadNodes(CurrencyConst.ESS_PHYSICAL_NOD);
            clbBiology.LoadNodes(CurrencyConst.ESS_BIOLOGY);
            clbBasics.LoadNodes(CurrencyConst.ESS_BASICS);
            lbBasicsTips.Visible = lbTips.Visible = lbBiologyTips.Visible = true;
            tcConfig.Enabled = true;
            //plSigns.Enabled = true;

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

        private void cbnewbies_kit_EnabledChanged(object sender, EventArgs e)
        {
            List<Node> nodes = new List<Node>() { new Node() { Name = "" } };
            nodes.AddRange(yaml.FindNodeByKey("kits").ChildNodes.Values);
            cbnewbies_kit.DataSource = nodes;
            cbnewbies_kit.DisplayMember = "Name";
            cbnewbies_kit.Text = yaml.GetValue("newbies.kit");
        }

        private void cbnewbies_kit_DropDownClosed(object sender, EventArgs e)
        {
            yaml.Edit("newbies.kit", cbnewbies_kit.Text.ToString());
        }

        private void btnKitSetting_Click(object sender, EventArgs e)
        {
            new EssKitSetting().ShowDialog();
            cbnewbies_kit_EnabledChanged(sender, e); 
        }

        private void onbtchange_displayname_Paint(object sender, PaintEventArgs e)
        {
            plNickName.Enabled = onbtchange_displayname.IsSwitch;
        }

        private void onchange_playerlist_Paint(object sender, PaintEventArgs e)
        {
            onadd_prefix_suffix.Enabled = lbadd_prefix_suffix.Enabled = onchange_playerlist.IsSwitch;
        }
    }
}
