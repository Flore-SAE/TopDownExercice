using System;
using UnityEngine;

public class LifeDisplayer4 : MonoBehaviour
{
    public GameObject heart;
    public PlayerHealthTunnel playerHealthTunnel;

    private void OnEnable()
    {
        playerHealthTunnel.lifeDisplayer = this;
    }

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

    private void OnDisable()
    {
        playerHealthTunnel.lifeDisplayer = null;
    }
}
