using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;
using Terraria.Localization;
using CharacterStats.Common.Systems; 
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace CharacterStats.Common.Players
{
	public class MainScriptPlayer : ModPlayer
	{
		// Global Stats
		public float damageStat = 0;
		public float critChanceStat = 0;
		public float attackSpeedStat = 0;
		public float knockbackStat = 0;
		public float armorPentrStat = 0;

		public float miningSpeedStat = 0;
		public float moveSpeedStat = 0;
		public int jumpHeightStat = 0;
		public float jumpSpeedStat = 0;

		public int fishingPowerStat = 0;
        public float luckStat = 0;
        public int aggroStat = 0;

		public int defenseStat = 0;
		public float dmgReductionStat = 0;
		public int lifeRegenStat = 0;

		public float manaCostStat = 0;
		public int manaRegenStat = 0;
		public int maxMinionsStat = 0;
		public int maxSentriesStat = 0;

		public bool paladinShield = false;
		public bool solarBlaze = false;
		public int beetleEndurance = 0;

		// Main Variables
		public bool statsShown = true;
		public int classIndex = 0;
		List<string> classString = new List<string>() { "Automatic" };

		// Get all available damage classes
		public override void Initialize()
		{
			for (int i = 1; i < DamageClassLoader.DamageClassCount; i++) {
				string classDirectory = $"{DamageClassLoader.GetDamageClass(i)}";
				string[] directories = classDirectory.Split(".");
				classString.Add($"{directories[directories.Length - 1].Replace("DamageClass", "")}" + (directories[0] != "Terraria" ? $" ({directories[0]})" : ""));
			}
		}

		public override void PostUpdate()
		{
			// Get offense stats and apply to the appropriate class
			damageStat = Player.GetDamage(DamageClass.Generic).ApplyTo(1);
			critChanceStat = Player.GetCritChance(DamageClass.Generic);
			attackSpeedStat = Player.GetAttackSpeed(DamageClass.Generic);
			knockbackStat = Player.GetKnockback(DamageClass.Generic).ApplyTo(1);
			armorPentrStat = Player.GetArmorPenetration(DamageClass.Generic);

			if (classIndex == 0 || classIndex != 1) {
				int itemClassIndex = (classIndex == 0 ? Player.HeldItem.DamageType.Type : classIndex);
				int attackSpeedClass = (itemClassIndex == 7 ? 2 : (itemClassIndex == 3 ? classIndex : itemClassIndex));
				itemClassIndex -= (itemClassIndex == 3 || itemClassIndex == 7 ? 1 : 0);

				damageStat += Player.GetDamage(DamageClassLoader.GetDamageClass(itemClassIndex)).ApplyTo(1) - 1;
				critChanceStat += Player.GetCritChance(DamageClassLoader.GetDamageClass(itemClassIndex));
				attackSpeedStat += Player.GetAttackSpeed(DamageClassLoader.GetDamageClass(attackSpeedClass)) - 1;
				knockbackStat += Player.GetKnockback(DamageClassLoader.GetDamageClass(itemClassIndex)).ApplyTo(1) - 1;
				armorPentrStat += Player.GetArmorPenetration(DamageClassLoader.GetDamageClass(itemClassIndex));
			}

			// Get other stats
			miningSpeedStat = Player.pickSpeed;
			moveSpeedStat = Player.maxRunSpeed;
			jumpHeightStat = Player.jumpHeight;
			jumpSpeedStat = Player.jumpSpeed;
			
			aggroStat = Player.aggro;
            luckStat = Player.luck;
			fishingPowerStat = Player.GetFishingConditions().FinalFishingLevel;

			defenseStat = Player.statDefense;
            dmgReductionStat = Player.endurance;
			lifeRegenStat = Player.lifeRegen;

			manaCostStat = Player.manaCost;
			manaRegenStat = Player.manaRegen;
			maxMinionsStat = Player.maxMinions;
			maxSentriesStat = Player.maxTurrets;

			// Calculate endurance stat
			bool hasPaladinShield = false;
			bool hasSolarBlaze = false;
			int hasBeetleEndurance = 0;

			for (int i = 0; i < Player.buffType.Length; i++) {
				switch (Player.buffType[i]) {
					case 170: case 171: case 172:
						hasSolarBlaze = true;
						break;
					case 95: case 96: case 97:
						hasBeetleEndurance = Player.buffType[i] - 94;
						break;
					case 43:
						hasPaladinShield = true;
						break;
					default:
						break;
				}
			}

			paladinShield = hasPaladinShield;
			solarBlaze = hasSolarBlaze;
			beetleEndurance = hasBeetleEndurance;
		}

		// Player inputs
		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (KeybindSystem.ChangeStatClassKeybind.JustPressed) {
				classIndex = (classIndex + 1 == classString.Count ? 0 : classIndex + 1);
				Main.NewText("Player Stats Damage Class: " + classString[classIndex]);
            }

			if (KeybindSystem.StatVisibilityKeybind.JustPressed) {
				statsShown = !statsShown;
				Main.NewText("Player Stats Visibility: " + (statsShown ? "Shown" : "Hidden"));
			}
		}
	}
}