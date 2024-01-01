using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Vector3 _targetPosition;

    public void SetTarget(Vector3 position)
    {
        _targetPosition = position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);        
    }
}
