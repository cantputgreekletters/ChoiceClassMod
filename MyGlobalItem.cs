using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
namespace ChoiceClassMod
{
    
    public class MyGlobalItem : GlobalItem
    {
        //default Item Class for every item
        public ItemClass item_class = ItemClass.Generic;
        public override bool InstancePerEntity => true;
        public override void SetDefaults(Item entity)
        {
            //This is for testing
            if (ChoiceClassMod.Melee_Accessories.Contains(entity.type))
            {
                item_class = ItemClass.Melee;
            }
            else if (ChoiceClassMod.Ranged_Accessories.Contains(entity.type))
            {
                item_class = ItemClass.Ranged;
            }
            else if (ChoiceClassMod.Mage_Accessories.Contains(entity.type))
            {
                item_class = ItemClass.Mage;
            }
            else if (ChoiceClassMod.Summoner_Accessories.Contains(entity.type))
            {
                item_class = ItemClass.Summoner;
            }
            else
            {
                base.SetDefaults(entity);
            }
        }


        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item_class != ItemClass.Generic)
            {
                TooltipLine line = new TooltipLine(Mod, "ItemClass", $"Item Class : {ChoiceClassMod.ItemClassToString(item_class)}");
                tooltips.Add(line);
            }
        }

        public override bool CanEquipAccessory(Item item, Player player, int slot, bool modded)
        {
            if (item_class == ItemClass.Generic)
            {
                return base.CanEquipAccessory(item, player, slot, modded);
            }
            MyPlayer mod_player = player.GetModPlayer<MyPlayer>();
            return mod_player.selected_item_class == item_class;
        }
    }
    
}