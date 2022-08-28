using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingCogs : MonoBehaviour
{
    void FixedUpdate()
    {
        gameObject.transform.Rotate(0, 0, +1);
    }
}
