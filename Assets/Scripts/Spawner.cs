using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float minSpawnTime, maxSpawnTime;
    public GameObject enemy;

    public Transform objectToRotateAround;
    public float speed;

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
    }

    private void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        transform.RotateAround(objectToRotateAround.position, Vector3.forward, speed * Time.deltaTime);
    }

}
