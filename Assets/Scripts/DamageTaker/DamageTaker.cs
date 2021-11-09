using UnityEngine;

[RequireComponent(typeof(HealthBehaviour))]
public abstract class DamageTaker : MonoBehaviour
{
    private HealthBehaviour healthBehaviour;

    private void Awake()
    {
        healthBehaviour = GetComponent<HealthBehaviour>();
    }

    protected void TakeDamage(DamageGiver damageGiver)
    {
        if(damageGiver != null)
            healthBehaviour.TakeDamage(damageGiver.damageToGive);
    }
}
