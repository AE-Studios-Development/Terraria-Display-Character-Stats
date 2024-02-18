using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class d3_FishingPower : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().FishingPower;
        }

		public override string DisplayValue(ref Color displayColor) {
			int fishInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().fishingPowerStat;
			return $"Fishing Power: {fishInfo.ToString("N0")}";
		}
	}
}