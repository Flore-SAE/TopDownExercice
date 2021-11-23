using UnityEngine;

public class PlayerAnimationsController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
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

    public void SetSpeed(float speed)
    {
        animator.SetFloat("Speed", speed);
    }
}
