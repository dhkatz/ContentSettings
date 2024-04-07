namespace SettingsTemplate;

using BepInEx;
using ContentSettings.API;
using System.Collections.Generic;
using Zorro.Settings;

[BepInPlugin("SettingsTemplate", "SettingsTemplate", "1.0.0")]
public class Main : BaseUnityPlugin
{
    public static Main Instance { get; private set; } = null!;

    public bool FeatureEnabled = true;

    private void Awake()
    {
        Instance = this;
        SettingsLoader.RegisterSetting(new SettingTemplate());
    }
}

public class SettingTemplate : EnumSetting, IExposedSetting
{
    public override void ApplyValue() => Main.Instance.FeatureEnabled = Value != 0;

    public override List<string> GetChoices() => ["Off", "On"];

    public string GetDisplayName() => "Mod Feature Enabled?";

    public SettingCategory GetSettingCategory() => SettingCategory.Graphics;

    public override int GetDefaultValue() => 1;
}
