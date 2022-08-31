using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftScript : MonoBehaviour
{
    
    //public ThirdPersonController script;
    public GameObject floorTurbine;
    public GameObject playerArm;
    public Vector3 lowerPos;
    public Vector3 upperPos;
    bool isUp = true;
    
    void OnEnable()
    {
        isUp = !isUp;
        StartCoroutine("Teleport");
        
    }

    IEnumerator Teleport()
    {
        playerArm.SetActive(false);
        //playerArm.GetComponent<CharacterController>().enabled = false;
        yield return new WaitForSeconds(0.01f);
        if (isUp)
        {
            Debug.Log("ladder down");
            playerArm.transform.localPosition = lowerPos;

        }
        else
        {
            Debug.Log("ladder up");
            playerArm.transform.localPosition = upperPos;

        }
        Physics.SyncTransforms();
        yield return new WaitForSeconds(0.01f);
        //playerArm.GetComponent<CharacterController>().enabled = true;
       playerArm.SetActive(true);
        gameObject.SetActive(false);
        
    }

}
//Vector3(-14.4799995,0,-16.8999996)

//Vector3(55.0659409,4.67275333,25.699194)
//Vector3(55.5064125,29.3659153,25.4983215)