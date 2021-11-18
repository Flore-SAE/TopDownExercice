using UnityEngine;

public class VelocityRoll2D : Roller2D
{
    public float rollDistance;

    public override void Roll(Vector2 direction)
    {
        rigidbody2D.velocity = direction.normalized * rollDistance * rigidbody2D.drag;
    }
}
