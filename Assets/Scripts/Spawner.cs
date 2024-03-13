using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnerPoint[] _spawnPoint;

    private int minRandomValue = 0;
    private int maxRandomValue = 3;

    private float _spawnTime = 2;

    private void Start()
    {
        var waitForSeconds = new WaitForSeconds(_spawnTime);

        StartCoroutine(Spawning(waitForSeconds));
    }

    private IEnumerator Spawning(WaitForSeconds wait)
    {
        while (true)
        {
            ActivateSpawnPoint();

            yield return wait;
        }
    }

    private void ActivateSpawnPoint()
    {
        int currentSpawnPoint = Random.Range(minRandomValue, maxRandomValue);

        SpawnerPoint spawnerPoint = _spawnPoint[currentSpawnPoint];
        spawnerPoint.Spawn();
    }
}
