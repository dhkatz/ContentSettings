// -----------------------------------------------------------------------
// <copyright file="ContentSettings.cs" company="ContentSettings">
// Copyright (c) ContentSettings. All rights reserved.
// Licensed under the GPL-3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace ContentSettings;

using BepInEx;
using HarmonyLib;

/// <summary>
/// The main Content Settings plugin class
/// </summary>
[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME,  MyPluginInfo.PLUGIN_VERSION)]
public class ContentSettings : BaseUnityPlugin
{
    private Harmony Harmony { get; } = new (MyPluginInfo.PLUGIN_GUID);

    private void Awake()
    {
        Harmony.PatchAll();
    }
}
