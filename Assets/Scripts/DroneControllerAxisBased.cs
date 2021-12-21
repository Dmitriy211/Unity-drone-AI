using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class DroneControllerAxisBased : MonoBehaviour
{
    [SerializeField] private Engine[] _engines;
    [SerializeField] private Transform _resetTransform;
    [SerializeField] private float _pitchSensitivity;
    [SerializeField] private float _rollSensitivity;
    [SerializeField] private float _yawSensitivity;
    [SerializeField] private float _thrustSensitivity;

    private UnityEngine.InputSystem.PlayerInput _playerInput;
    private Rigidbody _rigidbody;
    private float _thrust;
    private float _pitch;
    private float _roll;
    private float _yaw;

    private void Awake()
    {
        _playerInput = GetComponent<UnityEngine.InputSystem.PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _playerInput.actions["Thrust"].performed += Thrust;
        _playerInput.actions["Thrust"].canceled += Thrust;
        _playerInput.actions["PitchRoll"].performed += PitchRoll;
        _playerInput.actions["PitchRoll"].canceled += PitchRoll;
        _playerInput.actions["Yaw"].performed += Yaw;
        _playerInput.actions["Yaw"].canceled += Yaw;
    }

    public void SetEnginePower(string name, float power)
    {
        if (power < 0) return;
        _engines.First(e => e.Name == name).Power = power;
    }

    private void UpdateEnginePowers()
    {
        SetEnginePower("FrontLeft", _thrust - _yaw + _pitch - _roll);
        SetEnginePower("FrontRight", _thrust + _yaw + _pitch + _roll);
        SetEnginePower("RearLeft", _thrust + _yaw - _pitch - _roll);
        SetEnginePower("RearRight", _thrust - _yaw - _pitch + _roll);
    }

    public void SetInputs(float thrust, float pitch, float roll, float yaw)
    {
        _thrust = thrust;
        _pitch = pitch;
        _roll = roll;
        _yaw = yaw;
        UpdateEnginePowers();
    }

    private void Thrust(InputAction.CallbackContext inputContext)
    {
        _thrust = inputContext.ReadValue<float>() * _thrustSensitivity;
        UpdateEnginePowers();
    }

    private void PitchRoll(InputAction.CallbackContext inputContext)
    {
        _pitch = -inputContext.ReadValue<Vector2>().y * _pitchSensitivity;
        _roll = -inputContext.ReadValue<Vector2>().x * _rollSensitivity;
        UpdateEnginePowers();
    }

    private void Yaw(InputAction.CallbackContext inputContext)
    {
        _yaw = -inputContext.ReadValue<Vector2>().x * _yawSensitivity;
        UpdateEnginePowers();
    }

    public void Reset()
    {
        _rigidbody.velocity = Vector3.zero;
        transform.position = _resetTransform.position;
        transform.rotation = _resetTransform.rotation;

        _pitch = 0;
        _thrust = 0;
        _roll = 0;
        _yaw = 0;
        foreach (var e in _engines) e.Power = 0;
    }
}
