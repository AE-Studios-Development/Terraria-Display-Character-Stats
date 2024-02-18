using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class e4_MaxSentries : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().MaxSentries;
		}

		public override string DisplayValue(ref Color displayColor) {
			int maxMinionsInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().maxSentriesStat;
			return $"Max Sentries: {maxMinionsInfo.ToString("N0")}";
		}
	}
}