using UnityEngine;

public class EnemyAnimationsController : MonoBehaviour, IDie
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnDie()
    {
        animator.SetTrigger("Die");
    }
}
