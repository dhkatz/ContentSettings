using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
