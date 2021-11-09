using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private int health;

    [SerializeField] private float speed;

    private new Rigidbody2D rigidbody2D;

    private Transform player;


    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        var playerDirection = player.position - transform.position;
        playerDirection = playerDirection.normalized;
        rigidbody2D.velocity = playerDirection * speed;
    }

}
