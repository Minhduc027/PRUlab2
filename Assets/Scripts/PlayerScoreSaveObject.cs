using CarterGames.Assets.SaveManager;
using UnityEngine;

namespace Save
{
    [CreateAssetMenu(fileName = "PlayerScoreSaveObject")]
    public class PlayerScoreSaveObject : SaveObject
    {
        public SaveValue<int> score;
        public SaveValue<int> timeStamp;
    }
}