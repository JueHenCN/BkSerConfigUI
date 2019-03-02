using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigTool
{
    public partial class SerConfigAlertButton : Button
    {
        public SerConfigAlertButton()
        {
            InitializeComponent();
        }

        [Category("SerConfig"), Description("窗体名称")]
        public string FormText { get; set; }

        [Category("SerConfig"), Description("配置属性名称")]
        public string ConfigName { get; set; }
        
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            new SerConfigForms.EssConfig.EssDateSetting(ConfigName, FormText).ShowDialog();
        }
    }
}
