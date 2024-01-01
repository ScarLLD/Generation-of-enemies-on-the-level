using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private EnemyMove _enemyPrefab;

    [SerializeField] private RedefinedMover _targets;

    private EnemyMove _enemy;

    private void Start()
    {
        _enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.Euler(0, Random.Range(0, 360), 0));
    }

    private void Update()
    {
        _enemy.SetTarget(_targets.transform.position);
    }
}

