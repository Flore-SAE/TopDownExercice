using UnityEngine;

public class PlayerAnimationsController : MonoBehaviour
{
    private Animator animator;
    private new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnDie()
    {
        animator.SetBool("IsDead", true);
    }

    public void UpdateFacingDirection(Vector2 lastFacingDirection)
    {
        animator.SetFloat("StickX", lastFacingDirection.x);
        animator.SetFloat("StickY", lastFacingDirection.y);
    }

    public void OnAttack()
    {
        animator.SetTrigger("Attack");
    }

    public void OnRoll()
    {
        animator.SetTrigger("Roll");
    }

    private void Update()
    {
        animator.SetFloat("Speed", rigidbody2D.velocity.sqrMagnitude);
    }
}
