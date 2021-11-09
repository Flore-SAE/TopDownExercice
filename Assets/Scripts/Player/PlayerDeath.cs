using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDeath : MonoBehaviour
{
    private HealthBehaviour healthBehaviour;

    private void Awake()
    {
        healthBehaviour = GetComponent<HealthBehaviour>();
    }

    private void Update()
    {
        if (healthBehaviour.currentHealth == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<Animator>().SetBool("IsDead", true);
        GetComponent<PlayerInput>().enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;
        Destroy(this);
    }
}
