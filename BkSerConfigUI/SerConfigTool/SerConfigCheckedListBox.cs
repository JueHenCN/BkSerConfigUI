using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigTool
{
    public partial class SerConfigCheckedListBox : CheckedListBox
    {
        public SerConfigCheckedListBox()
        {
            InitializeComponent();
        }
        
        private List<SerConfigHelp.Util.Node> Nodes { get; set; }

        public void LoadNodes(Dictionary<string, string> nodeNameList)
        {
            Nodes = new List<SerConfigHelp.Util.Node>();
            foreach (var item in nodeNameList.Keys)
                Nodes.Add(SerConfigHelp.Constant.CurrencyConst.yaml.FindNodeByKey(item, nodeNameList[item]));
            Items.Clear();
            foreach (var item in Nodes)
                Items.Add(item.Description, SerConfigHelp.Util.CurrencyUtil.ChangeBool(item.Values[0]));
        }

        protected override void OnItemCheck(ItemCheckEventArgs ice)
        {
            base.OnItemCheck(ice);
            if (SelectedIndex == -1) return;
            string b = GetItemChecked(SelectedIndex).ToString().ToLower();
            SerConfigHelp.Constant.CurrencyConst.yaml.Edit(Nodes[SelectedIndex].CompleteNodeName, 
                (!GetItemChecked(SelectedIndex)).ToString().ToLower());
        }

    }
}
