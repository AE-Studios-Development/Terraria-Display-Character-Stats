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
			float dmgReductionAddInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().dmgReductionStat;
			bool hasPaladinShield = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().paladinShield;
			bool hasSolarBlaze = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().solarBlaze;
			int hasBeetleEndurance = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().beetleEndurance;

			double totalDamageReduction = 100 - ((hasPaladinShield ? 0.75 : 1) * (hasSolarBlaze ? 0.8 : 1) * (hasBeetleEndurance > 0 ? 1 - (0.15 * hasBeetleEndurance) : 1) * (1 - dmgReductionAddInfo)) * 100;
			return $"Endurance: {totalDamageReduction.ToString("N0")} %";
		}
	}
}