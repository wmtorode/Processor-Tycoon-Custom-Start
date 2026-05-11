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
        
        Logger.LogInfo($"Enable Research Speed Modifier: {CustomStartConfig.EnableResearchSpeedModifer.Value}");
        Logger.LogInfo($"Research Speed Modifier: {CustomStartConfig.ResearchSpeedModifer.Value}");
        Logger.LogInfo($"Enable Maintenance Cost Modifier: {CustomStartConfig.EnableMaintainanceCostModifer.Value}");
        Logger.LogInfo($"Maintenance Cost Modifier: {CustomStartConfig.MaintainanceCostModifer.Value}");
        Logger.LogInfo($"Enable Construction Cost Modifier: {CustomStartConfig.EnableConstructionCostModifer.Value}");
        Logger.LogInfo($"Construction Cost Modifier: {CustomStartConfig.ConstructionCostModifer.Value}");
        Logger.LogInfo($"Enable Development Cost Modifier: {CustomStartConfig.EnableDevelopmentCostModifer.Value}");
        Logger.LogInfo($"Development Cost Modifier: {CustomStartConfig.DevelopmentCostModifer.Value}");
        Logger.LogInfo($"Enable Research Cost Modifier: {CustomStartConfig.EnableResearchCostModifer.Value}");
        Logger.LogInfo($"Research Cost Modifier: {CustomStartConfig.ResearchCostModifer.Value}");
        Logger.LogInfo($"Enable Taxes Modifier: {CustomStartConfig.EnableTaxesModifer.Value}");
        Logger.LogInfo($"Taxes Modifier: {CustomStartConfig.TaxesModifer.Value}");
        Logger.LogInfo($"Enable Interest Modifier: {CustomStartConfig.EnableInterestModifer.Value}");
        Logger.LogInfo($"Interest Modifier: {CustomStartConfig.InterestModifer.Value}");
        
        
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "ca.jwolf.customStart");
        
    }
}
