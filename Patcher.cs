using System.Linq;
using System.Reflection;
using Aki.Reflection.Patching;
using Comfort.Common;
using EFT.UI;
using UnityEngine;

namespace QuestMusicRemover
{
    internal class GUISoundsPatch
    {
        static EUISoundType[] bannedSoundTypes = {
            EUISoundType.QuestCompleted,
            EUISoundType.QuestFailed,
            EUISoundType.QuestFinished,
            EUISoundType.QuestStarted,
            EUISoundType.QuestSubTrackComplete
        };

        public class PatcherClass : ModulePatch
        {
            protected override MethodBase GetTargetMethod()
            {
                return typeof(GUISounds).GetMethod("PlayUISound", BindingFlags.Instance | BindingFlags.Public);
            }

            [PatchPrefix]
            static bool PrefixPatch(EUISoundType soundType)
            {
                if (bannedSoundTypes.Contains(soundType))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
