using Terraria.ModLoader;

namespace CharacterStats.Common.Systems
{
    public class KeybindSystem : ModSystem
    {
        public static ModKeybind ChangeStatClassKeybind { get; private set; }
        public static ModKeybind StatVisibilityKeybind { get; private set; }

        public override void Load() {
            ChangeStatClassKeybind = KeybindLoader.RegisterKeybind(Mod, "ChangeStatClassKeybind", "K");
            StatVisibilityKeybind = KeybindLoader.RegisterKeybind(Mod, "StatVisibilityKeybind", "L");
        }

        public override void Unload() {
            ChangeStatClassKeybind = null;
            StatVisibilityKeybind = null;
        }
    }
}