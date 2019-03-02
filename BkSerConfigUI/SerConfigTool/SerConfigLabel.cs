using BkSerConfigUI.SerConfigHelp.Constant;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigTool
{
    public partial class SerConfigLabel : Label
    {
        public SerConfigLabel()
        {
            InitializeComponent();
        }

        [Category("SerConfig"), Description("鼠标移入提示该标签对应属性的描述")]
        public string ConfigDescription { get; set; }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            EssConst.ttpSettings.SetToolTip(this, ConfigDescription);
        }
    }
}
