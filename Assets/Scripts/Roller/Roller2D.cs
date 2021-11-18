using UnityEngine;

public abstract class Roller2D : MonoBehaviour
{
    protected new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public abstract void Roll(Vector2 direction);
}
