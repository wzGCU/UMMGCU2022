using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GearCounter : MonoBehaviour
{
    private TMP_Text gearText;
    public int gearCount = 0;
    public int requiredGearCount = 10;
    public bool gearsWelded;
    public Player player;
    public GameObject playerCamera;
    public GameObject weldingGameElements;


    void Start()
    {
        gearsWelded = false;
        gearText = GetComponent<TMP_Text>();
       // player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }


    void Update()
    {
        gearText.text = gearCount.ToString();

        if (gearCount == requiredGearCount && !gearsWelded)
        {
            weldingGameElements.SetActive(true);
            playerCamera.SetActive(false);
        }
    }
}