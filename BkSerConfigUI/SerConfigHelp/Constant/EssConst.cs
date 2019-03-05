using BkSerConfigUI.SerConfigHelp.Model;
using BkSerConfigUI.SerConfigHelp.Util;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigHelp.Constant
{
    class EssConst
    {
        public static readonly List<string> OPS_NAME_COLOR = new List<string>
        {
            "none","0","1","2","3","4","5","6","7","8","9","a","b","c","d","e","f",
        };

        public static readonly List<Enchanting> ENCHANTINGS = new List<Enchanting>
        {
            new Enchanting("baneOfArthropods","截肢杀手",1,5), new Enchanting("blastProtection","爆炸保护",1,4),
            new Enchanting("efficiency","效率",1,5), new Enchanting("featherFalling","摔落保护",1,4) , 
            new Enchanting("fireAspect","火焰附加",1,2), new Enchanting("fireProtection","火焰保护",1,4) , 
            new Enchanting("flame","火矢",1,1), new Enchanting("fortune","时运",1,3) , 
            new Enchanting("infinity","无限",1,1), new Enchanting("knockback","击退",1,2) , 
            new Enchanting("looting","抢夺",1,3), new Enchanting("luckOfTheSea","海之眷顾",1,3) ,
            new Enchanting("lure","钓饵",1,3), new Enchanting("power","力量",1,5) ,
            new Enchanting("projectileProtection","弹射保护",1,4), new Enchanting("protection","保护",1,4) ,
            new Enchanting("punch","冲击",1,2), new Enchanting("respiration","水下呼吸",1,3) ,
            new Enchanting("sharpness","锋利",1,5), new Enchanting("silkTouch","精准采集",1,1) ,
            new Enchanting("smite","亡灵杀手",1,5), new Enchanting("thorns","荆棘",1,3) ,
            new Enchanting("durability","耐久",1,3), new Enchanting("digspeed","效率",1,5),
            new Enchanting("unbreaking","耐久",1,3)
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
