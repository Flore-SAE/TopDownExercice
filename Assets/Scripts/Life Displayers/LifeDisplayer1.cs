using UnityEngine;

public class LifeDisplayer1 : MonoBehaviour
{
    public GameObject heart;

    private HealthBehaviour playerHealth;

    // Start is called before the first frame update
    private void Start()
    {
        var player = GameObject.FindWithTag("Player");
        playerHealth = player.GetComponent<HealthBehaviour>();
    }

    private void UpdateHearts(int heartNumber)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        for (var i = 0; i < heartNumber; i++)
        {
            Instantiate(heart, Vector3.zero, Quaternion.identity, transform);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateHearts(playerHealth.currentHealth);
    }
}
