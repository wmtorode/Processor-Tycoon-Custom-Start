using BepInEx.Configuration;
using ProcessorTycoon.InitialData;

namespace customStart.data;

public static class CustomStartConfig
{
    public static ConfigEntry<float> StartingFunds;
    public static ConfigEntry<int> FactorySize;
    public static ConfigEntry<int> DifficultyLevel;
    public static ConfigEntry<string> StartingTechLevel;

    public static StartingTechnology StartingTechnology
    {
        get
        {
            StartingTechnology startingTech;
            StartingTechnology.TryParse(StartingTechLevel.Value, out startingTech);
            return startingTech;
        }
    }

    public static void InitConfig(ConfigFile configFile)
    {
        configFile.Bind("Start", "StartingFunds", 2500000f, new ConfigDescription(
            "Number of production planets to show. Too many and tip gets very large",
            new AcceptableValueRange<int>(2, 35)));  
    }
}