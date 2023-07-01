using UnityEngine;

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