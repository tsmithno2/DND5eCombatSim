using System;
using System.Collections.Generic;
using System.Text;

namespace DND5eCombatSim.Shared
{
    public class Character
    {
        public string CharacterId { get; set; }

        public string CharacterFirstName { get; set; }

        public string CharacterLastName { get; set; }

        public string ProfilePicture { get; set; }

        public int Level { get; set; }

        public int Class { get; set; }

        public int SubClass { get; set; }

        public int HitPointMaximum { get; set; }

        public int CurrentHitpoints { get; set; }

        public int Strength  { get; set; }
        
        public int StrengthBonus { get; set; }

        public int Dexterity { get; set; }
        
        public int DexterityBonus { get; set; }

        public int Constitution { get; set; }

        public int ConstitutionBonus { get; set; }

        public int Intelligence { get; set; }

        public int IntelligenceBonus { get; set; }

        public int Wisdom { get; set; }

        public int WisdomBonus { get; set; }

        public int Charisma { get; set; }

        public int CharismaBonus { get; set; }

        public int Initiative { get; set; }
          
        public int Proficiency { get; set; }

        public int NumberOfAttacks { get; set; }

        public int WeaponId { get; set; }
        
        public bool SimpleWeaponProficiency { get; set; }
        
        public bool MartialWeaponProficiency { get; set; }

        public int AC { get; set; }

        public int ArmorId { get; set; }

        public bool LightArmorProficiency { get; set; }

        public bool MediumArmorProficiency { get; set; }
        
        public bool HeavyArmorProficiency { get; set; }

        public bool ShieldProficiency { get; set; }

        public int MatchWins { get; set; }

        public int MatchLosses { get; set; }

        public int TotalMatches { get; set; }

        public int WinLossPercentage { get; set; }
    }
}
