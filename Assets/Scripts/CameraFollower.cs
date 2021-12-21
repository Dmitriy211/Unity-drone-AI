using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        transform.position = _target.TransformPoint(new Vector3(0, 2, -5));
        transform.forward = Vector3.ProjectOnPlane(_target.forward, Vector3.up);
    }
}
