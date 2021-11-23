using UnityEngine;

public class LifeDisplayer2 : MonoBehaviour
{
    public GameObject heart;

    public void UpdateHearts(int heartNumber)
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
}
