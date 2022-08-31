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
        switch (questStep)
        {
            case 1:
                questLog.text = "Repair the wires on the Solar Panels outside.";
                break;

            case 2:
                questLog.text = "Activate the Solar Panels inside the base.";
                break;

            case 3:
                questLog.text = "Return to Camp and rest.";
                break;

            case 4:
                questLog.text = "Connect the pipes in the Geothermal Station.";
                break;

            case 5:
                questLog.text = "Open the valves in the Geothermal Station.";
                break;

            case 6:
                questLog.text = "Return to Camp and rest.";
                break;

            case 7:
                questLog.text = "Find gears to repair the Wind Turbine gearbox.";
                break;

            case 8:
                questLog.text = "Repair the gearbox in the Wind Turbine.";
                break;

            case 9:
                questLog.text = "Rotate the Wind Turbine.";
                break;

            case 10:
                questLog.text = "Rest, then move on!";
                break;
        }
    }
}