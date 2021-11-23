using UnityEngine;

[CreateAssetMenu]
public class PlayerHealth : ScriptableObject
{
    public int health { get; private set; }

    public void SetHealth(int newHealth)
    {
        health = newHealth;
    }
}
