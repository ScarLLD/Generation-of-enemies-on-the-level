using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Transform _target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
