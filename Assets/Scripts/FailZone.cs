using System;
using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out DroneAgent agent))
        {
            if (Vector3.Angle(agent.transform.up, transform.up) >= 90)
            {
                agent.Fail();
            }
        }
    }
}
