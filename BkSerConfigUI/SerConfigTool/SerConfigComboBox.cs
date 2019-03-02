using System;
using System.ComponentModel;
using System.Windows.Forms;
using BkSerConfigUI.SerConfigHelp.Constant;

namespace BkSerConfigUI.SerConfigTool
{
    public partial class SerConfigComboBox : ComboBox
    {
        public SerConfigComboBox()
        {
            InitializeComponent();
        }

        [Category("SerConfig"), Description("配置属性名称")]
        public string ConfigName { get; set; }

        protected override void OnSelectedValueChanged(EventArgs e)
        {
            base.OnSelectedValueChanged(e);
            if (EssConst.yaml == null) return;
            EssConst.yaml.Edit(ConfigName, Text);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (!string.IsNullOrEmpty(ConfigName) && Enabled)
                Text = EssConst.yaml.GetValue(ConfigName);
        }
    }
}
