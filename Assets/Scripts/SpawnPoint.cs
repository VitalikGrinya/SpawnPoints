using System.Collections;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private WaitForSeconds _waitForSpawnEnemy;

    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _spawnPoint;

    private float _spawnTime = 2;
    private void Start()
    {
        _waitForSpawnEnemy = new WaitForSeconds(_spawnTime);

        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            var spawnedEnemy = Instantiate(_enemy, _spawnPoint.position, Quaternion.identity);

            yield return _waitForSpawnEnemy;
        }
    }
}