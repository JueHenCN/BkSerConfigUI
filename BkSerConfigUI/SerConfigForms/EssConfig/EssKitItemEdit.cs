﻿using BkSerConfigUI.SerConfigHelp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    public partial class EssKitItemEdit : Form
    {
        public KitItem Item { get; set; }
        List<Enchanting> enchantings = SerConfigHelp.Constant.EssConst.ENCHANTINGS;

        public EssKitItemEdit(KitItem kitItem = null)
        {
            InitializeComponent();
            if (null != kitItem)
            {
                Item = kitItem;
                tbId.Text = Item.ItemMetadata == 0 ? Item.ItemId.ToString() : Item.ItemId + ":" + Item.ItemMetadata;
                nudItemNumber.Value = Item.ItemNumber;
                tbItemName.Text = Item.ItemName;
                tbCustomizeRemarks.Text = Item.CustomizeRemarks;
                Item = kitItem;
                LoadNowEnchanting();
                return;
            }
            Item = new KitItem();
            foreach (var enchanting in enchantings)
                tvEnchantings.Nodes.Add(new TreeNode()
                {
                    Text = enchanting.CustomizeName,
                    Tag = enchanting
                });
            nudEnchantingLevel.Enabled = false;
        }

        private void btnItemColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog().Equals(DialogResult.Cancel))
                return;
            Item.Color = color.Color.R + ","+color.Color.B + "," + color.Color.G;
        }

        private void LoadNowEnchanting()
        {
            tvEnchantings.Nodes.Clear();
            tvNowEnchanting.Nodes.Clear();
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
                Item.ItemEnchanting.Add((Enchanting)tvEnchantings.SelectedNode.Tag);
                enchantings.Remove((Enchanting)tvEnchantings.SelectedNode.Tag);
                LoadNowEnchanting();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tvNowEnchanting.SelectedNode != null)
            {
                enchantings.Add((Enchanting)tvNowEnchanting.SelectedNode.Tag);
                Item.ItemEnchanting.Remove((Enchanting)tvNowEnchanting.SelectedNode.Tag);
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
