using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using System.Globalization;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class b3_LifeRegeneration : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().LifeRegeneration;
		}

		public override string DisplayValue(ref Color displayColor) {
			int lifeRegenInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().lifeRegenStat;
            float hpPerSec = (float)lifeRegenInfo / 2;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.b3_LifeRegeneration.DisplayName");
            return $"{textInfo}: {Math.Round(hpPerSec, 1)} hp/s";
		}
	}
}