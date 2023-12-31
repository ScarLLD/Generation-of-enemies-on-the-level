using UnityEngine;

public class EnemysSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private GameObject[] _enemySpawnPlaces;

    private void Start()
    {
        CreateEnemys();
    }

    private void CreateEnemys()
    {
        InvokeRepeating(nameof(CreateWithInstantiate), 2, 2);
    }

    private void CreateWithInstantiate()
    {
        GameObject randomSpawnPlace = _enemySpawnPlaces[Random.Range(0, _enemySpawnPlaces.Length)];

        var unused = Instantiate(_enemyPrefab, randomSpawnPlace.transform.position, Quaternion.EulerRotation(0, Random.Range(0, 360), 0));
        Debug.Log("1");
    }
}
