using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    private AddForceMove2D move;

    private Roller2D roll;

    private PlayerAnimationsController animations;

    private Vector2 direction;
    private Vector2 lastFacingDirection;

    // Start is called before the first frame update
    private void Awake()
    {
        move = GetComponent<AddForceMove2D>();
        roll = GetComponent<Roller2D>();
        animations = GetComponent<PlayerAnimationsController>();
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
        if (obj.performed)
        {
            animations.UpdateFacingDirection(value);
            lastFacingDirection = value;
        }

        direction = value;
    }

    public void OnFire(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            animations.OnAttack();
        }
    }

    private void FixedUpdate()
    {
        move.Move(direction);
    }
}
