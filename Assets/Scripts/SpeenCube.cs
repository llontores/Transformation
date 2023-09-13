using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeenCube : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(new Vector3 (0, _speed,0) * Time.deltaTime);
    }
}
