using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    private Mover2D move2D;
    private Transform player;

    private void Awake()
    {
        move2D = GetComponent<Mover2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        var playerDirection = player.position - transform.position;
        move2D.Move(playerDirection);
    }

}
