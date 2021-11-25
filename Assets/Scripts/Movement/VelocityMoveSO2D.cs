using UnityEngine;

public class VelocityMoveSO2D : Mover2D
{
    public MovementSO movement;
    public override void Move(Vector2 direction)
    {
        rigidbody2D.velocity = direction.normalized * movement.speed;
    }
}
