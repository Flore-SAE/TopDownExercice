using UnityEngine;

[RequireComponent(typeof(HealthBehaviour))]
public class DeathBehaviour : MonoBehaviour
{
    private void Awake()
    {
        var healthBehaviour = GetComponent<HealthBehaviour>();
        healthBehaviour.healthChanged.AddListener(CheckForDeath);
    }

    private void CheckForDeath(int health)
    {
        if (health > 0) return;
        StartDying();
    }

    private void StartDying()
    {
        var dieComponents = GetComponents<IDie>();
        foreach (var component in dieComponents)
        {
            component.OnDie();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
