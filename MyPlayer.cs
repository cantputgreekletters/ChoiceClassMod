using System;
using Terraria;
using Terraria.ModLoader;



namespace ChoiceClassMod
{
    public class MyPlayer : ModPlayer
    {
        //This is gonna be set by the UI upon character creation
        public DamageClass selected_class = DamageClass.Generic;
        public ItemClass selected_item_class = ItemClass.Generic;

        public override bool CanUseItem(Item item)
        {
            //if item is a tool
            if (item.pick > 0 || item.axe > 0 || item.hammer > 0)
            {
                return base.CanUseItem(item);
            }
            if (selected_class != DamageClass.Default && !item.DamageType.CountsAsClass(selected_class))
            {
                return false;
            }
            return base.CanUseItem(item);
        } 
    }    
}