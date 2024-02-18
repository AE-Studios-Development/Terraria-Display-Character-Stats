using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class e1_ManaRegeneration : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().ManaRegeneration;
		}

		public override string DisplayValue(ref Color displayColor) {
			int manaRegenInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().manaRegenStat;
			float mpPerSec = (float)manaRegenInfo / 2;
			return $"Mana Regen: {mpPerSec.ToString("N1")} mp/s";
		}
	}
}