using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class DroneController : MonoBehaviour
{
    [SerializeField] private Engine[] _engines;

    private UnityEngine.InputSystem.PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<UnityEngine.InputSystem.PlayerInput>();
    }

    private void OnEnable()
    {
        _playerInput.actions["FrontLeft"].performed += MoveFrontLeft;
        _playerInput.actions["FrontRight"].canceled += MoveFrontRight;
        _playerInput.actions["RearLeft"].performed += MoveRearLeft;
        _playerInput.actions["RearRight"].performed += MoveRearRight;
    }

    private void SetEnginePower(string name, float power)
    {
        _engines.First(e => e.Name == name).Power = power;
    }
    
    private void MoveFrontLeft(InputAction.CallbackContext inputContext) =>
        SetEnginePower("FrontLeft", inputContext.ReadValue<Vector2>().magnitude);
    
    private void MoveFrontRight(InputAction.CallbackContext inputContext) =>
        SetEnginePower("FrontRight", inputContext.ReadValue<Vector2>().magnitude);
    
    private void MoveRearLeft(InputAction.CallbackContext inputContext) =>
        SetEnginePower("RearLeft", inputContext.ReadValue<Vector2>().magnitude);
    
    private void MoveRearRight(InputAction.CallbackContext inputContext) =>
        SetEnginePower("RearRight", inputContext.ReadValue<Vector2>().magnitude);
}
