using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class a3_AttackSpeed : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().CriticalHitChance; ;
		}

		public override string DisplayValue(ref Color displayColor) {
			float attackSpeedInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().attackSpeedStat;
			return $"Attack Speed: {attackSpeedInfo.ToString("N2")} x";
		}
	}
}