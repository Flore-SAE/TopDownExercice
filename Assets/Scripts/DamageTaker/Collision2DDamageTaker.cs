using UnityEngine;

public class Collision2DDamageTaker : DamageTaker
{
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        TakeDamage(collision2D.gameObject.GetComponent<DamageGiver>());
    }
}
