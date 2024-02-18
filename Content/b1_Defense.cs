using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class b1_Defense : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().Defense;
		}

		public override string DisplayValue(ref Color displayColor) {
			int defenseInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().defenseStat;
			return $"Defense: {defenseInfo.ToString("N0")}";
		}
	}
}