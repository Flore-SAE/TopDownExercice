using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationsController : MonoBehaviour
{
    private Controls controls;

    private Animator animator;
    private HealthBehaviour healthBehaviour;
    private new Rigidbody2D rigidbody2D;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        healthBehaviour = GetComponent<HealthBehaviour>();
        controls = new Controls();
        controls.Enable();
        controls.Player.Move.performed += OnMovePerformed;
        controls.Player.Fire.performed += OnFirePerformed;
    }

    private void OnFirePerformed(InputAction.CallbackContext obj)
    {
        animator.SetTrigger("Attack");
    }

    private void OnMovePerformed(InputAction.CallbackContext obj)
    {
        var lastFacingDirection = obj.ReadValue<Vector2>();
        animator.SetFloat("StickX", lastFacingDirection.x);
        animator.SetFloat("StickY", lastFacingDirection.y);
    }

    private void Update()
    {
       animator.SetFloat("Speed", rigidbody2D.velocity.sqrMagnitude);
       animator.SetBool("IsDead", healthBehaviour.currentHealth == 0);
    }
}
