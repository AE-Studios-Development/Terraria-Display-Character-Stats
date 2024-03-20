using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using System;

namespace CharacterStats.Content
{
	public class a1_Damage : InfoDisplay
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().DamageMultiplier;
		}
		
		public override string DisplayValue(ref Color displayColor) {
            float damageInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().damageStat;
			string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.a1_Damage.DisplayName");
            return $"{textInfo}: {Math.Round(damageInfo, 2)} x";
        }
	}
}