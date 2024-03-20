using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class c3_MiningSpeed : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().MiningSpeed;
		}

		public override string DisplayValue(ref Color displayColor) {
			float miningSpeedInfo = (1 - Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().miningSpeedStat) * 100;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.c3_MiningSpeed.DisplayName");
            return $"{textInfo}: {Math.Round(miningSpeedInfo, 0)} %";
		}
	}
}