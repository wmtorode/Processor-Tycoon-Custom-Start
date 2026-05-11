using customStart.data;
using HarmonyLib;
using ProcessorTycoon;
using ProcessorTycoon.Menu;

namespace customStart.Patches;

[HarmonyPatch(typeof(MenuGameSetup), "UpdateInitialData")]
class MenuGameSetup_UpdateInitialData
{
    public static void Postfix(MenuGameSetup __instance)
    {
        var factorySize = CustomStartConfig.FactorySize.Value;
        var difficultyLevel = CustomStartConfig.Difficulty;
        __instance.playerInitialData.StartingFunds =  CustomStartConfig.StartingFunds.Value;
        __instance.playerInitialData.FactorySize = factorySize;
        __instance.playerInitialData.StartingTechnology = CustomStartConfig.StartingTechnology;
        __instance.playerInitialData.DifficultyLevel = difficultyLevel;
        __instance.playerInitialData.EnableCheats = __instance.enableCheatsToggle.IsOn;
        __instance.startingFundsText.Text = StringFormatter.FloatToMoney(CustomStartConfig.StartingFunds.Value);
        __instance.factorySizeText.Text = factorySize <= 1 ? string.Format("{0} line", factorySize) : string.Format("{0} lines", factorySize);
        __instance.technologyText.Text = CustomStartConfig.StartingTechLevel.Value;
        __instance.aiText.Text = __instance.aiStrings[difficultyLevel];
    }
}

