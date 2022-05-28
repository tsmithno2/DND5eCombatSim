using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DND5eCombatSim.App.Components;
using DND5eCombatSim.Shared;

namespace DND5eCombatSim.App.Pages
{
    public partial class Home
    {
        public IEnumerable<Character> CharactersList { get; set; }
        public List<Armor> ArmorList { get; set; }

        public List<Weapon> WeaponList { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeArmorList();
            InitializeWeaponList();
            InitializeCharactersList();

            return base.OnInitializedAsync();
        }

        private void InitializeArmorList()
        {
            ArmorList = new List<Armor>()
            {
                new Armor{ ArmorId = 1, ArmorName = "Leather", ArmorType = "Light", AC = 10, ArmorPicture ="picture" },
                new Armor{ ArmorId = 2, ArmorName = "Studded Leather", ArmorType = "Light", AC = 12, ArmorPicture ="picture" },
                new Armor{ ArmorId = 3, ArmorName = "Splint Mail", ArmorType = "Heavy", AC = 14, ArmorPicture ="picture" }
            };
        }
        private void InitializeWeaponList()
        {
            WeaponList = new List<Weapon>
            {
                new Weapon{ WeaponId = 1, WeaponName = "Dagger", WeaponType = "Simple", CharacterStatDependancy = "Dex", WeaponDamageFloor = 1, WeaponDamageCeiling = 4, WeaponDamageBonus = 0, WeaponPicture = "Picture" },
                new Weapon{ WeaponId = 2, WeaponName = "Longsword", WeaponType = "Simple", CharacterStatDependancy = "Str", WeaponDamageFloor = 1, WeaponDamageCeiling = 6, WeaponDamageBonus = 0, WeaponPicture = "Picture" },
                new Weapon{ WeaponId = 3, WeaponName = "Bastard Sword", WeaponType = "Martial", CharacterStatDependancy = "Dtr", WeaponDamageFloor = 2, WeaponDamageCeiling = 12, WeaponDamageBonus = 0, WeaponPicture = "Picture" }
            };
        }
        private void InitializeCharactersList()
        {


            var c1 = new Character
            {
                CharacterId = 1,
                CharacterName = "Frank",
                HitPointMaximum = 50,
                CurrentHitpoints = 50,
                Strength = 16,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 8,
                Wisdom = 10,
                Charisma = 10,
                WeaponId = 1,
                ArmorId = 1,
                AC = 12,
                MatchWins = 0,
                TotalMatches = 0
            };

            var c2 = new Character
            {
                CharacterId = 2,
                CharacterName = "Bob",
                HitPointMaximum = 50,
                CurrentHitpoints = 50,
                Strength = 16,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 8,
                Wisdom = 10,
                Charisma = 10,
                WeaponId = 2,
                ArmorId = 2,
                AC = 14,
                MatchWins = 0,
                TotalMatches = 0
            };

            var c3 = new Character
            {
                CharacterId = 3,
                CharacterName = "John",
                HitPointMaximum = 50,
                CurrentHitpoints = 50,
                Strength = 16,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 8,
                Wisdom = 10,
                Charisma = 10,
                WeaponId = 3,
                ArmorId = 3,
                AC = 16,
                MatchWins = 0,
                TotalMatches = 0
            };

            CharactersList = new List<Character> { c1, c2, c3 };
        }
    }
}
