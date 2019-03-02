using BkSerConfigUI.SerConfigHelp.Constant;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigForms.EssConfig
{
    public partial class EssDateSetting : Form
    {
        public EssDateSetting(string configName,string formText)
        {
            InitializeComponent();
            Enabled = false;
            Enabled = true;
            this.configName = configName;
            Text = formText;
            dgvDateSource.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string value = EssConst.yaml.GetValue(configName);
            if(!string.IsNullOrEmpty(value))
                dataSource = new List<string>(value.Split(','));
            ReloadData();
        }

        public string configName;

        private List<string> dataSource = new List<string>();

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            EssBuildSettingEdit essBuildEdit = new EssBuildSettingEdit("");
            essBuildEdit.ShowDialog();
            if (string.IsNullOrEmpty(essBuildEdit.EditData))
                return;
            dataSource.AddRange(essBuildEdit.EditData.Split(','));
            dataSource = dataSource.Distinct().ToList();
            EditData();
            ReloadData();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            EssBuildSettingEdit essBuildEdit = new EssBuildSettingEdit(dgvDateSource.SelectedRows[0].Cells[0].Value.ToString());
            essBuildEdit.ShowDialog();
            if (string.IsNullOrEmpty(essBuildEdit.EditData))
                return;
            if (dataSource.Exists(p => p == essBuildEdit.EditData))
            {
                MessageBox.Show("修改失败,该数据在集合中已存在!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < dataSource.Count; i++)
                if (dataSource[i].Equals(dgvDateSource.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    dataSource[i] = essBuildEdit.EditData;
                    break;
                }
            EditData();
            ReloadData();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            dataSource.Remove(dgvDateSource.SelectedRows[0].Cells[0].Value.ToString());
            EditData();
            ReloadData();
        }

        private void ReloadData()
        {
            dataSource.Sort();
            dgvDateSource.Rows.Clear();
            foreach (string val in dataSource)
                dgvDateSource.Rows.Add(val);
        }

        private bool EditData()
        {
            string value = "";
            for (int i = 0; i < dataSource.Count - 1; i++)
                value += dataSource[i] + ",";
            if(dataSource.Count > 0)
                value += dataSource[dataSource.Count - 1];
            return EssConst.yaml.Edit(configName, value);
        }
        
        private void dgvDateSource_ButtonEnabled(object sender, System.EventArgs e)
        {
            if (dgvDateSource.Rows.Count > 0 && dgvDateSource.SelectedRows.Count > 0)
                btnEdit.Enabled = btnDelete.Enabled = true;
            else
                btnEdit.Enabled = btnDelete.Enabled = false;
        }
    }
}
