using UnityEngine;

[CreateAssetMenu(menuName = "Create Movement", fileName = "MovementSO", order = 0)]
public class MovementSO: ScriptableObject
{
    public float speed;

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
