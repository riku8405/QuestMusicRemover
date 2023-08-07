using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Aki.Reflection.Patching;
using BepInEx.Configuration;
using Comfort.Common;
using EFT.UI;
using UnityEngine;

namespace QuestMusicRemover
{
    internal class GUISoundsPatch
    {
        public class PatcherClass : ModulePatch
        {
            // List of EUISoundTypes that contain music
            static EUISoundType[] bannedSoundTypes = {
                EUISoundType.QuestStarted,
                EUISoundType.QuestFailed,
                EUISoundType.QuestSubTrackComplete,
                EUISoundType.QuestFinished,
                EUISoundType.QuestCompleted
            };

            // Dictionary of EUISoundType to the config entry
            static Dictionary<EUISoundType, ConfigEntry<bool>> soundTypeConfigDictionary = new Dictionary<EUISoundType, ConfigEntry<bool>>()
            {
                { EUISoundType.QuestStarted, Plugin.disableStartMusic },
                { EUISoundType.QuestFailed, Plugin.disableFailMusic },
                { EUISoundType.QuestSubTrackComplete, Plugin.disableConditionCompleteMusic },
                { EUISoundType.QuestCompleted, Plugin.disableAvailableForFinishMusic },
                { EUISoundType.QuestFinished, Plugin.disableTurnInMusic }
            };

            // Find the Original method
            protected override MethodBase GetTargetMethod()
            {
                return typeof(GUISounds).GetMethod("PlayUISound", BindingFlags.Instance | BindingFlags.Public);
            }

            // Create a prefix patch hooking into the original method (when an EUISoundType is played)
            [PatchPrefix]
            static bool PrefixPatch(EUISoundType soundType)
            {
                // If the EUISoundType is apart of the banned EUISoundTypes (that contain music)
                if (bannedSoundTypes.Contains(soundType) && soundTypeConfigDictionary[soundType].Value == true) {
                    return false; // Don't play the EUISoundType
                }
                // Otherwise
                else
                {
                    return true; // Play the EUISoundType
                }
            }
        }
    }
}
