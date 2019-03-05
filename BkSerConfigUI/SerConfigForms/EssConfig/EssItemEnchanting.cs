using BkSerConfigUI.SerConfigHelp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    public partial class EssItemEnchanting : Form
    {
        KitItem KitItem;
        List<Enchanting> enchantings = SerConfigHelp.Constant.EssConst.ENCHANTINGS;

        public EssItemEnchanting(KitItem kitItem)
        {
            InitializeComponent();
            KitItem = kitItem;
            LoadNowEnchanting();
        }

        private void LoadNowEnchanting()
        {
            tvEnchantings.Nodes.Clear();
            tvNowEnchanting.Nodes.Clear();
            foreach (var item in KitItem.ItemEnchanting)
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
            nudEnchantingLevel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tvEnchantings.SelectedNode != null)
            {
                KitItem.ItemEnchanting.Add((Enchanting)tvEnchantings.SelectedNode.Tag);
                enchantings.Remove((Enchanting)tvEnchantings.SelectedNode.Tag);
                LoadNowEnchanting();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tvNowEnchanting.SelectedNode != null)
            {
                KitItem.ItemEnchanting.Remove((Enchanting)tvEnchantings.SelectedNode.Tag);
                enchantings.Add((Enchanting)tvEnchantings.SelectedNode.Tag);
                LoadNowEnchanting();
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
            nudEnchantingLevel.Enabled = true;
            nudEnchantingLevel.Maximum = ((Enchanting)tvNowEnchanting.SelectedNode.Tag).MaxLevel;
            nudEnchantingLevel.Value = ((Enchanting)tvNowEnchanting.SelectedNode.Tag).Level;
        }

        private void tvEnchantings_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nudEnchantingLevel.Enabled = true;
            nudEnchantingLevel.Maximum = ((Enchanting)tvEnchantings.SelectedNode.Tag).MaxLevel;
            nudEnchantingLevel.Value = ((Enchanting)tvEnchantings.SelectedNode.Tag).Level;
        }
    }
}
