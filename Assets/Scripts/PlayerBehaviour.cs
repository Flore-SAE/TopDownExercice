using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Health")] [SerializeField] private int health;
    [Header("Speed")] [SerializeField] private float acceleration;
    [SerializeField] private float maxSpeed;

    private Animator animator;
    private new Rigidbody2D rigidbody2D;
    private Vector2 direction;
    private Controls controls;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Player.Move.performed += OnMovePerformed;
        controls.Player.Move.canceled += OnMoveCanceled;
        controls.Player.Fire.performed += OnFirePerformed;
    }

    private void OnFirePerformed(InputAction.CallbackContext obj)
    {
        animator.SetTrigger("Attack");
    }

    private void OnMoveCanceled(InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
    }

    private void OnMovePerformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
        animator.SetFloat("StickX", direction.x);
        animator.SetFloat("StickY", direction.y);
    }

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        health--;
        if (health <= 0)
        {
            animator.SetBool("IsDead", true);
            controls.Disable();
            rigidbody2D.simulated = false;

        }
    }

    // Update is called once per frame
    private void Update()
    {
        animator.SetFloat("Speed", rigidbody2D.velocity.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        if (rigidbody2D.velocity.sqrMagnitude < maxSpeed)
            rigidbody2D.AddForce(direction * acceleration);
    }
}
