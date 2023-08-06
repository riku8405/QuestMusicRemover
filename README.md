# QuestMusicRemover
## A mod for [SPT-AKI](https://www.sp-tarkov.com/) version 3.6.0 that removes the music from quests (completion music, fail music, etc) 
## Contribution - Cloning
### Option A. Clone using HTTPS
#### Clone the repository using the URL `https://github.com/riku8405/QuestMusicRemover.git`
### Option B. GitHub CLI
#### Run the command `gh repo clone riku8405/QuestMusicRemover` inside of GitHub CLI

## Contribution - Referencing dependencies
### In order to build the program, you must reference the required dependencies, this is a table of the dependencies and where you can find them in relation to your SPT-AKI folder.
**_NOTE:_** In order to get the Assembly-CSharp.dll you must dump the assemblies, a guide can be found [here](https://gist.github.com/DrakiaXYZ/4254536168bb8dfa623b539ef9ed133a)
| Aseembly name | Location |
|----------|:-------------:|
| 0Harmony.dll | BepInEx/Core/0Harmony.dll |
| Aki.Reflection.dll | EscapeFromTarkov_Data/Managed/Aki.Reflection.dll |
| Assembly-CSharp.dll | BepInEx/DumpedAssemblies/EscapeFromTarkov/Assembly-CSharp.dll |
| BepInEx.dll | BepInEx/Core/BepInEx.dll |
| Comfort.dll | EscapeFromTarkov_Data/Managed/Comfort.dll |
| UnityEngine.dll | EscapeFromTarkov_Data/Managed/UnityEngine.dll |
| UnityEngine.AudioModule.dll | EscapeFromTarkov_Data/Managed/UnityEngine.AudioModule.dll |
| UnityEngine.CoreModule.dll | EscapeFromTarkov_Data/Managed/UnityEngine.CoreModule.dll |

## Contribution - Building
### Option A. Run dotnet build
#### Do I really have to say how to do this?
