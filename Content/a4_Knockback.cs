using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class a4_Knockback : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().Knockback;
		}

		public override string DisplayValue(ref Color displayColor) {
			float knockbackInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().knockbackStat;
			return $"Knockback: {knockbackInfo.ToString("N2")} x";
		}
	}
}