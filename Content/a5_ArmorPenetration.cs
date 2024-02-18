using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;

namespace CharacterStats.Content
{
	public class a5_ArmorPenetration : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().ArmorPenetration;
		}

		public override string DisplayValue(ref Color displayColor) {
			float armorPentrInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().armorPentrStat;
			return $"Armor Penetration: {armorPentrInfo}";
		}
	}
}