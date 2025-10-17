using BepInEx;
using BepInEx.Logging;

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
    }
}
