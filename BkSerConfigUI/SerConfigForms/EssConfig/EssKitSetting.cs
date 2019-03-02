using BkSerConfigUI.SerConfigHelp.Constant;
using BkSerConfigUI.SerConfigHelp.Model;
using BkSerConfigUI.SerConfigHelp.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    public partial class EssKitSetting : Form
    {
        public EssKitSetting()
        {
            InitializeComponent();
        }

        private void LodaKits(object sender, EventArgs e)
        {
            Dictionary<string, Node> allKits = EssConst.yaml.FindNodeByKey("kits").ChildNodes;
            tvKits.Nodes.Clear();
            List<Kit> kits = new List<Kit>();
            foreach (Node node in allKits.Values)
            {
                List<KitItme> kitItmes = new List<KitItme>();
                foreach (string itemValue in node.ChildNodes["items"].Values)
                    kitItmes.Add(new KitItme(itemValue));
                Kit kit = new Kit()
                {
                    KitName = node.Name,
                    Tag = node,
                    Delay = CurrencyUtil.ChangeLongNumber(node.ChildNodes["delay"].Values[0]),
                    KitItems = kitItmes
                };
                kits.Add(kit);
            }

            TreeNode DocNode = new TreeNode();
            DocNode.Text = "kits";
            foreach (Kit kit in kits)
            {
                TreeNode treeNode = new TreeNode();
                foreach (KitItme kitItme in kit.KitItems)
                    treeNode.Nodes.Add(new TreeNode() { Text = kitItme.ItemId + ":" + kitItme.ItemMetadata });
                treeNode.Text = kit.KitName;
                treeNode.Tag = kit;
                DocNode.Nodes.Add(treeNode);
            }
            tvKits.Nodes.Add(DocNode);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tvKits.SelectedNode != null)
            {
                if (tvKits.SelectedNode.Level == 0)
                {
                    new EssKitEdit().ShowDialog();
                }
                else
                {

                }

                LodaKits(sender, e);
            }
        }

        private void tvKits_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            if (tvKits.SelectedNode != null)
            {
                btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
                switch (tvKits.SelectedNode.Level)
                {
                    case 0:
                        btnEdit.Enabled = btnDelete.Enabled = false;
                        btnAdd.Text = "添加礼包";
                        break;
                    case 1:
                        btnAdd.Text = "添加物品";
                        btnEdit.Text = "编辑礼包";
                        btnDelete.Text = "删除礼包";
                        break;
                    case 2:
                        btnAdd.Enabled = false;
                        btnEdit.Text = "编辑物品";
                        btnDelete.Text = "删除物品";
                        break;
                }
            } 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tvKits.SelectedNode != null)
            {
                if (tvKits.SelectedNode.Level == 1)
                {
                    new EssKitEdit((Kit)tvKits.SelectedNode.Tag).ShowDialog();
                }
                else
                {
                }
                LodaKits(sender, e);
            }
        }
    }
}
