using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D _rigidbody2D;
    [SerializeField]
    CharacterConfiguration _characterConfiguration;
    
    public void Jump()
    {
        _rigidbody2D.AddForce(_characterConfiguration.JumpForce, ForceMode2D.Impulse);
    }
}
