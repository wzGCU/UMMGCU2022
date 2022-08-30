using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    public GameObject displayText;
    private bool _playerInArea;
    public Player player;

    void Start()
    {
        _playerInArea = false;
        displayText.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }


    void Update()
    {
        if (_playerInArea && Input.GetKeyDown(KeyCode.F) && (player.questStep == 3 || player.questStep == 6 || player.questStep == 10))
        {
            switch (player.questStep)
            {
                case 3:
                    player.questStep = 4;
                    break;

                case 6:
                    player.questStep = 6;
                    break;

                case 9:
                    //END GAME
                    break;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (player.questStep == 3 || player.questStep == 6 || player.questStep == 10)
        {
            if (other.gameObject.tag == "Player")
            {
                displayText.SetActive(true);
                _playerInArea = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            {
                displayText.SetActive(false);
                _playerInArea = false;
            }
    }
}