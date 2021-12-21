using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CheckpointManager : MonoBehaviour
{
    [SerializeField] private GameObject _checkpointPrefab;
    [SerializeField] private Transform _initialTransform;
    [SerializeField] private float _spawnRadius = 5;

    public Transform CurrentCheckpoint;

    public void Start()
    {
        Reset();
    }

    public void SetCheckpoint(Vector3 position)
    {
        if (CurrentCheckpoint) Destroy(CurrentCheckpoint.gameObject);
        
        CurrentCheckpoint = Instantiate(
            _checkpointPrefab,
            position,
            Quaternion.identity,
            transform
        ).transform;
    }
    
    public void SetRandomCheckpoint()
    {
        SetCheckpoint(transform.TransformPoint(Random.insideUnitSphere * _spawnRadius));
    }

    public void Reset()
    {
        SetCheckpoint(_initialTransform.position);
    }
}
