using BkSerConfigUI.SerConfigHelp.Constant;
using BkSerConfigUI.SerConfigHelp.Util;
using BkSerConfigUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigTool
{
    public partial class SerConfigButton : UserControl
    {
        public SerConfigButton()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Selectable, true); SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
            Cursor = Cursors.Hand;
            Size = new Size(50, 17);
        }

        public enum ButtonTypes
        {
            SWITCH,ENABLED
        }

        private ButtonTypes buttonTypes;

        [Browsable(true)]
        [Category("SerConfig"), Description("由于作者的部分内容的功能启用代码使用的并不是true和false,而是使用增加或删除")]
        public ButtonTypes ButtonType
        {
            get { return buttonTypes; }
            set
            {
                buttonTypes = value;
                Click += buttonTypes.Equals(ButtonTypes.SWITCH)? 
                    new EventHandler(OnMouseClick_Switch) : 
                    new EventHandler(OnMouseClick_Enabled);
            }
        }
        

        [Browsable(true)]
        [Category("SerConfig"), Description("需要开启的功能属性值")]
        public string AttributeValue { get; set; }

        private bool isSwitch;

        public bool IsSwitch
        {
            get { return isSwitch; }

            set
            {
                if(value != isSwitch)
                {
                    isSwitch = value;
                    Invalidate();
                }
            }
        }

        [Browsable(true)]
        [Category("SerConfig"), Description("配置属性名称")]
        public string ConfigName { get; set; }

        private void OnMouseClick_Switch(object sender, EventArgs e)
        {
            IsSwitch = !IsSwitch;
            CurrencyConst.yaml.Edit(ConfigName, IsSwitch.ToString().ToLowerInvariant());
        }

        private void OnMouseClick_Enabled(object sender, EventArgs e)
        {
            IsSwitch = !IsSwitch;
            List<string> configValues = CurrencyConst.yaml.GetValues(ConfigName);
            CurrencyConst.yaml.FindNodeByKey(ConfigName).NodeType = Node.NodeTypes.OBJECT;
            if (isSwitch)
                configValues.Add(AttributeValue);
            else
                configValues.Remove(AttributeValue);
            CurrencyConst.yaml.Edit(ConfigName, configValues);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            /*if(!string.IsNullOrEmpty(AttributeValue) && AttributeValue.Trim().Equals("color"))
            {
                int x = 1;
            }*/

            if (string.IsNullOrEmpty(ConfigName) || !Enabled)
                return;
            if(ButtonTypes.SWITCH.Equals(buttonTypes))
                IsSwitch = CurrencyUtil.ChangeBool(CurrencyConst.yaml.GetValue(ConfigName));
            else
                foreach(string attValue in CurrencyConst.yaml.GetValues(ConfigName))
                    if (attValue.Equals(AttributeValue))
                    {
                        IsSwitch = true;
                        break;
                    }
            
        }

        private void SerConfigSwitchButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0, 0, Size.Width, Size.Height);
            if (IsSwitch)
                g.DrawImage(Resources.on, rec);
            else
                g.DrawImage(Resources.off, rec);
        }
    }
}
