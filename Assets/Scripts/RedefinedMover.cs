using System.Collections;
using UnityEngine;

public class RedefinedMover : MonoBehaviour
{    
    [SerializeField] private Vector3 _startPosition = new Vector3(0, 0, 0);
    [SerializeField] private Vector3 _endPosition = new Vector3(11, 0, 0);
    [SerializeField] private int _stepsCount = 10;

    private IEnumerator _enumerator;
    private float _timer = 0.0f;
    private float _timeStep;

    private void Start()
    {
        _enumerator = GetEnumerator();
        _timeStep = 4.0f / _stepsCount;
    }

    private void Update()
    {
        if(_timer <= Time.time)
        {
            _enumerator.MoveNext();
            _timer = Time.time + _timeStep;
        }
    }

    private IEnumerator GetEnumerator()
    {
        return EnumeratePositions(_startPosition, _endPosition, _stepsCount);
    }

    private IEnumerator EnumeratePositions(Vector3 startPosition, Vector3 endPosition, int steps)
    {
        Vector3 distance = startPosition - endPosition;
        Vector3 stepValue = distance / steps;
        Vector3 currentStep;

        for (int step = 0; step <= steps; step++)
        {
            currentStep = stepValue * step;
            transform.position = startPosition - currentStep;
            yield return null;
        }
    }
}
