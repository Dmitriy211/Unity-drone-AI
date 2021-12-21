using System;
using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Policies;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class DroneAgent : Agent
{
    [SerializeField] private CheckpointManager _checkpointManager;
    [SerializeField] private float _idleSecondsToReset = 2;
    [SerializeField] private float _speedThreshold = 0.001f;
    
    private DroneControllerAxisBased _droneController;
    private UnityEngine.InputSystem.PlayerInput _playerInput;
    private BehaviorParameters _behaviorParameters;
    private float _idleTime;
    private Rigidbody _rigidbody;

    private void FixedUpdate()
    {
        if (_behaviorParameters.BehaviorType == BehaviorType.HeuristicOnly) return;

        if ((_rigidbody.velocity.magnitude + _rigidbody.angularVelocity.magnitude) < _speedThreshold)
        {
            _idleTime += Time.deltaTime;
            if (_idleTime > _idleSecondsToReset)
            {
                _idleTime = 0;
                Fail();
            }
        }
        else _idleTime = 0;
    }

    public override void Initialize()
    {
        base.Initialize();

        _droneController = GetComponent<DroneControllerAxisBased>();
        _playerInput = GetComponent<UnityEngine.InputSystem.PlayerInput>();
        _behaviorParameters = GetComponent<BehaviorParameters>();
        _rigidbody = GetComponent<Rigidbody>();

        _playerInput.enabled = _behaviorParameters.BehaviorType switch
        {
            BehaviorType.HeuristicOnly => true,
            BehaviorType.InferenceOnly => false,
            BehaviorType.Default => false,
            _ => _playerInput.enabled
        };
    }

    public override void OnActionReceived(ActionBuffers actionBuffers)
    {
        if (_behaviorParameters.BehaviorType == BehaviorType.HeuristicOnly) return;
        
        _droneController.SetInputs(
            Mathf.Clamp(actionBuffers.ContinuousActions[0], 0, 1),
            actionBuffers.ContinuousActions[1],
            actionBuffers.ContinuousActions[2],
            actionBuffers.ContinuousActions[3]
        );
        
        // _droneController.SetEnginePower("FrontLeft", actionBuffers.ContinuousActions[0]);
        // _droneController.SetEnginePower("FrontRight", actionBuffers.ContinuousActions[1]);
        // _droneController.SetEnginePower("RearLeft", actionBuffers.ContinuousActions[2]);
        // _droneController.SetEnginePower("RearRight", actionBuffers.ContinuousActions[3]);
        
        if (MaxStep > 0) AddReward(-1f / MaxStep);
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        return;
    }

    public override void OnEpisodeBegin()
    {
        Debug.Log("reset");
        _checkpointManager.Reset();
        _droneController.Reset();
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(GetTilt());
        sensor.AddObservation(GetAltitude());
        // sensor.AddObservation(GetVelocity());
        sensor.AddObservation(GetDirectionToTarget(_checkpointManager.CurrentCheckpoint));
        sensor.AddObservation(GetDistanceToTarget(_checkpointManager.CurrentCheckpoint));
    }

    private Vector3 GetVelocity() => _rigidbody.velocity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Checkpoint checkpoint))
        {
            _checkpointManager.SetNextCheckpoint();
            AddReward(2f);
        }
    }

    private Vector3 GetDirectionToTarget(Transform target) => 
        (target.position - transform.position).normalized;

    private float GetDistanceToTarget(Transform target) =>
        Vector3.Distance(transform.position, target.position);

    private Vector3 GetTilt() => transform.up;

    private float GetAltitude() => transform.position.y;

    public void Fail()
    {
        AddReward(1f / (MaxStep) * (MaxStep - StepCount));
        EndEpisode();
    }
}
