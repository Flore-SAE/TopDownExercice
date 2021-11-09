using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerDeath : DeathBehaviour
{
    protected override void Die()
    {
        GetComponent<PlayerInput>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;
        GetComponent<PlayerAnimationsController>().OnDie();
    }
}
