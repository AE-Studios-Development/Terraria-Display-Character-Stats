using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class c3_MiningSpeed : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().MiningSpeed;
		}

		public override string DisplayValue(ref Color displayColor) {
			float miningSpeedInfo = (1 - Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().miningSpeedStat) * 100;
			return $"Mining Speed: {miningSpeedInfo.ToString("N0")} %";
		}
	}
}