using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class c1_MovementSpeed : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().MovementSpeed;
		}

		public override string DisplayValue(ref Color displayColor) {
			float moveSpeedInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().moveSpeedStat / 3;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.c1_MovementSpeed.DisplayName");
            return $"{textInfo}: {Math.Round(moveSpeedInfo, 2)} x";
		}
	}
}