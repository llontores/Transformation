using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private float _addedDistance;
    [SerializeField] private float _speed;

    private Vector3 _startPosition;
    private Vector3 _targetXPosition;
    private Vector3 _nextPosition;

    private void Start()
    {
        _startPosition = transform.position;
        _targetXPosition.x = transform.position.x + _addedDistance;
    }

    private void Update()
    {
        _nextPosition = (transform.position == _targetXPosition) ? _startPosition : (transform.position == _startPosition) ? _targetXPosition : _nextPosition;

        if (transform.position != _nextPosition)
            transform.position = Vector3.MoveTowards(transform.position, _nextPosition, _speed * Time.deltaTime);
    }   

}
