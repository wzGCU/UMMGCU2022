using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject switchOff1;
    public GameObject switchOn1;

    void Start()
    {
        switchOff1.SetActive(false);
        switchOn1.SetActive(true);
    }

    public void ChangeSwitch()
    {
        switchOn1.SetActive(false);
        switchOff1.SetActive(true);
    }


    void Update()
    {
        
    }
}
