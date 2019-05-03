using System;
using System.Windows.Forms;
using BkSerConfigUI.SerConfigHelp.Util;

namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    public partial class EssKitEdit : Form
    {
        public EssKitEdit(SerConfigHelp.Model.Kit kit = null)
        {
            InitializeComponent();
            if (null == kit) return;
            txtKitName.Text = kit.KitName;
            nudKitDelay.Value = kit.Delay;
            node = (Node)kit.Tag;
        }

        private Node node;

        private void btnOK_Click(object sender, EventArgs e)
        {
            Node kitNode = SerConfigHelp.Constant.CurrencyConst.yaml.FindNodeByKey("kits");
            if (string.IsNullOrWhiteSpace(txtKitName.Text))
            {
                MessageBox.Show("礼包名称不允许为空!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kitNode.ChildNodes.ContainsKey(txtKitName.Text))
            {
                MessageBox.Show("当前礼包名称已存在请重新输入!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(null == node)
            {
                node = new Node()
                {
                    Level = 1,
                };
                node.ChildNodes.Add("delay", new Node()
                {
                    Name = "delay",
                    Level = 2,
                    Values = new System.Collections.Generic.List<string>() { nudKitDelay.Value.ToString() }
                });
                node.ChildNodes.Add("items", new Node() { Name = "items", Level = 2 });
                kitNode.ChildNodes.Add(txtKitName.Text, node);
            }
            else
                node.ChildNodes["delay"].Values[0] = nudKitDelay.Value.ToString();
            node.Name = txtKitName.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
