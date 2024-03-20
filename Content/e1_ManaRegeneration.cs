using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class e1_ManaRegeneration : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().ManaRegeneration;
		}

		public override string DisplayValue(ref Color displayColor) {
			int manaRegenInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().manaRegenStat;
			float mpPerSec = (float)manaRegenInfo / 2;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.e1_ManaRegeneration.DisplayName");
            return $"{textInfo}: {Math.Round(mpPerSec, 1)} mp/s";
		}
	}
}