using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class e3_MaxMinions : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().MaxMinions;
		}

		public override string DisplayValue(ref Color displayColor) {
			int maxMinionsInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().maxMinionsStat;
			return $"Max Minions: {maxMinionsInfo.ToString("N0")}";
		}
	}
}