# Custom Start for Processor Tycoon

Custom Start is a mod for Processor Tycoon that allows you to fully customize your starting conditions and apply various gameplay modifiers to tailor the experience to your liking.

## Features

- **Custom Starting Funds:** Start with as much (or as little) money as you want.
- **Adjustable Factory Size:** Control the number of factory lines you begin with.
- **Selectable Difficulty & Technology:** Override the default starting difficulty and technology levels.
- **Gameplay Modifiers:** fine-tune research speed, maintenance costs, construction costs, development costs, research costs, taxes, and interest rates.

## ⚠️ Important Note on UI

**This mod does not fully synchronize with the game's UI during the new game creation screen.** 

While the text labels in the UI may update to reflect your configuration, the interactive elements (sliders/buttons) in the game's menu might not match the actual values that will be used. 

**All customization must be done in the mod's configuration file (`ca.jwolf.customStart.cfg`) BEFORE starting the game.** The values set in the config file will override any selections made in the game's UI.

---

## Configuration Guide

The configuration file is located in your BepInEx config folder (usually `BepInEx\config\ca.jwolf.customStart.cfg`).

### [Start] Settings

These settings control your initial state when a new game begins.

| Field | Default | Description                                                                                                                               |
| :--- | :--- |:------------------------------------------------------------------------------------------------------------------------------------------|
| **StartingFunds** | 2,500,000 | The amount of cash your company starts with.                                                                                              |
| **FactoryLines** | 5 | The number of factory lines available at the start.                                                                                       |
| **DifficultyLevel** | Normal | The overall difficulty level, this includes the AI's difficulty. Options: `VeryEasy`, `Easy`, `Normal`, `Hard`, `VeryHard`, `Impossible`. |
| **StartingTechLevel** | Competitive | Your starting technology level relative to competitors. Options: `AheadOfTime`, `Competitive`, `Behind`, `VeryBehind`, `SlightlyBehind`. |

### [ResearchModifiers] Settings

These modifiers allow you to change the scaling of various game mechanics. To use a modifier, you must set its corresponding `Enable...` field to `true`.

| Field | Default | Description |
| :--- | :--- | :--- |
| **EnableResearchSpeedModifer** | false | Enables the research speed modifier. |
| **ResearchSpeedModifer** | 1.0 | Multiplier for research speed. (e.g., 2.0 is twice as fast). |
| **EnableMaintainanceCostModifer** | false | Enables the maintenance cost modifier. |
| **MaintainanceCostModifer** | 1.0 | Multiplier for maintenance costs. |
| **EnableConstructionCostModifer** | false | Enables the construction cost modifier. |
| **ConstructionCostModifer** | 1.0 | Multiplier for building/factory construction costs. |
| **EnableDevelopmentCostModifer** | false | Enables the development cost modifier. |
| **DevelopmentCostModifer** | 1.0 | Multiplier for product development costs. |
| **EnableResearchCostModifer** | false | Enables the research cost modifier. |
| **ResearchCostModifer** | 1.0 | Multiplier for the cost of research projects. |
| **EnableTaxesModifer** | false | Enables the taxes modifier. |
| **TaxesModifer** | 1.0 | Multiplier for tax rates. |
| **EnableInterestModifer** | false | Enables the interest modifier. |
| **InterestModifer** | 1.0 | Multiplier for interest on loans. |

---

## Installation

1. Install [BepInEx](https://github.com/BepInEx/BepInEx).
2. Place the `customStart.dll` into the `BepInEx/plugins/customStart` folder.
3. Run the game once to generate the config file.
4. Edit `BepInEx/config/ca.jwolf.customStart.cfg` to your desired settings.
5. Start a new game!
