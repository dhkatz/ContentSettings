using BepInEx;
using ContentSettings.API;
using System.Collections.Generic;
using Zorro.Settings;

namespace SettingsTemplate
{
    [BepInPlugin("commander__cat.contentwarning.settingstemplate", "ContentSettings", "0.0.1")]
    public class Main : BaseUnityPlugin
    {
        public static Main Instance { get; private set; } = null!;

        public bool FeatureEnabled = true;

        void Awake()
        {
            Instance = this;
            SettingsLoader.RegisterSetting(new SettingTemplate());
        }
    }

    public class SettingTemplate : EnumSetting, IExposedSetting
    {
        public override void ApplyValue()
        {
            Main.Instance.FeatureEnabled = Value != 0; 
        }

        public override List<string> GetChoices()
        {
            return new List<string>()
            {
                "Off",
                "On",
            };
        }

        public string GetDisplayName()
        {
            return "Mod Feature Enabled?";
        }

        public SettingCategory GetSettingCategory()
        {
            //Doesnt matter what category it is. 
            return SettingCategory.Graphics;
        }

        public override int GetDefaultValue()
        {
            return 1;
        }
    }
}
