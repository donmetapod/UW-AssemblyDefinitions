using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
    [SerializeField] UnityEvent OnSpacebarPressed;
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            OnSpacebarPressed?.Invoke();
        }
    }
}
