using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangingMG : MonoBehaviour
{
    void FixedUpdate()
    {
        gameObject.transform.Rotate(0, 0, +1);//Rotate(x, y, z) + = add one per update
    }

    void OnTriggerEnter2D(Collider2D other)
    {

    }
}
