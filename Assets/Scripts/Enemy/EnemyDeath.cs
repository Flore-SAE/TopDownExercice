using UnityEngine;

public class EnemyDeath : MonoBehaviour
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
            Destroy(gameObject);
        }
    }
}
