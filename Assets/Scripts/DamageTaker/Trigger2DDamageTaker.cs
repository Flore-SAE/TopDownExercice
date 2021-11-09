using UnityEngine;

public class Trigger2DDamageTaker : DamageTaker
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        TakeDamage(other.GetComponent<DamageGiver>());
    }
}
