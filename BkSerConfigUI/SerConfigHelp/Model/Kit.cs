using System.Collections.Generic;

namespace BkSerConfigUI.SerConfigHelp.Model
{
    public class Kit
    {
        public string KitName { get; set; }

        public long Delay { get; set; }

        public string KitType { get; set; }

        public object Tag { get; set; }

        public List<KitItem> KitItems = new List<KitItem>();
    }

    public class KitItem : Item
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
        /// 物品附魔属性
        /// </summary>
        public List<Enchanting> ItemEnchanting = new List<Enchanting>();

        public KitItem(){ }

        public KitItem(string kitValue)
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

    public class KitBookItem : KitItem
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

    public class KitFireworksItme : KitItem
    {

    }
}
