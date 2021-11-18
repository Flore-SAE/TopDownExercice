using UnityEngine;

public class AddForceRoll2D : Roller2D
{
    public float rollForce;

    public override void Roll(Vector2 direction)
    {
        rigidbody2D.AddForce(direction.normalized * rollForce, ForceMode2D.Impulse);
    }
}
