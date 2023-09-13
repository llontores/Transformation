using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardV2 : MonoBehaviour
{
    [SerializeField] private float _cycleDuration;
    [SerializeField] private float _addedDistance;

    private Vector3 _startPosition;
    private Vector3 _targetXPosition;

    private void Start()
    {
        _startPosition = transform.position;
        _targetXPosition.x = transform.position.x + _addedDistance;
    }

    private void Update()
    {
        float pingPongTime = Mathf.PingPong(Time.time, _cycleDuration);
        transform.position = Vector3.Lerp(_startPosition, _targetXPosition, pingPongTime / _cycleDuration);
    }
}
