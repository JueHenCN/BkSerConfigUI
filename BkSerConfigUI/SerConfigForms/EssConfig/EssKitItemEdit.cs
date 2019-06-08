using BkSerConfigUI.SerConfigHelp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    public partial class EssKitItemEdit : Form
    {
        public CustomizeItem Item { get; set; }
        List<Enchanting> enchantings = SerConfigHelp.Constant.CurrencyConst.ENCHANTINGS;

        public EssKitItemEdit(CustomizeItem kitItem = null)
        {
            InitializeComponent();
            if (null != kitItem)
            {
                tbId.Enabled = false;
                Item = kitItem;
                tbId.Text = Item.ItemMetadata == 0 ? Item.ItemId.ToString() : Item.ItemId + ":" + Item.ItemMetadata;
                nudItemNumber.Value = Item.ItemNumber;
                tbItemName.Text = Item.ItemName;
                tbCustomizeRemarks.Text = Item.CustomizeRemarks;
                Item = kitItem;
                LoadEnchanting();
                return;
            }
            Item = new CustomizeItem();
            foreach (var enchanting in enchantings)
                tvEnchantings.Nodes.Add(new TreeNode()
                {
                    Text = enchanting.CustomizeName,
                    Tag = enchanting
                });
        }

        private void btnItemColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog().Equals(DialogResult.Cancel))
                return;
            Item.Color = color.Color.R + ","+color.Color.B + "," + color.Color.G;
        }

        private void LoadEnchanting()
        {
            tvEnchantings.Nodes.Clear();
            tvNowEnchanting.Nodes.Clear();
            if (Item.ItemEnchanting.Count == 0)
                btnDel.Enabled = false;
            if (enchantings.Count == 0)
                btnAdd.Enabled = false;
            foreach (var item in Item.ItemEnchanting)
            {
                enchantings.RemoveAll((Enchanting en) => en.CustomizeName.Equals(item.CustomizeName));
                tvNowEnchanting.Nodes.Add(new TreeNode()
                {
                    Text = item.CustomizeName,
                    Tag = item
                });
            }
            foreach (var enchanting in enchantings)
                tvEnchantings.Nodes.Add(new TreeNode()
                {
                    Text = enchanting.CustomizeName,
                    Tag = enchanting
                });
            if (btnAdd.Enabled)
                tvEnchantings.Focus();
            else
                tvNowEnchanting.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tvEnchantings.SelectedNode != null)
            {
                Item.ItemEnchanting.Add((Enchanting)tvEnchantings.SelectedNode.Tag);
                enchantings.Remove((Enchanting)tvEnchantings.SelectedNode.Tag);
                LoadEnchanting();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tvNowEnchanting.SelectedNode != null)
            {
                enchantings.Add((Enchanting)tvNowEnchanting.SelectedNode.Tag);
                Item.ItemEnchanting.Remove((Enchanting)tvNowEnchanting.SelectedNode.Tag);
                LoadEnchanting();
            }
        }

        private void nudEnchantingLevel_ValueChanged(object sender, EventArgs e)
        {
            if (tvNowEnchanting.SelectedNode != null)
                ((Enchanting)tvNowEnchanting.SelectedNode.Tag).Level = (int)nudEnchantingLevel.Value;
            if (tvEnchantings.SelectedNode != null)
                ((Enchanting)tvEnchantings.SelectedNode.Tag).Level = (int)nudEnchantingLevel.Value;
        }

        private void tvNowEnchanting_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnAdd.Enabled = false;
            btnDel.Enabled = true;
            nudEnchantingLevel.Maximum = ((Enchanting)tvNowEnchanting.SelectedNode.Tag).MaxLevel;
            nudEnchantingLevel.Value = ((Enchanting)tvNowEnchanting.SelectedNode.Tag).Level;
        }

        private void tvEnchantings_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnAdd.Enabled = true;
            btnDel.Enabled = false;
            nudEnchantingLevel.Maximum = ((Enchanting)tvEnchantings.SelectedNode.Tag).MaxLevel;
            nudEnchantingLevel.Value = ((Enchanting)tvEnchantings.SelectedNode.Tag).Level;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("物品ID不允许为空");
                return;
            }
            if (tbId.Enabled)
            {
                string[] id = tbId.Text.Split(':');
                Item.ItemId = (int)SerConfigHelp.Util.CurrencyUtil.ChangeLongNumber(id[0]);
                Item.ItemMetadata = id.Length > 1 ? (int)SerConfigHelp.Util.CurrencyUtil.ChangeLongNumber(tbId.Text.Split(':')[1]) : 0;
            }
            Item.ItemNumber = (int)nudItemNumber.Value;
            Item.CustomizeName = tbItemName.Text;
            Item.CustomizeRemarks = tbCustomizeRemarks.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            SerConfigHelp.Constant.CurrencyConst.ttpSettings.SetToolTip(btnAdd, "添加附魔属性时注意,并不是所有物品都可以附魔,在附魔前请查询该物品是否允许附魔需要附魔的属性");
        }
        
    }
}
