using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScalev2 : MonoBehaviour
{
    [SerializeField] private float _cycleDuration;
    [SerializeField] private float _targetScaleValue;
    private Vector3 _startScale;
    private Vector3 _targetScale;

    private void Start()
    {
        _startScale = transform.localScale;
        _targetScale = new Vector3(_targetScaleValue, _targetScaleValue, _targetScaleValue);
    }

    private void Update()
    {
        float pingPongTime = Mathf.PingPong(Time.time, _cycleDuration);
        transform.localScale = Vector3.Lerp(_startScale, _targetScale, pingPongTime / _cycleDuration);
    }
}
