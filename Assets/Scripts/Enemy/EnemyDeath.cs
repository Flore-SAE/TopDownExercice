public class EnemyDeath : DeathBehaviour
{
    protected override void Die()
    {
        Destroy(gameObject);
    }
}
