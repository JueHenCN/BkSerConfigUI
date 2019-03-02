using BkSerConfigUI.SerConfigHelp.Constant;
using BkSerConfigUI.SerConfigHelp.Util;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigTool
{
    public partial class SerConfigNumericUpDown : NumericUpDown
    {
        public SerConfigNumericUpDown()
        {
            InitializeComponent();
        }

        [Category("SerConfig"), Description("配置属性名称")]
        public string ConfigName { get; set; }

        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);
            if (EssConst.yaml == null) return;
            EssConst.yaml.Edit(ConfigName, Value.ToString());
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (!string.IsNullOrEmpty(ConfigName) && Enabled)
            {
                if (CurrencyUtil.ChangeDecimalNumber(EssConst.yaml.GetValue(ConfigName)) > Maximum)
                    Value = Maximum;
                else if (CurrencyUtil.ChangeDecimalNumber(EssConst.yaml.GetValue(ConfigName)) < Minimum)
                    Value = Minimum;
                if (DecimalPlaces == 0)
                    Value = CurrencyUtil.ChangeLongNumber(EssConst.yaml.GetValue(ConfigName));
                else
                    Value = CurrencyUtil.ChangeDecimalNumber(EssConst.yaml.GetValue(ConfigName));
            }
        }
    }
}
