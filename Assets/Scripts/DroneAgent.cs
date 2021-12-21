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
    
    private DroneController _droneController;
    private UnityEngine.InputSystem.PlayerInput _playerInput;
    
    public override void Initialize()
    {
        base.Initialize();
        
        _droneController = GetComponent<DroneController>();
        _playerInput = GetComponent<UnityEngine.InputSystem.PlayerInput>();
        
        if (TryGetComponent(out BehaviorParameters behaviorParameters))
            _playerInput.enabled = behaviorParameters.BehaviorType switch
            {
                BehaviorType.HeuristicOnly => true,
                BehaviorType.InferenceOnly => false,
                BehaviorType.Default => false,
                _ => _playerInput.enabled
            };
    }
    
    public override void OnActionReceived(ActionBuffers actionBuffers)
    {
        _droneController.SetEnginePower("FrontLeft", actionBuffers.ContinuousActions[0]);
        _droneController.SetEnginePower("FrontRight", actionBuffers.ContinuousActions[1]);
        _droneController.SetEnginePower("RearLeft", actionBuffers.ContinuousActions[2]);
        _droneController.SetEnginePower("RearRight", actionBuffers.ContinuousActions[3]);
        
        if (MaxStep > 0) AddReward(-1f / MaxStep);
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
        sensor.AddObservation(GetDirectionToTarget(_checkpointManager.CurrentCheckpoint));
        sensor.AddObservation(GetDistanceToTarget(_checkpointManager.CurrentCheckpoint));
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        return;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Checkpoint checkpoint))
        {
            _checkpointManager.SetRandomCheckpoint();
            AddReward(1f);
        }
    }

    private Vector3 GetDirectionToTarget(Transform target) => 
        (target.position - transform.position).normalized;

    private float GetDistanceToTarget(Transform target) =>
        Vector3.Distance(transform.position, target.position);

    private Vector3 GetTilt() => transform.up;

    private float GetAltitude() => transform.position.y;
}
