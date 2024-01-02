using System.Collections;
using UnityEngine;

public class RedefinedMover : MonoBehaviour
{    
    [SerializeField] private Vector3 _startPosition = new Vector3(0, 0, 0);
    [SerializeField] private Vector3 _endPosition = new Vector3(11, 0, 0);

    private void Start()
    {
        StartCoroutine(MoveObject());
    }        

    private IEnumerator MoveObject()
    {
        float minDistance = 0.1f;        
        float speed = 0.5f;

        while (Vector3.Distance(_startPosition, _endPosition) > minDistance)
        {
            transform.localPosition = Vector3.Lerp(_startPosition, _endPosition, Time.time * speed);
            yield return null;
        }
    }
}
