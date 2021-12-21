using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CheckpointManager : MonoBehaviour
{
    [SerializeField] private GameObject _checkpointPrefab;
    [SerializeField] private Transform[] _initialTransforms;
    [SerializeField] private float _spawnRadius = 5;

    public Transform CurrentCheckpoint;
    public int _initialCount;

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
    
    public void SetNextCheckpoint()
    {
        if (_initialCount <= _initialTransforms.Length - 1)
        {
            SetCheckpoint(_initialTransforms[_initialCount].position);
            _initialCount++;
        }
        else SetRandomCheckpoint();
    }

    public void Reset()
    {
        _initialCount = 0;
        SetNextCheckpoint();
    }
}
