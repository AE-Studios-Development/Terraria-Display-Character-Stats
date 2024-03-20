using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class a5_ArmorPenetration : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().ArmorPenetration;
		}

		public override string DisplayValue(ref Color displayColor) {
			float armorPentrInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().armorPentrStat;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.a5_ArmorPenetration.DisplayName");
            return $"{textInfo}: {Math.Round(armorPentrInfo, 0)}";
		}
	}
}