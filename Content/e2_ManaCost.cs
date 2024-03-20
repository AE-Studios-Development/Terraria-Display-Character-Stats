using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class e2_ManaCost : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().ManaCost;
        }

		public override string DisplayValue(ref Color displayColor) {
			float manaCostInfo = (1 - Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().manaCostStat)*100;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.e2_ManaCost.DisplayName");
            return $"{textInfo}: {Math.Round(manaCostInfo, 1)} %";
		}
	}
}