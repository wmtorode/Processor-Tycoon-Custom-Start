using BepInEx;
using BepInEx.Logging;
using customStart.data;
using HarmonyLib;
using System.Reflection;

namespace customStart;

[BepInPlugin("ca.jwolf.customStart", "Custom Start", "1.0.0")]
public class CustomStartPlugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
        
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin Custom Start is loaded!");
        
        // load config
        CustomStartConfig.InitConfig(Config);
        
        Logger.LogInfo($"Starting funds: {CustomStartConfig.StartingFunds.Value}");
        Logger.LogInfo($"Starting factory size: {CustomStartConfig.FactorySize.Value}");
        Logger.LogInfo($"Starting difficulty level: {CustomStartConfig.DifficultyLevel.Value}");
        Logger.LogInfo($"Starting technology level: {CustomStartConfig.StartingTechLevel.Value}");
        Logger.LogInfo($"Starting technology: {CustomStartConfig.StartingTechnology}");
        
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "ca.jwolf.customStart");
        
    }
}
