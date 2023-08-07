using BepInEx;
using BepInEx.Configuration;

namespace QuestMusicRemover
{
    [BepInPlugin("com.riku8405.questmusicremover", "QuestMusicRemover", "1.0.0")]
    [BepInDependency("com.spt-aki.core", "3.6.1")]
    public class Plugin : BaseUnityPlugin
    {
        // Configuration
        public static ConfigEntry<bool> disableStartMusic { get; set; } // Disable quest start music
        public static ConfigEntry<bool> disableFailMusic { get; set; } // Disable quest fail music
        public static ConfigEntry<bool> disableConditionCompleteMusic { get; set; } // Disable quest condition hand over music
        public static ConfigEntry<bool> disableAvailableForFinishMusic { get; set; } // Disable available for finish music
        public static ConfigEntry<bool> disableTurnInMusic { get; set; } // Disable turn in music

        void Awake()
        {
            Logger.LogInfo("Loaded version 1.0.0rc2");
        }

        void Start()
        {
            // Set default configuration values
            disableStartMusic = Config.Bind("Quest Music Remover", "Disable Start Music", true, "Disables music when starting a quest");
            disableFailMusic = Config.Bind("Quest Music Remover", "Disable Fail Music", true, "Disables music when failing a quest");
            disableConditionCompleteMusic = Config.Bind("Quest Music Remover", "Disable Condition Turn In Music", true, "Disables music when  turning in an item for a condition or a condition being completed");
            disableAvailableForFinishMusic = Config.Bind("Quest Music Remover", "Disable Available for Finish Music", true, "Disables music when a quest is available to be completed or turned in");
            disableTurnInMusic = Config.Bind("Quest Music Remover", "Disable Turn In Music", true, "Disables music when a quest is turned in or completed");

            // Enable the Patcher
            new GUISoundsPatch.PatcherClass().Enable();
        }
    }
}