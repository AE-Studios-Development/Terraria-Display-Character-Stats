using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using System;

namespace CharacterStats.Content
{
	public class c2_JumpHeight : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().JumpHeight;
		}

		public override string DisplayValue(ref Color displayColor) {
			int jumpHeightInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().jumpHeightStat;
			float jumpSpeedInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().jumpSpeedStat;
			double approxJumpPower = (((float)jumpHeightInfo + 1) * (jumpSpeedInfo - .4) + .2 * Math.Pow((jumpSpeedInfo / .4) - 1, 2)) / 16;
			return $"Jump Height: {approxJumpPower.ToString("N2")} tiles";
		}
	}
}