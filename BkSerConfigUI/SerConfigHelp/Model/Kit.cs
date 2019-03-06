using System.Collections.Generic;

namespace BkSerConfigUI.SerConfigHelp.Model
{
    /// <summary>
    /// 礼包
    /// </summary>
    public class Kit
    {
        /// <summary>
        /// 礼包名称
        /// </summary>
        public string KitName { get; set; }

        /// <summary>
        /// 领取时间间隔
        /// </summary>
        public long Delay { get; set; }

        /// <summary>
        /// 礼包类型
        /// </summary>
        public string KitType { get; set; }

        /// <summary>
        /// 礼包所对应的节点
        /// </summary>
        public object Tag { get; set; }

        /// <summary>
        /// 礼包中包含的所有物品
        /// </summary>
        public List<CustomizeItem> KitItems = new List<CustomizeItem>();
    }

    /// <summary>
    /// 物品自定义信息
    /// </summary>
    public class CustomizeItem : Item
    {
        /// <summary>
        /// 物品数量
        /// </summary>
        public int ItemNumber { get; set; }

        /// <summary>
        /// 物品自定义名称
        /// </summary>
        public string CustomizeName { get; set; }

        /// <summary>
        /// 物品自定义描述
        /// </summary>
        public string CustomizeRemarks { get; set; }

        /// <summary>
        /// 物品颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 是否为附魔书
        /// </summary>
        public bool IsEnchantingBook { get; set; }

        /// <summary>
        /// 是否为烟花
        /// </summary>
        public bool IsFireworks { get; set; }

        /// <summary>
        /// 物品附魔属性集合
        /// </summary>
        public List<Enchanting> ItemEnchanting = new List<Enchanting>();

        public CustomizeItem(){ }

        public CustomizeItem(string kitValue)
        {
            string[] kitValues = kitValue.Split(' ');
            ItemId = (int)Util.CurrencyUtil.ChangeLongNumber(kitValues[0].Split(':')[0]);
            ItemMetadata = kitValues[0].Split(':').Length > 1 ? (int)Util.CurrencyUtil.ChangeLongNumber(kitValues[0].Split(':')[1]) : 0;
            ItemNumber = (int)Util.CurrencyUtil.ChangeLongNumber(kitValues[1]);
            for (int i = 2; i < kitValues.Length; i++)
            {
                string[] kitAttribute = kitValues[i].Split(':');
                switch (kitAttribute[0])
                {
                    case "name":
                        CustomizeName = kitAttribute[1];
                        break;
                    case "lore":
                        CustomizeRemarks = kitAttribute[1];
                        break;
                    case "color":
                        Color = kitAttribute[1];
                        break;
                    case "book":
                    case "title":
                    case "author":
                        IsEnchantingBook = true;
                        break;
                    case "fade":
                    case "shape":
                    case "effect":
                    case "power":
                    case "type":
                        IsFireworks = true;
                        break;
                    case "player":
                        break;
                    default:
                        /*if(ItemId == 278)
                        {
                            int x = 0;
                        }*/
                        ItemEnchanting.Add(Constant.EssConst.ENCHANTINGS.Find(
                            (Enchanting en) => en.Name.Equals(kitAttribute[0])));
                        break;
                }
            }
            //kitAttribute.Add(kitValues[i].Split(':')[0], kitValues[i].Split(':')[1]);
            //CustomizeName = kitAttribute.ContainsKey("name") ? kitAttribute["name"] : "";
        }
    }

    public class KitBookItem : CustomizeItem
    {
        /// <summary>
        /// 自定义标题
        /// </summary>
        public string Ttile { get; set; }

        /// <summary>
        /// 自定义作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 章节名称
        /// </summary>
        public string Book { get; set; }
    }

    /// <summary>
    /// 烟花
    /// </summary>
    public class KitFireworksItme : CustomizeItem
    {

    }
}
