using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private float _maxForce;
    [SerializeField] private float _maxTorque;
    [SerializeField] private bool _clockwise;
    
    private Rigidbody _rigidbody;
    
    public string Name => _name;
    public float Power { get; set; }
    
    private void Awake()
    {
        _rigidbody = GetComponentInParent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        ApplyRotorForce();
    }

    private void ApplyRotorForce()
    {
        float force = Power.Remap(0, 1, 0, _maxForce);
        float torque = Power.Remap(0, 1, 0, _maxTorque);
        
        _rigidbody.AddForceAtPosition( force * transform.up, transform.position);
        _rigidbody.AddTorque(0, _clockwise ? torque : -torque, 0);
    }
}
