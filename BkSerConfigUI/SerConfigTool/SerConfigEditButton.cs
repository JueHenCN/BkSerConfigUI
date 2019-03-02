using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigTool
{
    public partial class SerConfigEditButton : Button
    {
        public SerConfigEditButton()
        {
            InitializeComponent();
        }

        [Category("SerConfig"), Description("输入框提示内容")]
        public string Prompt { get; set; }

        [Category("SerConfig"), Description("配置属性名称")]
        public string ConfigName { get; set; }

        [Category("SerConfig"), Description("默认值")]
        public string DefaultValue { get; set; }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            new SerConfigForms.InputBox(ConfigName, Prompt, DefaultValue).ShowDialog();
        }
    }
}
