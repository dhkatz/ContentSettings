using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zorro.Settings;

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
