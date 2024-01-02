using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private EnemyMove _enemyPrefab;

    [SerializeField] private GameObject[] _spawnPoints;

    [SerializeField] private RedefinedMover[] _targets;

    private EnemyMove _enemy;
    private int _spawnTime = 2;
    private bool _isSpawn = true;

    private void Start()
    {
        StartCoroutine(SpawnEnemys());
    }

    private IEnumerator SpawnEnemys()
    {
        var waitSpawn = new WaitForSeconds(_spawnTime);

        while (_isSpawn)
        {
            int randomIndex = Random.Range(0, _targets.Length);

            _enemy = Instantiate(_enemyPrefab, _spawnPoints[randomIndex].transform);

            _enemy.SetTarget(_targets[randomIndex].transform);

            yield return waitSpawn;
        }
    }
}

