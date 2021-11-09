using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationsController : MonoBehaviour
{
    private Animator animator;
    private new Rigidbody2D rigidbody2D;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnFire(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        animator.SetTrigger("Attack");
    }

    public void OnMove(InputAction.CallbackContext obj)
    {
        if (!obj.performed)
            return;
        var lastFacingDirection = obj.ReadValue<Vector2>();
        animator.SetFloat("StickX", lastFacingDirection.x);
        animator.SetFloat("StickY", lastFacingDirection.y);
    }

    private void Update()
    {
        animator.SetFloat("Speed", rigidbody2D.velocity.sqrMagnitude);
    }
}
