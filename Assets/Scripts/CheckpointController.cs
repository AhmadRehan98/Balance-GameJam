using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{

    public static Transform lastCheckpoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            lastCheckpoint = transform;
            print("Checkpoint reached, checkpoint is now " + lastCheckpoint.position);
        }
    }
}
