using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public GearCounter gearCounter;
    private void OnTriggerEnter(Collider other)
    {
        gearCounter.gearCount += 1;
        Destroy(gameObject);
    }
}
