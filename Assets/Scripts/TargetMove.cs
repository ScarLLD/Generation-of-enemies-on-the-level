using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition = new Vector3(0, 0, 0);
    [SerializeField] private Vector3 _endPosition = new Vector3(11, 0, 0);
    [SerializeField] private int _stepsCount = 10;

    void Start()
    {
        foreach (Vector3 position in EnumeratePositions(_startPosition, _endPosition, _stepsCount))
        {
            transform.position = position;
        }
    }

    private IEnumerable<Vector3> EnumeratePositions(Vector3 startPosition, Vector3 endPosition, int steps)
    {
        Vector3 distance = startPosition - endPosition;
        Vector3 stepValue = distance / steps;
        Vector3 currentStep;

        for (int step = 0; step <= steps; step++)
        {
            currentStep = stepValue * step;
            yield return startPosition - currentStep;
        }
    }
}
