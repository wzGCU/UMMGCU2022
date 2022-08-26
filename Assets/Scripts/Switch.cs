using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject switchOff1;
    public GameObject switchOn1;
    public GameObject switchOff2;
    public GameObject switchOn2;
    public GameObject switchOff3;
    public GameObject switchOn3;
    public GameObject switchOff4;
    public GameObject switchOn4;
    public GameObject switchOff5;
    public GameObject switchOn5;
    public GameObject switchOff6;
    public GameObject switchOn6;

    public bool switchIsOff1 = false;
    public bool switchIsOn1 = true;
    public bool switchIsOff2 = true;
    public bool switchIsOn2 = false;
    public bool switchIsOff3 = true;
    public bool switchIsOn3 = false;
    public bool switchIsOff4 = false;
    public bool switchIsOn4 = true;
    public bool switchIsOff5 = true;
    public bool switchIsOn5 = false;
    public bool switchIsOff6 = false;
    public bool switchIsOn6 = true;

    public int switchTally = 0;

    void Start()
    {
        switchOff1.SetActive(false);
        switchOn1.SetActive(true);
        switchOff2.SetActive(true);
        switchOn2.SetActive(false);
        switchOff3.SetActive(true);
        switchOn3.SetActive(false);
        switchOff4.SetActive(false);
        switchOn4.SetActive(true);
        switchOff5.SetActive(true);
        switchOn5.SetActive(false);
        switchOff6.SetActive(false);
        switchOn6.SetActive(true);
    }

    public void Switch1Clicked()
    {
        if (switchIsOn1 == true)
        {
            switchOn1.SetActive(false);
            switchOff1.SetActive(true);
            switchIsOn1 = false;
            switchIsOff1 = true;
        }

        else if (switchIsOff1 == true)
        {
            switchOn1.SetActive(true);
            switchOff1.SetActive(false);
            switchIsOn1 = true;
            switchIsOff1 = false;
        }
    }

    public void Switch2Clicked()
    {
        if (switchIsOn2 == true)
        {
            switchOn2.SetActive(false);
            switchOff2.SetActive(true);
            switchIsOn2 = false;
            switchIsOff2 = true;
        }

        else if (switchIsOff2 == true)
        {
            switchOn2.SetActive(true);
            switchOff2.SetActive(false);
            switchIsOn2 = true;
            switchIsOff2 = false;
            switchTally++;
        }

        Debug.Log("on" + switchIsOn2);
        Debug.Log("off" + switchIsOff2);
    }

    public void Switch3Clicked()
    {
        if (switchIsOn3 == true)
        {
            switchOn3.SetActive(false);
            switchOff3.SetActive(true);
            switchIsOn3 = false;
            switchIsOff3 = true;
        }

        else if (switchIsOff3 == true)
        {
            switchOn3.SetActive(true);
            switchOff3.SetActive(false);
            switchIsOn3 = true;
            switchIsOff3 = false;
            switchTally++;
        }
    }

    public void Switch4Clicked()
    {
        if (switchIsOn4 == true)
        {
            switchOn4.SetActive(false);
            switchOff4.SetActive(true);
            switchIsOn4 = false;
            switchIsOff4 = true;
        }

        else if (switchIsOff4 == true)
        {
            switchOn4.SetActive(true);
            switchOff4.SetActive(false);
            switchIsOn4 = true;
            switchIsOff4 = false;
        }
    }

    public void Switch5Clicked()
    {
        if (switchIsOn5 == true)
        {
            switchOn5.SetActive(false);
            switchOff5.SetActive(true);
            switchIsOn5 = false;
            switchIsOff5 = true;
        }

        else if (switchIsOff5 == true)
        {
            switchOn5.SetActive(true);
            switchOff5.SetActive(false);
            switchIsOn5 = true;
            switchIsOff5 = false;
            switchTally++;
        }
    }

    public void Switch6Clicked()
    {
        if (switchIsOn6 == true)
        {
            switchOn6.SetActive(false);
            switchOff6.SetActive(true);
            switchIsOn6 = false;
            switchIsOff6 = true;
        }

        else if (switchIsOff6 == true)
        {
            switchOn6.SetActive(true);
            switchOff6.SetActive(false);
            switchIsOn6 = true;
            switchIsOff6 = false;
        }
    }

    void Update()
    {
        Debug.Log(switchTally);
    }
}

