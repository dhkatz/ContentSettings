using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.PropertyVariants;

namespace ContentSettings.API.Patches
{
    [HarmonyPatch(typeof(SettingsMenu), nameof(SettingsMenu.OnEnable))]
    public static class SettingsPageOpenPatch
    {
        [HarmonyPrefix]
        public static bool Prefix(SettingsMenu __instance)
        {
            if (__instance.transform.Find("Content").Find("TABS").Find("ModdedSettings") != null)
                return true;

            var oldtab = __instance.transform.Find("Content").Find("TABS").GetChild(0).gameObject;

            var copytab = GameObject.Instantiate(oldtab);
            copytab.name = "ModdedSettings";

            copytab.transform.SetParent(__instance.transform.Find("Content").Find("TABS"));
            var text = copytab.transform.GetChild(1);

            GameObject.Destroy(text.GetComponent<GameObjectLocalizer>());
            text.GetComponent<TextMeshProUGUI>().SetText("MODDED");

            return true;
        }
    }
}
