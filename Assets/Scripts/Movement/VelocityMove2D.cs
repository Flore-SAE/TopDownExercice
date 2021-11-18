using UnityEngine;

public class VelocityMove2D : Mover2D
{
    public float speed;

    public override void Move(Vector2 direction)
    {
        rigidbody2D.velocity = direction.normalized * speed;
    }
}
