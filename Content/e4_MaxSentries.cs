using Terraria;
using Terraria.ModLoader;
using CharacterStats.Common.Players;
using CharacterStats.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria.Localization;

namespace CharacterStats.Content
{
	public class e4_MaxSentries : InfoDisplay 
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().statsShown && ModContent.GetInstance<CharacterStatsConfig>().MaxSentries;
		}

		public override string DisplayValue(ref Color displayColor) {
			int maxMinionsInfo = Main.LocalPlayer.GetModPlayer<MainScriptPlayer>().maxSentriesStat;
            string textInfo = Language.GetTextValue("Mods.CharacterStats.InfoDisplays.e4_MaxSentries.DisplayName");
            return $"{textInfo}: {maxMinionsInfo}";
		}
	}
}