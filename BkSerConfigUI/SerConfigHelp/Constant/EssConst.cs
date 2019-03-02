using BkSerConfigUI.SerConfigHelp.Util;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigHelp.Constant
{
    class EssConst
    {
        public static readonly List<string> OPS_NAME_COLOR = new List<string>()
        {
            "none","0","1","2","3","4","5","6","7","8","9","a","b","c","d","e","f",
        };

        public static YamlUtil yaml;

        public static ToolTip ttpSettings = new ToolTip()
        {
            InitialDelay = 200,
            AutoPopDelay = 20 * 1000,
            ReshowDelay = 200,
            ShowAlways = true,
            IsBalloon = true,
        };
    }
}
