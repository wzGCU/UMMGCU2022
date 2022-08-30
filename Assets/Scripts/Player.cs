using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public TextMeshProUGUI questLog;
    public int questStep;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        questStep = 1;
    }


    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     currentHealth -= 10;
        //     healthBar.SetHealth(currentHealth);
        //     Debug.Log("HP : "+currentHealth);
        // }

        switch (questStep)
        {
            case 1:
                questLog.text = "Repair the wires on the Solar Panels.";
                break;

            case 2:
                questLog.text = "Activate the Solar Panels.";
                break;

            case 3:
                questLog.text = "Connect the pipes in the Geothermal Station.";
                break;

            case 4:
                questLog.text = "Open the valves in the Geothermal Station.";
                break;

            case 5:
                questLog.text = "Repair the gearbox in the Wind Turbine.";
                break;

            case 6:
                questLog.text = "Rotate the Wind Turbine.";
                break;

            case 7:
                questLog.text = "Continue saving the Planet!";
                break;
        }
    }
}