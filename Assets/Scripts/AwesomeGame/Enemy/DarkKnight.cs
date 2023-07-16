using UnityEngine;
using AwesomeGame.SharedData;
using AwesomeGame.SharedComponents;

namespace AwesomeGame.Enemy
{
    public class DarkKnight : MonoBehaviour
    {
        [SerializeField] CharacterConfiguration _characterConfiguration;
            
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                GetComponent<Health>().CurrentHealth -= 1;
            }
        }
    }
}
