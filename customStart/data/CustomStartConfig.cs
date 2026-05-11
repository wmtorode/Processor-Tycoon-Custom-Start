using System;
using System.Linq;
using BepInEx.Configuration;
using ProcessorTycoon.InitialData;

namespace customStart.data;

public static class CustomStartConfig
{
    public static ConfigEntry<float> StartingFunds;
    public static ConfigEntry<int> FactorySize;
    public static ConfigEntry<string> DifficultyLevel;
    public static ConfigEntry<string> StartingTechLevel;
    public static ConfigEntry<bool> EnableResearchSpeedModifer;
    public static ConfigEntry<bool> EnableMaintainanceCostModifer;
    public static ConfigEntry<bool> EnableConstructionCostModifer;
    public static ConfigEntry<bool> EnableDevelopmentCostModifer;
    public static ConfigEntry<bool> EnableResearchCostModifer;
    public static ConfigEntry<bool> EnableTaxesModifer;
    public static ConfigEntry<bool> EnableInterestModifer;
    
    public static ConfigEntry<float> ResearchSpeedModifer;
    public static ConfigEntry<float> MaintainanceCostModifer;
    public static ConfigEntry<float> ConstructionCostModifer;
    public static ConfigEntry<float> DevelopmentCostModifer;
    public static ConfigEntry<float> ResearchCostModifer;
    public static ConfigEntry<float> TaxesModifer;
    public static ConfigEntry<float> InterestModifer;

    public static StartingTechnology StartingTechnology
    {
        get
        {
            StartingTechnology startingTech;
            StartingTechnology.TryParse(StartingTechLevel.Value, out startingTech);
            return startingTech;
        }
    }

    public static int Difficulty
    {
        get
        {
            DifficultyLevel difficultyLevel;
            Enum.TryParse(DifficultyLevel.Value, out difficultyLevel);
            return (int) difficultyLevel;
        }
    }
    

    public static void InitConfig(ConfigFile configFile)
    {
        StartingFunds = configFile.Bind("Start", "StartingFunds", 2500000f, new ConfigDescription(
            "Funds to start the game with"));

        FactorySize = configFile.Bind("Start", "FactoryLines", 5, new ConfigDescription("The number of factory lines to start with"));
        
        var diffValues = Enum.GetNames(typeof(DifficultyLevel));
        
        DifficultyLevel = configFile.Bind("Start", "DifficultyLevel", data.DifficultyLevel.Normal.ToString(), new ConfigDescription("The difficulty level to start with", new AcceptableValueList<string>(diffValues)));
        
        var techValues = Enum.GetNames(typeof(StartingTechnology));
        
        StartingTechLevel = configFile.Bind("Start", "StartingTechLevel", StartingTechnology.Competitive.ToString(), new ConfigDescription("The level of technology to start with compared to your competitors", new AcceptableValueList<string>(techValues)));
        
        EnableResearchSpeedModifer = configFile.Bind("ResearchModifiers", "EnableResearchSpeedModifer", false, "Enable the research speed modifier");
        ResearchSpeedModifer = configFile.Bind("ResearchModifiers", "ResearchSpeedModifer", 1f, "The research speed modifier");
        
        EnableMaintainanceCostModifer = configFile.Bind("ResearchModifiers", "EnableMaintainanceCostModifer", false, "Enable the maintenance cost modifier");
        MaintainanceCostModifer = configFile.Bind("ResearchModifiers", "MaintainanceCostModifer", 1f, "The maintenance cost modifier");
        
        EnableConstructionCostModifer = configFile.Bind("ResearchModifiers", "EnableConstructionCostModifer", false, "Enable the construction cost modifier");
        ConstructionCostModifer = configFile.Bind("ResearchModifiers", "ConstructionCostModifer", 1f, "The construction cost modifier");
        
        EnableDevelopmentCostModifer = configFile.Bind("ResearchModifiers", "EnableDevelopmentCostModifer", false, "Enable the development cost modifier");
        DevelopmentCostModifer = configFile.Bind("ResearchModifiers", "DevelopmentCostModifer", 1f, "The development cost modifier");
        
        EnableResearchCostModifer = configFile.Bind("ResearchModifiers", "EnableResearchCostModifer", false, "Enable the research cost modifier");
        ResearchCostModifer = configFile.Bind("ResearchModifiers", "ResearchCostModifer", 1f, "The research cost modifier");
        
        EnableTaxesModifer = configFile.Bind("ResearchModifiers", "EnableTaxesModifer", false, "Enable the taxes modifier");
        TaxesModifer = configFile.Bind("ResearchModifiers", "TaxesModifer", 1f, "The taxes modifier");
        
        EnableInterestModifer = configFile.Bind("ResearchModifiers", "EnableInterestModifer", false, "Enable the interest modifier");
        InterestModifer = configFile.Bind("ResearchModifiers", "InterestModifer", 1f, "The interest modifier");
    }
}