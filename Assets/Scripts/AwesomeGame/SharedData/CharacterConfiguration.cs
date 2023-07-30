using UnityEngine;

namespace AwesomeGame.SharedData
{
    [CreateAssetMenu(fileName = "CharacterConfiguration", menuName = "Scriptable Objects/Create Character Configuration Asset")]
    public class CharacterConfiguration : ScriptableObject
    {
        public Vector2 JumpForce;
    } 
}


