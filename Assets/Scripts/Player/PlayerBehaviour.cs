using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    private AddForceMove2D move;

    private Roller2D roll;

    private PlayerAnimationsController animations;
    private new Rigidbody2D rigidbody2D;

    private Vector2 direction;
    private Vector2 lastFacingDirection;

    private void Awake()
    {
        move = GetComponent<AddForceMove2D>();
        roll = GetComponent<Roller2D>();
        animations = GetComponent<PlayerAnimationsController>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnRoll(InputAction.CallbackContext obj)
    {
        if (!obj.performed) return;
        roll.Roll(lastFacingDirection);
        animations.OnRoll();
    }

    public void OnMove(InputAction.CallbackContext obj)
    {
        var value = obj.ReadValue<Vector2>();
        direction = value;
        if (!obj.performed) return;
        animations.UpdateFacingDirection(value);
        lastFacingDirection = value;
    }

    public void OnFire(InputAction.CallbackContext obj)
    {
        if (!obj.performed) return;
        animations.OnAttack();
    }

    private void FixedUpdate()
    {
        move.Move(direction);
    }

    private void Update()
    {
       animations.SetSpeed(rigidbody2D.velocity.sqrMagnitude);
    }
}
