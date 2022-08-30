using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject gameElements;

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

    public AudioManager audioManager;

    public bool switchIsOn1;
    public bool switchIsOn2;
    public bool switchIsOn3;
    public bool switchIsOn4;
    public bool switchIsOn5;
    public bool switchIsOn6;

    void Start()
    {
        gameElements.SetActive(true);

        switchOff1.SetActive(false);
        switchOn1.SetActive(true);

        switchOff2.SetActive(true);
        switchOn2.SetActive(false);

        switchOff3.SetActive(false);
        switchOn3.SetActive(true);

        switchOff4.SetActive(true);
        switchOn4.SetActive(false);

        switchOff5.SetActive(true);
        switchOn5.SetActive(false);

        switchOff6.SetActive(false);
        switchOn6.SetActive(true);

        switchIsOn1 = true;
        switchIsOn2 = false;
        switchIsOn3 = true;
        switchIsOn4 = false;
        switchIsOn5 = false;
        switchIsOn6 = true;
    }

    public void Switch1Clicked()
    {
        audioManager.Play("LightSwitch" + Random.Range(1, 3));

        if (switchIsOn1)
        {
            switchOn1.SetActive(false);
            switchOff1.SetActive(true);
            switchIsOn1 = false;
        }

        else if (!switchIsOn1)
        {
            switchOn1.SetActive(true);
            switchOff1.SetActive(false);
            switchIsOn1 = true;
        }
    }

    public void Switch2Clicked()
    {
        audioManager.Play("LightSwitch" + Random.Range(1, 3));

        if (switchIsOn2)
        {
            switchOn2.SetActive(false);
            switchOff2.SetActive(true);
            switchIsOn2 = false;
        }

        else if (!switchIsOn2)
        {
            switchOn2.SetActive(true);
            switchOff2.SetActive(false);
            switchIsOn2 = true;
        }
    }

    public void Switch3Clicked()
    {
        audioManager.Play("LightSwitch" + Random.Range(1, 3));

        if (switchIsOn3)
        {
            switchOn3.SetActive(false);
            switchOff3.SetActive(true);
            switchIsOn3 = false;
        }

        else if (!switchIsOn3)
        {
            switchOn3.SetActive(true);
            switchOff3.SetActive(false);
            switchIsOn3 = true;
        }
    }

    public void Switch4Clicked()
    {
        audioManager.Play("LightSwitch" + Random.Range(1, 3));

        if (switchIsOn4)
        {
            switchOn4.SetActive(false);
            switchOff4.SetActive(true);
            switchIsOn4 = false;
        }

        else if (!switchIsOn4)
        {
            switchOn4.SetActive(true);
            switchOff4.SetActive(false);
            switchIsOn4 = true;
        }
    }

    public void Switch5Clicked()
    {
        audioManager.Play("LightSwitch" + Random.Range(1, 3));

        if (switchIsOn5)
        {
            switchOn5.SetActive(false);
            switchOff5.SetActive(true);
            switchIsOn5 = false;
        }

        else if (!switchIsOn5)
        {
            switchOn5.SetActive(true);
            switchOff5.SetActive(false);
            switchIsOn5 = true;
        }
    }

    public void Switch6Clicked()
    {
        audioManager.Play("LightSwitch" + Random.Range(1, 3));

        if (switchIsOn6 == true)
        {
            switchOn6.SetActive(false);
            switchOff6.SetActive(true);
            switchIsOn6 = false;
        }

        else if (!switchIsOn6)
        {
            switchOn6.SetActive(true);
            switchOff6.SetActive(false);
            switchIsOn6 = true;
        }
    }

    void Update()
    {
        if(switchIsOn1 && switchIsOn2 && switchIsOn3 && switchIsOn4 && switchIsOn5 && switchIsOn6)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().questStep = 3;
            Debug.Log("Congrats u win!");
            gameElements.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}