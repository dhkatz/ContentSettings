using HarmonyLib;

namespace ContentSettings.API.Patches
{
    [HarmonyPatch(typeof(SettingCategoryTab), nameof(SettingCategoryTab.Select))]
    public static class SettingsTabSelectModdedPatch
    {
        [HarmonyPrefix]
        public static bool Prefix(SettingCategoryTab __instance)
        {
            if (__instance.name == "ModdedSettings")
            {
                SettingsLoader.LoadSettingsMenu(__instance.settingsMenu);
                return false;
            }
            return true;
        }
    }
}
