using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;

    private new Rigidbody2D rigidbody2D;

    private Transform player;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        var playerDirection = player.position - transform.position;
        playerDirection = playerDirection.normalized;
        rigidbody2D.velocity = playerDirection * speed;
    }
}
