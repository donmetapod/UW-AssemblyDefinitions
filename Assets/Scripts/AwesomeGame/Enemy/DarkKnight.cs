using UnityEngine;
using SharedData;
using SharedComponents;

namespace AwesomeGame.Enemy
{
    public class DarkKnight : MonoBehaviour
    {
        CharacterConfiguration _characterConfiguration;
            
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                GetComponent<Health>().CurrentHealth -= 1;
            }
        }
    }
}
