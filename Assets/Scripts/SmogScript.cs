using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmogScript : MonoBehaviour
{
    public Player player;
    public HealthBar healthBar;
    public float totalTime = 0;
    public int disappearQuestStep;

    private void OnTriggerStay(Collider other)
    {
        totalTime += Time.deltaTime;
        if (totalTime > 1)
        {
            player.currentHealth -= 5;
            healthBar.SetHealh(player.currentHealth);
            totalTime = 0;
            Debug.Log(player.currentHealth);
        }
    }

    private void Update()
    {
        if (player.questStep >= disappearQuestStep)
        {
            Destroy(gameObject);
        }
    }
}
