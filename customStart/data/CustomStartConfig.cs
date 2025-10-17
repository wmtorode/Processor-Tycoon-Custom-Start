using System;
using System.Linq;
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
        StartingFunds = configFile.Bind("Start", "StartingFunds", 2500000f, new ConfigDescription(
            "Funds to start the game with"));

        FactorySize = configFile.Bind("Start", "FactoryLines", 5, new ConfigDescription("The number of factory lines to start with"));
        
        DifficultyLevel = configFile.Bind("Start", "DifficultyLevel", 2, new ConfigDescription("The difficulty level to start with", new AcceptableValueRange<int>(0, 4)));
        
        var techValues = Enum.GetNames(typeof(StartingTechnology));
        
        StartingTechLevel = configFile.Bind("Start", "StartingTechLevel", StartingTechnology.Competitive.ToString(), new ConfigDescription("The level of technology to start with compared to your competitors", new AcceptableValueList<string>(techValues)));
        
    }
}