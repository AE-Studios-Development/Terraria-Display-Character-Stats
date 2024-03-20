using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class b2_Endurance : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().Endurance;
		}

		public override string DisplayValue(ref Color displayColor) {
			double enduranceInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().enduranceStat;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.b2_Endurance.DisplayName");
            return $"{textInfo}: {Math.Round(enduranceInfo, 1)} %";
		}
	}
}