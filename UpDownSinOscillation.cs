using System;
using UnityEngine;

public class UpDownSinOscillation : MonoBehaviour
{
    private Vector3 _startPos;
    private Transform _transform;

    private void Start()
    {
        this._transform = base.transform;
        this._startPos = this._transform.position;
    }

    private void Update()
    {
        Vector3 position = this._transform.position;
        position.y = this._startPos.y + (Mathf.Sin(Time.timeSinceLevelLoad * 2f) * 0.4f);
        this._transform.position = position;
    }
}
