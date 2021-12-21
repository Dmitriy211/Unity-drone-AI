using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class DroneController : MonoBehaviour
{
    [SerializeField] private Engine[] _engines;
    [SerializeField] private Transform _resetTransform;

    private UnityEngine.InputSystem.PlayerInput _playerInput;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _playerInput = GetComponent<UnityEngine.InputSystem.PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _playerInput.actions["FrontLeft"].performed += MoveFrontLeft;
        _playerInput.actions["FrontLeft"].canceled += MoveFrontLeft;
        _playerInput.actions["FrontRight"].performed += MoveFrontRight;
        _playerInput.actions["FrontRight"].canceled += MoveFrontRight;
        _playerInput.actions["RearLeft"].performed += MoveRearLeft;
        _playerInput.actions["RearLeft"].canceled += MoveRearLeft;
        _playerInput.actions["RearRight"].performed += MoveRearRight;
        _playerInput.actions["RearRight"].canceled += MoveRearRight;
    }

    public void SetEnginePower(string name, float power)
    {
        if (power < 0) return;
        _engines.First(e => e.Name == name).Power = power;
    }
    
    public float GetEnginePower(string name)
    {
        return _engines.First(e => e.Name == name).Power;
    }
    
    private void MoveFrontLeft(InputAction.CallbackContext inputContext) =>
        SetEnginePower("FrontLeft", inputContext.ReadValue<Vector2>().magnitude);
    
    private void MoveFrontRight(InputAction.CallbackContext inputContext) =>
        SetEnginePower("FrontRight", inputContext.ReadValue<Vector2>().magnitude);
    
    private void MoveRearLeft(InputAction.CallbackContext inputContext) =>
        SetEnginePower("RearLeft", inputContext.ReadValue<Vector2>().magnitude);
    
    private void MoveRearRight(InputAction.CallbackContext inputContext) =>
        SetEnginePower("RearRight", inputContext.ReadValue<Vector2>().magnitude);

    public void Reset()
    {
        _rigidbody.velocity = Vector3.zero;
        transform.position = _resetTransform.position;
        transform.rotation = _resetTransform.rotation;

        foreach (var e in _engines) e.Power = 0;
    }
}
