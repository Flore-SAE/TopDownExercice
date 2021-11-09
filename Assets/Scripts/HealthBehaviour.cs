using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    public int maxHealth, startHealth;

    public int currentHealth { get; private set; }

    private void Start()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(int damage)
    {
        ModifyHealth(-damage);
    }

    public void Heal(int health)
    {
        ModifyHealth(health);
    }

    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }
}
