using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class d1_Aggro : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().EnemyAggro;
		}

		public override string DisplayValue(ref Color displayColor) {
			int aggroInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().aggroStat;
			return $"Enemy Aggro: {aggroInfo.ToString("N0")}";
		}
	}
}