using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class c1_MovementSpeed : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().MovementSpeed;
		}

		public override string DisplayValue(ref Color displayColor) {
			float moveSpeedInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().moveSpeedStat / 3;
			return $"Move Speed: {moveSpeedInfo.ToString("N2")} x";
		}
	}
}