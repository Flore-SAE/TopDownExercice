using UnityEngine;

[CreateAssetMenu]
public class PlayerSpeedTunnel : ScriptableObject
{
    [HideInInspector] public SpeedDisplayer2 speedDisplayer;

    public void DisplaySpeed(float newSpeed)
    {
        speedDisplayer.UpdateText(newSpeed);
    }
}
