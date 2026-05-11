using customStart.data;
using HarmonyLib;
using ProcessorTycoon;
using ProcessorTycoon.CompanySystem;

namespace customStart.Patches;


[HarmonyPatch(typeof(Modifiers), "GetModifier")]
class Modifiers_GetModifier
{
    public static void Postfix(ModifierType type, ICompany company, ref float __result)
    {
        if (company == null) return;

        switch (type)
        {
            case ModifierType.ResearchSpeed:
                if (company.IsPlayer && CustomStartConfig.EnableResearchSpeedModifer.Value)
                {
                    __result = CustomStartConfig.ResearchSpeedModifer.Value;
                }
                break;
            case ModifierType.MaintainanceCost:
                if (company.IsPlayer && CustomStartConfig.EnableMaintainanceCostModifer.Value)
                {
                    __result = CustomStartConfig.MaintainanceCostModifer.Value;
                }
                break;
            case ModifierType.ConstructionCost:
                if (company.IsPlayer && CustomStartConfig.EnableConstructionCostModifer.Value)
                {
                    __result = CustomStartConfig.ConstructionCostModifer.Value;
                }
                break;
            case ModifierType.DevelopmentCost:
                if (company.IsPlayer && CustomStartConfig.EnableDevelopmentCostModifer.Value)
                {
                    __result = CustomStartConfig.DevelopmentCostModifer.Value;
                }
                break;
            case ModifierType.ResearchCost:
                if (company.IsPlayer && CustomStartConfig.EnableResearchCostModifer.Value)
                {
                    __result = CustomStartConfig.ResearchCostModifer.Value;
                }
                break;
            case ModifierType.Taxes:
                if (company.IsPlayer && CustomStartConfig.EnableTaxesModifer.Value)
                {
                    __result = CustomStartConfig.TaxesModifer.Value;
                }
                break;
            case ModifierType.Interest:
                if (company.IsPlayer && CustomStartConfig.EnableInterestModifer.Value)
                {
                    __result = CustomStartConfig.InterestModifer.Value;
                }
                break;
        }
        
    }
}
