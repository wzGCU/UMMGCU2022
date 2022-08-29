using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public PipeCounter pipeCounter;
    private void OnTriggerEnter(Collider other)
    {
        pipeCounter.pipeCount += 1;
        Destroy(gameObject);
    }
}
