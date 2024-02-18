using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class a1_Damage : InfoDisplay
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().DamageMultiplier;
		}

		public override string DisplayValue(ref Color displayColor) {
			float damageInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().damageStat;
            return $"Damage: {damageInfo.ToString("N2")} x";
        }
	}
}