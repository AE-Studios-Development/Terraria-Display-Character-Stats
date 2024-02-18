using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class e2_ManaCost : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().ManaCost;
        }

		public override string DisplayValue(ref Color displayColor) {
			float manaCostInfo = (1 - Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().manaCostStat)*100;
			return $"Mana Efficiency: {manaCostInfo.ToString("N0")} %";
		}
	}
}