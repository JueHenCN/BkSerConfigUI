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
            Dictionary<string, Node> allKits = CurrencyConst.yaml.FindNodeByKey("kits").ChildNodes;
            tvKits.Nodes.Clear();
            List<Kit> kits = new List<Kit>();
            foreach (Node node in allKits.Values)
            {
                List<CustomizeItem> kitItems = new List<CustomizeItem>();
                foreach (string itemValue in node.ChildNodes["items"].Values)
                    kitItems.Add(new CustomizeItem(itemValue));
                Kit kit = new Kit()
                {
                    KitName = node.Name,
                    Tag = node,
                    Delay = CurrencyUtil.ChangeLongNumber(node.ChildNodes["delay"].Values[0]),
                    KitItems = kitItems
                };
                kits.Add(kit);
            }

            TreeNode DocNode = new TreeNode();
            DocNode.Text = "kits";
            foreach (Kit kit in kits)
            {
                TreeNode treeNode = new TreeNode();
                foreach (CustomizeItem kitItem in kit.KitItems)
                    treeNode.Nodes.Add(new TreeNode()
                    {
                        Text = kitItem.ItemMetadata == 0 ?
                        kitItem.ItemId.ToString() :
                        kitItem.ItemId + ":" + kitItem.ItemMetadata,
                        Tag = kitItem
                    });
                treeNode.Text = kit.KitName;
                treeNode.Tag = kit;
                DocNode.Nodes.Add(treeNode);
            }
            tvKits.Nodes.Add(DocNode);
            tvKits.Nodes[0].Expand();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tvKits.SelectedNode != null)
            {
                if (tvKits.SelectedNode.Level == 1)
                {
                    EssKitItemEdit itemEdit = new EssKitItemEdit();
                    if (itemEdit.ShowDialog().Equals(DialogResult.OK))
                    {
                        ((Kit)tvKits.SelectedNode.Tag).KitItems.Add(itemEdit.Item);
                        RefreshKitItem((Kit)tvKits.SelectedNode.Tag);
                    }
                }
                else
                    new EssKitEdit().ShowDialog();
                LodaKits(sender, e);
            }
            else
            {
                MessageBox.Show("请选择礼包进行操作", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshKitItem(Kit kit)
        {
            Node node = ((Node)kit.Tag).ChildNodes["items"];
            node.Values.Clear();
            foreach (var item in kit.KitItems)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append(item.ItemId);
                if (item.ItemMetadata > 0)
                    sb.Append(":" + item.ItemMetadata);
                sb.Append(" ");
                sb.Append(item.ItemNumber);
                if (!string.IsNullOrEmpty(item.Color))
                    sb.Append(" color:" + item.Color);
                if (!string.IsNullOrEmpty(item.CustomizeName))
                    sb.Append(" name:"+item.CustomizeName);
                if (!string.IsNullOrEmpty(item.CustomizeRemarks))
                    sb.Append(" lore:" + item.CustomizeRemarks);
                foreach (var enchanting in item.ItemEnchanting)
                {
                    sb.Append(" " + enchanting.Name);
                    sb.Append(":" + enchanting.Level);
                }
                node.Values.Add(sb.ToString());
            }
        }

        private void tvKits_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            if (tvKits.SelectedNode != null)
            {
                tvKits.SelectedNode.Expand();
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
                if (tvKits.SelectedNode.Level == 2)
                {
                    EssKitItemEdit itemEdit = new EssKitItemEdit((CustomizeItem)tvKits.SelectedNode.Tag);
                    if (itemEdit.ShowDialog().Equals(DialogResult.OK))
                    {
                        tvKits.SelectedNode.Tag = itemEdit.Item;
                        CustomizeItem item = ((Kit)tvKits.SelectedNode.Parent.Tag).KitItems.Find(
                            (CustomizeItem kitItem) =>
                            kitItem.ItemId == itemEdit.Item.ItemId &&
                            kitItem.ItemMetadata == itemEdit.Item.ItemMetadata
                            );
                        item = itemEdit.Item;
                        RefreshKitItem((Kit)tvKits.SelectedNode.Parent.Tag);
                    }
                }
                else
                    new EssKitEdit((Kit)tvKits.SelectedNode.Tag).ShowDialog();
                LodaKits(sender, e);
            }
            else
            {
                MessageBox.Show("请选择礼包进行操作", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tvKits.SelectedNode != null && MessageBox.Show("是否确认删除", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information).Equals(DialogResult.OK))
            {
                if (tvKits.SelectedNode.Level == 1)
                {
                    CurrencyConst.yaml.FindNodeByKey("kits").ChildNodes.Remove(tvKits.SelectedNode.Text);
                }
                else
                {
                    Node node = CurrencyConst.yaml.FindNodeByKey("kits." + tvKits.SelectedNode.Parent.Text + ".items");
                    for (int i = 0; i < node.Values.Count; i++)
                        if (node.Values[i].Split(' ')[0].IndexOf(tvKits.SelectedNode.Text) > -1)
                        {
                            node.Values.RemoveAt(i);
                            break;
                        }
                }
                LodaKits(sender, e);
            }
            else
            {
                MessageBox.Show("请选择礼包进行操作", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
