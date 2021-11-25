using UnityEngine;

public class LifeDisplayer3 : MonoBehaviour
{
    public GameObject heart;
    public PlayerHealth playerHealth;

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

    private void Update()
    {
        UpdateHearts(playerHealth.health);
    }
}
