namespace BkSerConfigUI.SerConfigHelp.Model
{
    public class Item
    {
        public string ItemName { get; set; }

        public int ItemId { get; set; }

        public int ItemMetadata { get; set; }

        public string ItemRemarks { get; set; }

        public Item() { }

        public Item(string[] itemLine)
        {
            ItemName = itemLine[0];
            ItemId = (int)Util.CurrencyUtil.ChangeLongNumber(itemLine[1]);
            ItemMetadata = itemLine.Length >= 3 ? (int)Util.CurrencyUtil.ChangeLongNumber(itemLine[2]) : 0;
            ItemRemarks = itemLine.Length >= 4 ? itemLine[3] : null;
        }
    }
}
