using UnityEngine;

[CreateAssetMenu]
public class PlayerHealthTunnel : ScriptableObject
{
    [HideInInspector] public LifeDisplayer4 lifeDisplayer;

    public void DisplayHealth(int newHealth)
    {
        lifeDisplayer.UpdateHearts(newHealth);
    }
}
