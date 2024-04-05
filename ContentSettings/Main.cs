using BepInEx;
using ContentSettings.API;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zorro.Settings;

namespace ContentSettings
{
    [BepInPlugin("commander__cat.contentwarning.contentsettings", "ContentSettings", "1.0.1")]
    public class Main : BaseUnityPlugin
    {
        public static Main instance { get; private set; }

        private Harmony harmony;

        void Awake()
        {
            harmony = new Harmony("commander__cat.contentwarning.contentsettingsharmony");
            harmony.PatchAll();
        }
    }
}
