using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float _moveSpeed = 0.005f;

    private void Update()
    {
        var nextPostion = transform.localPosition;
        nextPostion.x += _moveSpeed;
        transform.localPosition = nextPostion;
    }
}
