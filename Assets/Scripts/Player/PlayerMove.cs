using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float acceleration;
    public float maxSpeed;

    private Vector2 direction;
    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if(rigidbody2D.velocity.sqrMagnitude < maxSpeed)
            rigidbody2D.AddForce(direction * acceleration);
    }
}
