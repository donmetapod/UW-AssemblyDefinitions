using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace AwesomeGame.Player
{
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
}

