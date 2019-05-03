using BkSerConfigUI.SerConfigHelp.Model;
using BkSerConfigUI.SerConfigHelp.Util;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BkSerConfigUI.SerConfigHelp.Constant
{
    class CurrencyConst
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

        public static Dictionary<string, string> ESS_BASICS = new Dictionary<string, string>
        {
            { "per-warp-permission","地标单独传送权限" },
            { "debug","显示服务器更多信息" },
            { "remove-god-on-disconnect","退出游戏后关闭上帝权限" },
            { "warn-on-smite","管理员使用闪电命令提醒玩家" },
            { "death-messages","关闭Minecraft自带死亡提示" },
            { "allow-silent-join-quit","关闭用户进入/离开游戏公屏提示" },
            { "world-teleport-permissions","关闭跨世界世界传送'/home'单独设置" },
            { "world-home-permissions","/home跨世界传送" },
            { "repair-enchanted","允许修理附魔武器" },
            { "unsafe-enchantments","允许非Minecrafg原版附魔" },
            { "register-back-in-listener","允许其他插件获取/back坐标" },
            { "non-ess-in-help","/help允许显示其他插件帮助命令" },
            { "hide-permissionless-help","/help不显示关闭查询权限的插件" },
            { "teleport-safety","传送坐标不安全，传至最近的安全坐标" },
            { "update-bed-at-daytime","允许玩家白天设置床为家" },
            { "freeze-afk-players","离开状态下玩家无敌" },
            { "disable-item-pickup-while-afk","离开状态下无法拾取物品" },
            { "cancel-afk-on-move","玩家移动会退出离开状态" },
            { "economy-log-enabled","记录玩家Ess命令交易记录" },
            { "protect.disable.build","禁止无权限玩家放置建造" },
            { "protect.disable.warn-on-build-disallow","提示无权限放置建造" },
            { "protect.disable.use","禁止无权限玩家使用物品" },
            { "respawn-at-home","玩家死亡后重生在家而不是出生点" }
        };

        public static Dictionary<string, string> ESS_BIOLOGY = new Dictionary<string, string>
        {
            {"protect.prevent.spawn.creeper","爬行者/苦力怕" },
            {"protect.prevent.spawn.skeleton","普通骷髅" },
            {"protect.prevent.spawn.spider","普通蜘蛛" },
            {"protect.prevent.spawn.cave_spider","洞穴/毒蜘蛛" },
            {"protect.prevent.spawn.zombie","普通僵尸" },
            {"protect.prevent.spawn.giant","巨型僵尸" },
            {"protect.prevent.spawn.pig_zombie","猪人僵尸" },
            {"protect.prevent.spawn.slime","普通史莱姆" },
            {"protect.prevent.spawn.magma_cube","岩浆/地狱史莱姆" },
            {"protect.prevent.spawn.ghast","恶魂" },
            {"protect.prevent.spawn.enderman","末影人" },
            {"protect.prevent.spawn.ender_dragon","末影龙" },
            {"protect.prevent.spawn.silverfish","囊虫" },
            {"protect.prevent.spawn.blaze","烈焰人" },
            {"protect.prevent.spawn.wither","凋零" },
            {"protect.prevent.spawn.bat","蝙蝠" },
            {"protect.prevent.spawn.witch","女巫" },
            {"protect.prevent.spawn.iron_golem","铁傀儡" },
            {"protect.prevent.spawn.villager","村民" },
            {"protect.prevent.spawn.snowman","雪人" },
            {"protect.prevent.spawn.ocelot","豹猫" },
            {"protect.prevent.spawn.squid","乌贼" },
            {"protect.prevent.spawn.mushroom_cow","哞菇/蘑菇牛" },
            {"protect.prevent.spawn.cow","牛" },
            {"protect.prevent.spawn.pig","猪" },
            {"protect.prevent.spawn.sheep","羊" },
            {"protect.prevent.spawn.chicken","鸡" },
            {"protect.prevent.spawn.wolf","狼" },
            {"protect.prevent.spawn.horse","马" }
        };

        public static Dictionary<string, string> ESS_PHYSICAL_NOD = new Dictionary<string, string>
        {
            { "protect.prevent.lava-flow", "岩浆流动"},
            { "protect.prevent.water-flow","水流动"},
            { "protect.prevent.water-bucket-flow","水桶水的流动"},
            { "protect.prevent.fire-spread","火传播"},
            { "protect.prevent.lava-fire-spread","岩浆火传播" },
            { "protect.prevent.flint-fire","打火石火传播" },
            { "protect.prevent.lightning-fire-spread","闪电火传播" },
            { "protect.prevent.portal-creation","创建传送门" },
            { "protect.prevent.tnt-explosion","TNT爆炸" },
            { "protect.prevent.tnt-playerdamage","TNT爆炸对玩家产生伤害" },
            { "protect.prevent.tnt-minecart-explosion","TNT矿车爆炸" },
            { "protect.prevent.tnt-minecart-playerdamage","矿车爆炸产生伤害" },
            { "protect.prevent.fireball-explosion","恶魂火球爆炸" },
            { "protect.prevent.fireball-fire","火球燃烧" },
            { "protect.prevent.fireball-playerdamage","火球对玩家产生伤害" },
            { "protect.prevent.witherskull-explosion","凋零攻击产生爆炸" },
            { "protect.prevent.witherskull-playerdamage","凋零对玩家产生伤害" },
            { "protect.prevent.wither-spawnexplosion","凋零生成时爆炸" },
            { "protect.prevent.wither-blockreplace","凋零破坏方块" },
            { "protect.prevent.creeper-explosion","爬行者爆炸" },
            { "protect.prevent.creeper-playerdamage","爬行者产生伤害" },
            { "protect.prevent.creeper-blockdamage","爬行者毁灭方块" },
            { "protect.prevent.enderdragon-blockdamage","末影龙破坏方块" },
            { "protect.prevent.enderman-pickup","末影人捡方块" },
            { "protect.prevent.villager-death","村民可以杀死" },
            { "protect.prevent.entitytarget","怪物不跟随玩家" },
            { "protect.disable.fall","掉落伤害" },
            { "protect.disable.pvp","PVP伤害" },
            { "protect.disable.drown","溺水伤害" },
            { "protect.disable.suffocate","窒息伤害" },
            { "protect.disable.lavadmg","岩浆伤害" },
            { "protect.disable.projectiles","弓箭伤害" },
            { "protect.disable.contactdmg","仙人掌伤害" },
            { "protect.disable.firedmg","火焰伤害" },
            { "protect.disable.lightning","雷电伤害" },
            { "protect.disable.wither","凋零效果伤害" },
            { "protect.disable.weather.storm","雨/雪天气生成" },
            { "protect.disable.weather.thunder","雷雨天气生成" },
            { "protect.disable.weather.lightning","闪电生成" }
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
