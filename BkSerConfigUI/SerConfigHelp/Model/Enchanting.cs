namespace BkSerConfigUI.SerConfigHelp.Model
{
    public class Enchanting
    {
        public Enchanting(string name, string customizeName, int level, int maxLevel)
        {
            Name = name;
            CustomizeName = customizeName;
            Level = level;
            MaxLevel = maxLevel;
        }
        public Enchanting()
        {

        }

        public string Name { get; set; }

        public string CustomizeName { get; set; }


        public int MaxLevel { get; set; }

        public int Level{ get; set; }
        
    }
}
