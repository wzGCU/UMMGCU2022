using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScroll : MonoBehaviour
{
    public int scrollSpeed = 1;

    void FixedUpdate()
    {
        if (gameObject.transform.position.y < 1420)
        {
            gameObject.transform.Translate(0, scrollSpeed, 0);
        }
    }
}
