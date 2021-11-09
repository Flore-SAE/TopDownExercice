using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float acceleration;
    public float maxSpeed;

    private Controls controls;

    private Vector2 direction;
    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        controls = new Controls();
        controls.Enable();
        controls.Player.Move.performed += OnMovePerformed;
        controls.Player.Move.canceled += OnMoveCanceled;
    }

    private void OnMoveCanceled(InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
    }

    private void OnMovePerformed(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if(rigidbody2D.velocity.sqrMagnitude < maxSpeed)
            rigidbody2D.AddForce(direction * acceleration);
    }
}
