using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCog : MonoBehaviour
{
    void FixedUpdate()
    {
        if(CogsManager.cogCompletion == true)
        {
            gameObject.transform.Rotate(0, 0, +1);
            Debug.Log("yay, minigame completed!");
        }
    }
}
