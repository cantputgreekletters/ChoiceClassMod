using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.ID;

namespace ChoiceClassMod
{
    public enum ItemClass
    {
        Melee,
        Ranged,
        Mage,
        Summoner,
        Generic
    }
    
    public class ChoiceClassMod : Mod
    {
        public static List<int> Melee_Accessories = [];
        public static List<int> Ranged_Accessories = [];
        public static List<int> Mage_Accessories = [];
        public static List<int> Summoner_Accessories = [];
        public static string ItemClassToString(ItemClass item_class)
        {
            string txt = item_class switch
            {
                ItemClass.Melee => "Melee",
                ItemClass.Ranged => "Ranged",
                ItemClass.Mage => "Mage",
                ItemClass.Summoner => "Summoner",
                ItemClass.Generic => "Generic",
                _ => "How?"
            };
            return txt;
            
        }
    }
}
