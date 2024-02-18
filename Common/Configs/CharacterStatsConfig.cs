using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace CharacterStats.Common.Configs
{
    public class CharacterStatsConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("StatVisibility")]

        [DefaultValue(true)]
        public bool DamageMultiplier;

        [DefaultValue(true)]
        public bool CriticalHitChance;

        [DefaultValue(true)]
        public bool AttackSpeed;

        [DefaultValue(true)]
        public bool Knockback;

        [DefaultValue(true)]
        public bool ArmorPenetration;

        [DefaultValue(true)]
        public bool Defense;

        [DefaultValue(true)]
        public bool Endurance;

        [DefaultValue(true)]
        public bool LifeRegeneration;

        [DefaultValue(true)]
        public bool MovementSpeed;

        [DefaultValue(true)]
        public bool JumpHeight;

        [DefaultValue(true)]
        public bool MiningSpeed;

        [DefaultValue(true)]
        public bool EnemyAggro;

        [DefaultValue(true)]
        public bool Luck;

        [DefaultValue(true)]
        public bool FishingPower;

        [DefaultValue(true)]
        public bool ManaRegeneration;

        [DefaultValue(true)]
        public bool ManaCost;

        [DefaultValue(true)]
        public bool MaxMinions;

        [DefaultValue(true)]
        public bool MaxSentries;
    }
}