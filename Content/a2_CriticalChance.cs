using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class a2_CriticalChance : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().CriticalHitChance;
        }

		public override string DisplayValue(ref Color displayColor) {
			float critChanceInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().critChanceStat;
			return $"Critical Chance: {critChanceInfo} %";
		}
	}
}