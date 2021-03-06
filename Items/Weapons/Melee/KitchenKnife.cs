﻿using System;
using Zeds.Engine;

namespace Zeds.Items.Weapons.Melee
{
    public class KitchenKnife : Weapon
    {
        public static KitchenKnife CreateKitchenKnife()
        {
            KitchenKnife kitchenKnife = new KitchenKnife
            {
                Icon = Textures.KitchenKnife,
                Power = 1,
                Range = 1,
                IsWeapon = true,
                ID = Guid.NewGuid()
            };

            return kitchenKnife;
        }
    }
}
