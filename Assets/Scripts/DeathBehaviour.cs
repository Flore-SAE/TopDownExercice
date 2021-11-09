using UnityEngine;

[RequireComponent(typeof(HealthBehaviour))]
public abstract class DeathBehaviour : MonoBehaviour
{
    private HealthBehaviour healthBehaviour;

    private void Awake()
    {
        healthBehaviour = GetComponent<HealthBehaviour>();
    }

    private void Update()
    {
        CheckForDeath();
    }

    private void CheckForDeath()
    {
        if (healthBehaviour.currentHealth > 0) return;
        Die();
        Destroy(this);
    }

    protected abstract void Die();
}
