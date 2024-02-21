using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class b2_Endurance : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().Endurance;
		}

		public override string DisplayValue(ref Color displayColor) {
			double enduranceInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().enduranceStat;
            return $"Endurance: {enduranceInfo.ToString("N1")} %";
		}
	}
}