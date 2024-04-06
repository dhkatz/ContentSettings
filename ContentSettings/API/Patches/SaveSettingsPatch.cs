using HarmonyLib;
using Zorro.Settings;

namespace ContentSettings.API.Patches
{
    [HarmonyPatch(typeof(DefaultSettingsSaveLoad), nameof(DefaultSettingsSaveLoad.WriteToDisk))]
    public static class SaveSettingsPatch
    {
        [HarmonyPrefix]
        public static void Register()
        {
            SettingsLoader.SaveSettings();
        }
    }
}
