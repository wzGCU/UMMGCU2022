using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     currentHealth -= 10;
        //     healthBar.SetHealth(currentHealth);
        //     Debug.Log("HP : "+currentHealth);
        // }    
    }
}
