using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class d2_Luck : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().Luck;
		}

		public override string DisplayValue(ref Color displayColor) {
			float luckInfo = 100 * Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().luckStat;
			return $"Luck: {luckInfo.ToString("N1")} %";
		}
	}
}