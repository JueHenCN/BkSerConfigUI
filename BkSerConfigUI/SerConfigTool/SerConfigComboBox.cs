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
            if (CurrencyConst.yaml == null) return;
            CurrencyConst.yaml.Edit(ConfigName, Text);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (!string.IsNullOrEmpty(ConfigName) && Enabled)
                Text = CurrencyConst.yaml.GetValue(ConfigName);
        }
    }
}
