using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameWireRandomise : MonoBehaviour
{
    private void Awake()
    {
        for(int i =0; i<transform.childCount; i++)
        {
            int newSpot = Random.Range(0, transform.childCount); //choosing random child
            Vector3 temp = transform.GetChild(i).position;
            //swapping position of 2 objects
            transform.GetChild(i).position = transform.GetChild(newSpot).position;
            transform.GetChild(newSpot).position = temp;
        }
    }
}
