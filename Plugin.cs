using BepInEx;
using UnityEngine;
using EFT;

namespace QuestMusicRemover
{
    [BepInPlugin("com.riku8405.questmusicremover", "QuestMusicRemover", "1.0.0")]
    [BepInDependency("com.spt-aki.core", "3.6.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            Logger.LogInfo("QuestMusicRemover");
        }    
    }
}