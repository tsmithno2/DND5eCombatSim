using System;
using System.Collections.Generic;
using System.Text;

namespace DND5eCombatSim.Shared
{
    public class Weapon
    {
        public int WeaponId { get; set; }

        public string WeaponName { get; set; }

        //simple, martial, firearm
        public string WeaponType { get; set; }

        //strength, dex, charisma
        public string CharacterStatDependancy { get; set; }

        public int WeaponDamageFloor { get; set; }

        public int WeaponDamageCeiling { get; set; }

        //ie magical +1 longsword, so +1 to hit and damage
        public int WeaponDamageBonus { get; set; }

        public string WeaponPicture { get; set; }
    }
}
