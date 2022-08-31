using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBuildingHide : MonoBehaviour
{
    //script for hiding outside bit on enter
    public MeshRenderer buildingToHide;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            buildingToHide.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            buildingToHide.enabled = true;
        }
    }
}
