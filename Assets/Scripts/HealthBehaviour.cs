using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{
    public int maxHealth, startHealth;

    public int currentHealth { get; private set; }

    public UnityEvent<int> healthChanged;
    public UnityEvent damageTaken;

    private void Start()
    {
        currentHealth = startHealth;
        healthChanged.Invoke(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        damageTaken.Invoke();
        ModifyHealth(-damage);
    }

    public void Heal(int health)
    {
        ModifyHealth(health);
    }

    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
        healthChanged.Invoke(currentHealth);
    }
}
