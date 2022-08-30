using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogsManager : MonoBehaviour
{
    public GameObject playerCog1;
    public GameObject playerCog2;
    public GameObject playerCog3;
    public GameObject playerCog4;
    public GameObject playerCog5;

    public static bool cogCompletion = false;

    public void FixedUpdate()
    {
        if (CogSlots.cog1InPlace)
        {
            playerCog1.transform.Rotate(0, 0, -1);
        }

        if (CogSlots.cog2InPlace && CogSlots.cog1InPlace)
        {
            playerCog2.transform.Rotate(0, 0, +1);
        }

        if (CogSlots.cog3InPlace && CogSlots.cog2InPlace && CogSlots.cog1InPlace)
        {
            playerCog3.transform.Rotate(0, 0, -1);
        }

        if (CogSlots.cog4InPlace && CogSlots.cog3InPlace && CogSlots.cog2InPlace && CogSlots.cog1InPlace)
        {
            playerCog4.transform.Rotate(0, 0, +1);
        }

        if (CogSlots.cog5InPlace && CogSlots.cog4InPlace && CogSlots.cog3InPlace && CogSlots.cog2InPlace && CogSlots.cog1InPlace)
        {
            playerCog5.transform.Rotate(0, 0, -1);
            cogCompletion = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().questStep = 6;
        }
    }
}
