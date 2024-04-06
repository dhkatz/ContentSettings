using BepInEx;
using HarmonyLib;

namespace ContentSettings
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME,  MyPluginInfo.PLUGIN_VERSION)]
    public class Main : BaseUnityPlugin
    {
        public static Main Instance { get; private set; } = null!;

        private readonly Harmony _harmony = new (MyPluginInfo.PLUGIN_GUID);

        private void Awake()
        {
            Instance = this;

            _harmony.PatchAll();
        }
    }
}
