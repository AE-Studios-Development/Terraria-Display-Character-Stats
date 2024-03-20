using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class c2_JumpHeight : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().JumpHeight;
		}

		public override string DisplayValue(ref Color displayColor) {
			double jumpHeightInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().jumpHeightStat;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.c2_JumpHeight.DisplayName");
            return $"{textInfo}: {Math.Round(jumpHeightInfo, 2)} tiles";
		}
	}
}