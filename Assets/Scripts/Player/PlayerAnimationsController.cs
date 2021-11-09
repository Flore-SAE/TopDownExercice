using System;
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
        switch (obj.phase)
        {
            case InputActionPhase.Performed:
                OnAttack();
                break;
            case InputActionPhase.Disabled:
                break;
            case InputActionPhase.Waiting:
                break;
            case InputActionPhase.Started:
                break;
            case InputActionPhase.Canceled:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void OnMove(InputAction.CallbackContext obj)
    {
        switch (obj.phase)
        {
            case InputActionPhase.Disabled:
                break;
            case InputActionPhase.Waiting:
                break;
            case InputActionPhase.Started:
                break;
            case InputActionPhase.Performed:
                UpdateFacingDirection(obj.ReadValue<Vector2>());
                break;
            case InputActionPhase.Canceled:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void OnDie()
    {
        animator.SetBool("IsDead", true);
    }

    private void UpdateFacingDirection(Vector2 lastFacingDirection)
    {
        animator.SetFloat("StickX", lastFacingDirection.x);
        animator.SetFloat("StickY", lastFacingDirection.y);
    }

    private void OnAttack()
    {
        animator.SetTrigger("Attack");
    }

    private void Update()
    {
        animator.SetFloat("Speed", rigidbody2D.velocity.sqrMagnitude);
    }
}
