using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool isRunning;
    public float minSpawnTime, maxSpawnTime;
    public GameObject enemy;

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        isRunning = true;
        while (isRunning)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
