using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int _maxHealth = 100;
    private int _currentHealth;
    public int CurrentHealth
    {
        get => _currentHealth;
        set
        {
            _currentHealth = value;
            if (_currentHealth <= 0)
            {
                _currentHealth = 0;
                Die();
            }
            else if (_currentHealth > _maxHealth)
            {
                _currentHealth = _maxHealth;
            }
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}


